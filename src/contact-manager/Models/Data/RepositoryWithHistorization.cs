using System.ComponentModel.DataAnnotations;
using System.Reflection;
using contact_manager.Models.Data.History;
using contact_manager.Models.Domain.Authentication;
using contact_manager.Views;

namespace contact_manager.Models.Data;

internal class RepositoryWithHistorization<T> : IRepository<T> where T : IObjectIdentifier
{
    private readonly IRepository<T> _repository;

    private readonly IRepository<HistoryEntry> _historizedRepository;

    private readonly User _currentUser;

    public RepositoryWithHistorization(User currentUser)
    {
        this._repository = new Repository<T>(new FileStore<T>());
        this._historizedRepository = new Repository<HistoryEntry>(new FileStore<HistoryEntry>());
        this._currentUser = currentUser;
    }

    public List<T> GetAll()
    {
        return this._repository.GetAll();
    }

    public T GetById(long id)
    {
        return this._repository.GetById(id);
    }

    public void Save(T entity)
    {
        var entityBeforeUpdate = this.GetAll().FirstOrDefault(e => e.Id == entity.Id);
        this._repository.Save(entity);
        this.Historize(entity, entityBeforeUpdate);
    }

    public void Delete(long id)
    {
        this._repository.Delete(id);
    }

    public long GetNewId()
    {
        return this._repository.GetNewId();
    }

    private void Historize(T entityNew, T? entityOld)
    {
        var historyEntry = this.CreateHistoryEntry(entityNew, entityOld);
        if (historyEntry.Diffs.Any())
        {
            this._historizedRepository.Save(historyEntry);
        }
    }

    private HistoryEntry CreateHistoryEntry(T entityNew, T? entityOld)
    {
        return new HistoryEntry
        {
            Id = this._historizedRepository.GetNewId(),
            EntityId = entityNew.Id,
            TimeStamp = DateTime.Now,
            EntityType = (entityNew is Customer)
                ? EntityType.Customer
                : (entityNew is Trainee)
                    ? EntityType.Trainee
                    : EntityType.Employee,
            UserId = this._currentUser.Id,
            Diffs = RepositoryWithHistorization<T>.GetDifferences(entityNew, entityOld).ToList(),
        };
    }

    private static IEnumerable<Difference> GetDifferences(T entityNew, T? entityOld)
    {
        var properties = entityNew.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach (var property in properties)
        {
            var newValue = RepositoryWithHistorization<T>.GetFormattedPropertyValue(property, entityNew);
            var oldValue = RepositoryWithHistorization<T>.GetFormattedPropertyValue(property, entityOld);
            if (!Equals(newValue, oldValue))
            {
                var displayName = property.GetCustomAttribute<DisplayAttribute>()?.Name ?? property.Name;

                yield return new Difference
                {
                    PropertyName = displayName,
                    ValueNew = newValue,
                    ValueOld = oldValue
                };
            }
        }
    }

    private static object? GetFormattedPropertyValue(PropertyInfo property, T? entity)
    {
        if (entity == null)
            return null;

        return property.GetValue(entity) switch
        {
            int value => value != 0 ? value : null,
            Enum value => value.GetDisplayName(),
            string value => string.IsNullOrWhiteSpace(value) ? null : value,
            DateTime value => value.ToLongDateString(),
            _ => property.GetValue(entity)
        };
    }
}

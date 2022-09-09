using System.Text.Json;
using contact_manager.Models.Domain.History;

namespace contact_manager.Models.Data;

internal class FileStore<T> : IStore<T> where T : IObjectIdentifier
{
    private readonly string dataDirectory = $"{AppDomain.CurrentDomain.BaseDirectory}/Data";

    private readonly string fileName = $"{typeof(T).Name}.json";

    private string FilePath => Path.Combine(this.dataDirectory, this.fileName);

    private readonly IHistoryService _historyService;
    public FileStore(IHistoryService historyService)
    {
        this._historyService = historyService;
    }
    public List<T> GetAll()
    {
        if (!File.Exists(this.FilePath))
            return new List<T>();

        var jsonString = File.ReadAllText(this.FilePath);
        return JsonSerializer.Deserialize<List<T>>(jsonString) ?? new List<T>();
    }

    public void UpdateOrAdd(T entity)
    {
        var entities = this.GetAll();
        var index = entities.FindIndex(p => p.Id == entity.Id);
        if (index != -1)
        {
            var entityOld = entities[index];

            this._historyService.Add(entity, entityOld);
            entities[index] = entity;
        }
        else
        {
            this._historyService.Add(entity);

            entities.Add(entity);
        }

        this.Write(entities);
    }

    public void Delete(long id)
    {
        var entities = this.GetAll();
        entities.RemoveAll(p => p.Id == id);
        this.Write(entities);
    }

    private void Write(List<T> entities)
    {
        var jsonString = JsonSerializer.Serialize(entities);
        Directory.CreateDirectory(this.dataDirectory);
        File.WriteAllText(this.FilePath, jsonString);
    }
}

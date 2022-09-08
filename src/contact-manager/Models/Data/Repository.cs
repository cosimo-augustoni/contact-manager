namespace contact_manager.Models.Data;

internal class Repository<T> : IRepository<T> where T : IObjectIdentifier
{
    private readonly IStore<T> _store;

    public Repository(IStore<T> store)
    {
        this._store = store;
    }

    public List<T> GetAll()
    {
        return this._store.GetAll();
    }

    public T GetById(long id)
    {
        return this._store.GetAll().First(c => c.Id == id);
    }

    public void Save(T person)
    {
        this._store.UpdateOrAdd(person);
    }

    public void Delete(long id)
    {
        this._store.Delete(id);
    }

    public long GetNewId()
    {
        var persons = this._store.GetAll();
        return persons.Count > 0 ? persons.Max(p => p.Id) + 1 : 0;
    }
}

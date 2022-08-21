namespace contact_manager.Models.Data;

internal class PersonRepository<T> : IPersonRepository<T> where T : Person
{
    private readonly IPersonStore<T> store;

    public PersonRepository(IPersonStore<T> store)
    {
        this.store = store;
    }

    public List<T> GetAll()
    {
        return this.store.GetAll();
    }

    public T GetById(long id)
    {
        return this.store.GetAll().First(c => c.Id == id);
    }

    public void Save(T person)
    {
        this.store.UpdateOrAdd(person);
    }

    public void Delete(long id)
    {
        this.store.Delete(id);
    }

    public long GetNewId()
    {
        var persons = this.store.GetAll();
        return persons.Count > 0 ? persons.Max(p => p.Id) + 1 : 0;
    }
}

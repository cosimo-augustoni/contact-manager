namespace contact_manager.Models.Data
{
    internal interface IPersonStore<T> where T : Person
    {
        List<T> GetAll();

        void UpdateOrAdd(T person);

        void Delete(long id);
    }
}

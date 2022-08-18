namespace contact_manager.Models.Data
{
    internal interface IPersonRepository<T> where T : Person
    {
        List<T> GetAll();

        T GetById(long id);

        void Save(T person);

        void Delete(long id);

        long GetNewId();
    }
}

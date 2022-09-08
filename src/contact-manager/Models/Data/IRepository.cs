namespace contact_manager.Models.Data
{
    internal interface IRepository<T> where T : IObjectIdentifier
    {
        List<T> GetAll();

        T GetById(long id);

        void Save(T person);

        void Delete(long id);

        long GetNewId();
    }
}

namespace contact_manager.Models.Data
{
    internal interface IRepository<T> where T : IObjectIdentifier
    {
        List<T> GetAll();

        T GetById(long id);

        void Save(T entity);

        void Delete(long id);

        long GetNewId();
    }
}

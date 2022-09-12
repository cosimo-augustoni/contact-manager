namespace contact_manager.Models.Data
{
    internal interface IStore<T> where T : IObjectIdentifier
    {
        List<T> GetAll();

        void UpdateOrAdd(T entity);

        void Delete(long id);
    }
}

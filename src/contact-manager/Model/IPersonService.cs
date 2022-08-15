namespace contact_manager.Model
{
    internal interface IPersonService
    {
        void Save(Person person);

        void Delete(Person person);

        void Create(Person person);
    }
}

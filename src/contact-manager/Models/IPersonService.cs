namespace contact_manager.Models
{
    internal interface IPersonService
    {
        void Save(Person person);

        void Delete(Person person);

        void Create(Person person);
    }
}

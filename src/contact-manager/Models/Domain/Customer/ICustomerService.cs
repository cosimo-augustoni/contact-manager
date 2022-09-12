using contact_manager.Models.Data;

namespace contact_manager.Models.Domain
{
    public interface ICustomerService
    {
        List<Customer> GetAll();

        Customer GetById(long customerId);

        void Save(Customer customer);

        void Delete(long customerId);

        long GetNewId();
    }
}

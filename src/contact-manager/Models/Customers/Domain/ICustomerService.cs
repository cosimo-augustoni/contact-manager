using contact_manager.Models.Customers.Data;

namespace contact_manager.Models.Customers.Domain
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

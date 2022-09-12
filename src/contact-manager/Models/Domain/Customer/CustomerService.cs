
using contact_manager.Models.Data;

namespace contact_manager.Models.Domain;

internal class CustomerService : ICustomerService
{
    private readonly IRepository<Customer> customerRepository;

    public CustomerService(IRepository<Customer> customerRepository)
    {
        this.customerRepository = customerRepository;
    }

    public List<Customer> GetAll()
    {
        return this.customerRepository.GetAll();
    }

    public Customer GetById(long customerId)
    {
        return this.customerRepository.GetById(customerId);
    }

    public void Save(Customer customer)
    {
        this.customerRepository.Save(customer);
    }

    public void Delete(long customerId)
    {
        this.customerRepository.Delete(customerId);
    }

    public long GetNewId()
    {
        return this.customerRepository.GetNewId();
    }
}

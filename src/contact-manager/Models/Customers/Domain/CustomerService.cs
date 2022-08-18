using contact_manager.Models.Customers.Data;

namespace contact_manager.Models.Customers.Domain;

internal class CustomerService : ICustomerService
{
    private readonly IPersonRepository<Customer> customerRepository;

    public CustomerService(IPersonRepository<Customer> customerRepository)
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
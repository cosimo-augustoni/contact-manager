using contact_manager.Models.Data;

namespace contact_manager.Models.Domain.Customer;

internal class CustomerService : ICustomerService
{
    private readonly IRepository<Data.Customer.Customer> customerRepository;

    public CustomerService(IRepository<Data.Customer.Customer> customerRepository)
    {
        this.customerRepository = customerRepository;
    }

    public List<Data.Customer.Customer> GetAll()
    {
        return this.customerRepository.GetAll();
    }

    public Data.Customer.Customer GetById(long customerId)
    {
        return this.customerRepository.GetById(customerId);
    }

    public void Save(Data.Customer.Customer customer)
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
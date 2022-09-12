using contact_manager.Models.Data;
using contact_manager.Models.Domain.Search;

namespace contact_manager.Models.Domain.Customer;

internal class CustomerService : ICustomerService
{
    private readonly IRepository<Data.Customer.Customer> _customerRepository;
    private readonly SearchService<Data.Customer.Customer> _searchService;

    public CustomerService(IRepository<Data.Customer.Customer> customerRepository)
    {
        this._customerRepository = customerRepository;
        this._searchService = new SearchService<Data.Customer.Customer>(this._customerRepository);
    }

    public List<Data.Customer.Customer> GetAll()
    {
        return this._customerRepository.GetAll();
    }

    public List<Data.Customer.Customer> GetBySearchTerm(SearchScope searchScope, string searchTerm)
    {
        return this._searchService.SearchBySearchTerm(searchScope, searchTerm);
    }

    public List<SearchScope> GetSearchScopes()
    {
        return this._searchService.GetSearchScopes();
    }

    public Data.Customer.Customer GetById(long customerId)
    {
        return this._customerRepository.GetById(customerId);
    }

    public void Save(Data.Customer.Customer customer)
    {
        this._customerRepository.Save(customer);
    }

    public void Delete(long customerId)
    {
        this._customerRepository.Delete(customerId);
    }

    public long GetNewId()
    {
        return this._customerRepository.GetNewId();
    }
}

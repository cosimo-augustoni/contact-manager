
using contact_manager.Models.Data;
using contact_manager.Models.Domain.Search;

namespace contact_manager.Models.Domain;

internal class CustomerService : ICustomerService
{
    private readonly IRepository<Customer> _customerRepository;
    private readonly SearchService<Customer> _searchService;

    public CustomerService(IRepository<Customer> customerRepository)
    {
        this._customerRepository = customerRepository;
        this._searchService = new SearchService<Customer>(this._customerRepository);
    }

    public List<Customer> GetAll()
    {
        return this._customerRepository.GetAll();
    }

    public List<Customer> GetBySearchTerm(SearchScope searchScope, string searchTerm)
    {
        return this._searchService.SearchBySearchTerm(searchScope, searchTerm);
    }

    public List<SearchScope> GetSearchScopes()
    {
        return this._searchService.GetSearchScopes();
    }

    public Customer GetById(long customerId)
    {
        return this._customerRepository.GetById(customerId);
    }

    public void Save(Customer customer)
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

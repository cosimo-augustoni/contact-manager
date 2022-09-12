using contact_manager.Models.Data;
using contact_manager.Models.Domain.Search;

namespace contact_manager.Models.Domain
{
    public interface ICustomerService
    {
        List<Customer> GetAll();

        Customer GetById(long customerId);

        void Save(Customer customer);

        void Delete(long customerId);

        long GetNewId();
        List<Customer> GetBySearchTerm(SearchScope searchScope, string searchTerm);
        List<SearchScope> GetSearchScopes();
    }
}

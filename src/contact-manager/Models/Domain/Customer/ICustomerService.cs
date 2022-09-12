using contact_manager.Models.Domain.Search;

namespace contact_manager.Models.Domain.Customer
{
    public interface ICustomerService
    {
        List<Data.Customer.Customer> GetAll();

        Data.Customer.Customer GetById(long customerId);

        void Save(Data.Customer.Customer customer);

        void Delete(long customerId);

        long GetNewId();
        List<Data.Customer.Customer> GetBySearchTerm(SearchScope searchScope, string searchTerm);
        List<SearchScope> GetSearchScopes();
    }
}

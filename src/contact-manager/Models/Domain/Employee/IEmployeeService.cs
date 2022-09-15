
using contact_manager.Models.Data;
using contact_manager.Models.Domain.Search;

namespace contact_manager.Models.Domain
{
    public interface IEmployeeService<T> where T: Employee
    {
        List<T> GetAll();

        T GetById(long employeeId);

        void Save(T employee);

        void Delete(long employeeId);

        long GetNewId();
        List<T> GetBySearchTerm(SearchScope searchScope, string searchTerm);
        List<SearchScope> GetSearchScopes();
    }
}

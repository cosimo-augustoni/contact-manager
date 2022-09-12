
using contact_manager.Models.Data;
using contact_manager.Models.Domain.Search;

namespace contact_manager.Models.Domain
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();

        Employee GetById(long employeeId);

        void Save(Employee employee);

        void Delete(long employeeId);

        long GetNewId();
        List<Employee> GetBySearchTerm(SearchScope searchScope, string searchTerm);
        List<SearchScope> GetSearchScopes();
    }
}

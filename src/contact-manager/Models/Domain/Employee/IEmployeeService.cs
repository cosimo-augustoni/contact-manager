using contact_manager.Models.Domain.Search;

namespace contact_manager.Models.Domain.Employee
{
    public interface IEmployeeService
    {
        List<Data.Employee.Employee> GetAll();

        Data.Employee.Employee GetById(long employeeId);

        void Save(Data.Employee.Employee employee);

        void Delete(long employeeId);

        long GetNewId();
        List<Data.Employee.Employee> GetBySearchTerm(SearchScope searchScope, string searchTerm);
        List<SearchScope> GetSearchScopes();
    }
}

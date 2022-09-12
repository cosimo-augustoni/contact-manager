using contact_manager.Models.Data;
using contact_manager.Models.Domain.Search;

namespace contact_manager.Models.Domain.Employee;

internal class EmployeeService : IEmployeeService
{
    private readonly IRepository<Data.Employee.Employee> _employeeRepository;
    private readonly ISearchService<Data.Employee.Employee> _searchService;

    public EmployeeService(IRepository<Data.Employee.Employee> employeeRepository)
    {
        this._employeeRepository = employeeRepository;
        this._searchService = new SearchService<Data.Employee.Employee>(this._employeeRepository);
    }
    public List<Data.Employee.Employee> GetAll()
    {
        return this._employeeRepository.GetAll();
    }

    public List<Data.Employee.Employee> GetBySearchTerm(SearchScope searchScope, string searchTerm)
    {
        return this._searchService.SearchBySearchTerm(searchScope, searchTerm);
    }

    public List<SearchScope> GetSearchScopes()
    {
        return this._searchService.GetSearchScopes();
    }

    public Data.Employee.Employee GetById(long employeeId)
    {
        return this._employeeRepository.GetById(employeeId);
    }

    public void Save(Data.Employee.Employee employee)
    {
        this._employeeRepository.Save(employee);
    }

    public void Delete(long employeeId)
    {
        this._employeeRepository.Delete(employeeId);
    }

    public long GetNewId()
    {
        return this._employeeRepository.GetNewId();
    }
}

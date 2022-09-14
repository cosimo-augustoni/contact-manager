using contact_manager.Models.Data;
using contact_manager.Models.Domain.Search;

namespace contact_manager.Models.Domain;

internal class EmployeeService : IEmployeeService
{
    private readonly IRepository<Employee> _employeeRepository;
    private readonly ISearchService<Employee> _searchService;

    public EmployeeService(IRepository<Employee> employeeRepository)
    {
        this._employeeRepository = employeeRepository;
        this._searchService = new SearchService<Employee>(this._employeeRepository);
    }
    public List<Employee> GetAll()
    {
        return this._employeeRepository.GetAll();
    }

    public List<Employee> GetBySearchTerm(SearchScope searchScope, string searchTerm)
    {
        return this._searchService.SearchBySearchTerm(searchScope, searchTerm);
    }

    public List<SearchScope> GetSearchScopes()
    {
        return this._searchService.GetSearchScopes();
    }

    public Employee GetById(long employeeId)
    {
        return this._employeeRepository.GetById(employeeId);
    }

    public void Save(Employee employee)
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

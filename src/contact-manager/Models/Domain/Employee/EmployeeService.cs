using contact_manager.Models.Data;
using contact_manager.Models.Domain.Search;

namespace contact_manager.Models.Domain;

internal class EmployeeService<T> : IEmployeeService<T> where T : Employee
{
    private readonly IRepository<T> _employeeRepository;
    private readonly ISearchService<T> _searchService;

    public EmployeeService(IRepository<T> employeeRepository)
    {
        this._employeeRepository = employeeRepository;
        this._searchService = new SearchService<T>(this._employeeRepository);
    }
    public List<T> GetAll()
    {
        return this._employeeRepository.GetAll();
    }

    public List<T> GetBySearchTerm(SearchScope searchScope, string searchTerm)
    {
        return this._searchService.SearchBySearchTerm(searchScope, searchTerm);
    }

    public List<SearchScope> GetSearchScopes()
    {
        return this._searchService.GetSearchScopes();
    }

    public T GetById(long employeeId)
    {
        return this._employeeRepository.GetById(employeeId);
    }

    public void Save(T employee)
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

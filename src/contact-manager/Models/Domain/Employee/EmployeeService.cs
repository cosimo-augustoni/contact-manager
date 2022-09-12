using contact_manager.Models.Data;

namespace contact_manager.Models.Domain;

internal class EmployeeService : IEmployeeService
{
    private readonly IRepository<Employee> employeeRepository;

    public EmployeeService(IRepository<Employee> employeeRepository)
    {
        this.employeeRepository = employeeRepository;
    }
    public List<Employee> GetAll()
    {
        return this.employeeRepository.GetAll();
    }

    public Employee GetById(long employeeId)
    {
        return this.employeeRepository.GetById(employeeId);
    }

    public void Save(Employee employee)
    {
        this.employeeRepository.Save(employee);
    }

    public void Delete(long employeeId)
    {
        this.employeeRepository.Delete(employeeId);
    }

    public long GetNewId()
    {
        return this.employeeRepository.GetNewId();
    }
}

using contact_manager.Models.Employees.Data;

namespace contact_manager.Models.Employees.Domain;

internal class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
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
        //TODO Aufsteigende Nummernvergabe
        return 0;
    }
}
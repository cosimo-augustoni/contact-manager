using contact_manager.Models.Data;

namespace contact_manager.Models.Domain.Employee;

internal class EmployeeService : IEmployeeService
{
    private readonly IPersonRepository<Data.Employee.Employee> employeeRepository;

    public EmployeeService(IPersonRepository<Data.Employee.Employee> employeeRepository)
    {
        this.employeeRepository = employeeRepository;
    }
    public List<Data.Employee.Employee> GetAll()
    {
        return this.employeeRepository.GetAll();
    }

    public Data.Employee.Employee GetById(long employeeId)
    {
        return this.employeeRepository.GetById(employeeId);
    }

    public void Save(Data.Employee.Employee employee)
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

using contact_manager.Models.Data;

namespace contact_manager.Models.Domain
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();

        Employee GetById(long employeeId);

        void Save(Employee employee);

        void Delete(long employeeId);

        long GetNewId();
    }
}

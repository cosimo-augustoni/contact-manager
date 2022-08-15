namespace contact_manager.Models.Employees.Data
{
    internal interface IEmployeeRepository
    {
        List<Employee> GetAll();

        Employee GetById(long employeeId);

        void Save(Employee employee);

        void Delete(long employeeId);
    }
}

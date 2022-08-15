using contact_manager.Models.Employees.Data;
using contact_manager.Models.Employees.Domain;
using contact_manager.Views.Employees;

namespace contact_manager.Presenters.Employees
{
    public class EmployeeDetailPresenter
    {
        private readonly IEmployeeDetailDialog dialog;
        private readonly IEmployeeService employeeService;

        private long employeeId;

        public EmployeeDetailPresenter(IEmployeeDetailDialog dialog, IEmployeeService employeeService)
        {
            this.dialog = dialog;
            this.employeeService = employeeService;
            this.dialog.SetPresenter(this);
        }

        public void LoadEmployee(long id)
        {
            this.employeeId = id;
            var employee = this.employeeService.GetById(id);
            this.dialog.FirstName = employee.FirstName;
            //TODO Properties ergänzen
        }

        public void LoadNewEmployee()
        {
            this.employeeId = this.employeeService.GetNewId();
        }

        public void Save()
        {
            var employee = new Employee
            {
                Id = this.employeeId,
                FirstName = this.dialog.FirstName,
                //TODO Properties ergänzen
            };
            this.employeeService.Save(employee);
        }
    }
}

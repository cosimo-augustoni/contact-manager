using contact_manager.Models.Data.Employee;
using contact_manager.Models.Domain.Employee;
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
                //Salutation = this.dialog.Salutation,
                FirstName = this.dialog.FirstName,
                //LastName = this.dialog.LastName,
                //DateOfBirth = this.dialog.DateOfBirth,
                //Sex = this.dialog.Sex,
                //Title = this.dialog.Title,
                //State = this.dialog.State,
                //AHV13 = this.dialog.AHV13,
                //Nationality = this.dialog.Nationality,
                //City = this.dialog.City,
                //ZipCode = this.dialog.ZipCode,
                //StreetName = this.dialog.StreetName,
                //StreetNumber = this.dialog.StreetNumber,
                //EMailAddress = this.dialog.EMailAddress,
                //PhoneNumberPrivate = this.dialog.PhoneNumberPrivate,
                //PhoneNumberMobile = this.dialog.PhoneNumberMobile,
                //PhoneNumberBusiness = this.dialog.PhoneNumberBusiness,
                //FaxNumber = this.dialog.FaxNumber,
                //Department = this.dialog.Department,
                //EntranceDate = this.dialog.EntranceDate,
                //ExitDate = this.dialog.ExitDate,
                //Workload = this.dialog.Workload,
                //Role = this.dialog.Role,
                //CadreLevel = this.dialog.CadreLevel,
            };
            this.employeeService.Save(employee);
        }
    }
}

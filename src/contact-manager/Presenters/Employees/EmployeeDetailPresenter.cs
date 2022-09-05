using contact_manager.Models.Data;
using contact_manager.Models.Data.Employee;
using contact_manager.Models.Domain.Employee;
using contact_manager.Views.Employees;

namespace contact_manager.Presenters.Employees
{
    public class EmployeeDetailPresenter
    {
        private readonly IEmployeeDetailDialog dialog;
        private readonly IEmployeeService employeeService;
        private readonly User user;

        private long employeeId;
        private readonly bool isNewMode;

        public EmployeeDetailPresenter(IEmployeeDetailDialog dialog, IEmployeeService employeeService, User user, bool isNewMode)
        {
            this.dialog = dialog;
            this.employeeService = employeeService;
            this.user = user;
            this.isNewMode = isNewMode;
            this.dialog.SetPresenter(this);
        }

        public bool IsReadOnly
        {
            get { return !this.user.CanWrite; }
        }

        public bool IsNewMode
        {
            get { return this.isNewMode; }
        }

        public void LoadEmployee(long id)
        {
            this.employeeId = id;
            var employee = this.employeeService.GetById(id);

            this.dialog.EmployeeNumber = employee.EmployeeNumber;
            this.dialog.Salutation = employee.Salutation;
            this.dialog.FirstName = employee.FirstName;
            this.dialog.LastName = employee.LastName;
            this.dialog.Title = employee.Title;
            this.dialog.State = employee.State;
            this.dialog.Sex = employee.Sex;
            this.dialog.AHV13 = employee.AHV13;
            this.dialog.DateOfBirth = employee.DateOfBirth;
            this.dialog.Nationality = employee.Nationality;

            this.dialog.StreetName = employee.StreetName;
            this.dialog.StreetNumber = employee.StreetNumber;
            this.dialog.ZipCode = employee.ZipCode;
            this.dialog.City = employee.City;

            this.dialog.EMailAddress = employee.EMailAddress;
            this.dialog.PhoneNumberPrivate = employee.PhoneNumberPrivate;
            this.dialog.PhoneNumberMobile = employee.PhoneNumberMobile;
            this.dialog.PhoneNumberBusiness = employee.PhoneNumberBusiness;
            this.dialog.FaxNumber = employee.FaxNumber;

            this.dialog.Department = employee.Department;
            this.dialog.EntranceDate = employee.EntranceDate;
            this.dialog.ExitDate = employee.ExitDate;
            this.dialog.Employment = employee.Employment;
            this.dialog.Role = employee.Role;
            this.dialog.CadreLevel = employee.CadreLevel;
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
                Salutation = this.dialog.Salutation,
                FirstName = this.dialog.FirstName,
                LastName = this.dialog.LastName,
                DateOfBirth = this.dialog.DateOfBirth,
                Sex = this.dialog.Sex,
                Title = this.dialog.Title,
                State = this.dialog.State,
                AHV13 = this.dialog.AHV13,
                Nationality = this.dialog.Nationality,
                City = this.dialog.City,
                ZipCode = this.dialog.ZipCode,
                StreetName = this.dialog.StreetName,
                StreetNumber = this.dialog.StreetNumber,
                EMailAddress = this.dialog.EMailAddress,
                PhoneNumberPrivate = this.dialog.PhoneNumberPrivate,
                PhoneNumberMobile = this.dialog.PhoneNumberMobile,
                PhoneNumberBusiness = this.dialog.PhoneNumberBusiness,
                FaxNumber = this.dialog.FaxNumber,
                Department = this.dialog.Department,
                EntranceDate = this.dialog.EntranceDate,
                ExitDate = this.dialog.ExitDate,
                Employment = this.dialog.Employment,
                Role = this.dialog.Role,
                CadreLevel = this.dialog.CadreLevel,
            };
            this.employeeService.Save(employee);
        }

        public void ChangeStatus()
        {
            this.dialog.State = this.dialog.State == State.Active
                ? State.Passive
                : State.Active;

            Save();
        }
    }
}

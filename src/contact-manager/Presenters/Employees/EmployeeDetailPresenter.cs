using contact_manager.Models.Data;
using contact_manager.Models.Data.Employee;
using contact_manager.Models.Domain.Authentication;
using contact_manager.Models.Domain.Employee;
using contact_manager.Views.Employees;

namespace contact_manager.Presenters.Employees
{
    public class EmployeeDetailPresenter
    {
        private readonly IEmployeeDetailDialog _dialog;
        private readonly IEmployeeService _employeeService;
        private readonly User _user;

        private long _employeeId;

        public EmployeeDetailPresenter(IEmployeeDetailDialog dialog, IEmployeeService employeeService, User user)
        {
            this._dialog = dialog;
            this._employeeService = employeeService;
            this._user = user;
            this._dialog.SetPresenter(this);
        }

        public bool IsReadOnly
        {
            get { return !_user.CanWrite; }
        }

        public void LoadEmployee(long id)
        {
            this._employeeId = id;
            var employee = this._employeeService.GetById(id);

            this._dialog.EmployeeNumber = employee.EmployeeNumber;
            this._dialog.Salutation = employee.Salutation;
            this._dialog.FirstName = employee.FirstName;
            this._dialog.LastName = employee.LastName;
            this._dialog.Title = employee.Title;
            this._dialog.State = employee.State;
            this._dialog.Sex = employee.Sex;
            this._dialog.AHV13 = employee.AHV13;
            this._dialog.DateOfBirth = employee.DateOfBirth;
            this._dialog.Nationality = employee.Nationality;

            this._dialog.StreetName = employee.StreetName;
            this._dialog.StreetNumber = employee.StreetNumber;
            this._dialog.ZipCode = employee.ZipCode;
            this._dialog.City = employee.City;

            this._dialog.EMailAddress = employee.EMailAddress;
            this._dialog.PhoneNumberPrivate = employee.PhoneNumberPrivate;
            this._dialog.PhoneNumberMobile = employee.PhoneNumberMobile;
            this._dialog.PhoneNumberBusiness = employee.PhoneNumberBusiness;
            this._dialog.FaxNumber = employee.FaxNumber;

            this._dialog.Department = employee.Department;
            this._dialog.EntranceDate = employee.EntranceDate;
            this._dialog.ExitDate = employee.ExitDate;
            this._dialog.Employment = employee.Employment;
            this._dialog.Role = employee.Role;
            this._dialog.CadreLevel = employee.CadreLevel;
        }

        public void LoadNewEmployee()
        {
            this._employeeId = this._employeeService.GetNewId();
        }

        public void Save()
        {
            var employee = new Employee
            {
                Id = this._employeeId,
                Salutation = this._dialog.Salutation,
                FirstName = this._dialog.FirstName,
                LastName = this._dialog.LastName,
                DateOfBirth = this._dialog.DateOfBirth,
                Sex = this._dialog.Sex,
                Title = this._dialog.Title,
                State = this._dialog.State,
                AHV13 = this._dialog.AHV13,
                Nationality = this._dialog.Nationality,
                City = this._dialog.City,
                ZipCode = this._dialog.ZipCode,
                StreetName = this._dialog.StreetName,
                StreetNumber = this._dialog.StreetNumber,
                EMailAddress = this._dialog.EMailAddress,
                PhoneNumberPrivate = this._dialog.PhoneNumberPrivate,
                PhoneNumberMobile = this._dialog.PhoneNumberMobile,
                PhoneNumberBusiness = this._dialog.PhoneNumberBusiness,
                FaxNumber = this._dialog.FaxNumber,
                Department = this._dialog.Department,
                EntranceDate = this._dialog.EntranceDate,
                ExitDate = this._dialog.ExitDate,
                Employment = this._dialog.Employment,
                Role = this._dialog.Role,
                CadreLevel = this._dialog.CadreLevel,
            };
            this._employeeService.Save(employee);
        }
    }
}

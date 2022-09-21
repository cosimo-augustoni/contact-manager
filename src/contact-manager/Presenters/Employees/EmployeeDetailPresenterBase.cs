using contact_manager.Models.Data;
using contact_manager.Models.Data.History;
using contact_manager.Models.Domain;
using contact_manager.Models.Domain.Authentication;
using contact_manager.Models.Domain.History;
using contact_manager.Presenters.History;
using contact_manager.Views;
using contact_manager.Views.Employees;

namespace contact_manager.Presenters.Employees;

public abstract class EmployeeDetailPresenterBase<TEmployee, TDialog> : IPresenter 
    where TEmployee : Employee, new() 
    where TDialog : class, IEmployeeDetailDialog
{
    protected readonly TDialog Dialog;
    protected readonly IEmployeeService<TEmployee> EmployeeService;
    protected readonly IHistoryService HistoryService;
    private readonly IUserService _userService;
    protected readonly User User;

    private long _employeeId;
    private TEmployee? _savedEmployee;
    protected abstract EntityType PersonType { get; }

    protected EmployeeDetailPresenterBase(TDialog dialog, IEmployeeService<TEmployee> employeeService, IHistoryService historyService, IUserService userService, User user, bool isNewMode)
    {
        this.Dialog = dialog;
        this.EmployeeService = employeeService;
        this.User = user;
        this.IsNewMode = isNewMode;
        this.HistoryService = historyService;
        this._userService = userService;
    }

    public abstract void Init();

    public bool IsReadOnly => !this.User.CanWrite;

    public bool IsNewMode { get; }

    public void LoadEmployee(long id)
    {
        this._employeeId = id;
        var employee = this.EmployeeService.GetById(id);
        this.WriteToDialog(employee);
        this._savedEmployee = this.ReadFromDialog();
    }

    protected virtual void WriteToDialog(TEmployee employee)
    {
        this.Dialog.EmployeeNumber = employee.EmployeeNumber;
        this.Dialog.Salutation = employee.Salutation;
        this.Dialog.FirstName = employee.FirstName;
        this.Dialog.LastName = employee.LastName;
        this.Dialog.Title = employee.Title;
        this.Dialog.State = employee.State;
        this.Dialog.Sex = employee.Sex;
        this.Dialog.AHV13 = employee.AHV13;
        this.Dialog.DateOfBirth = employee.DateOfBirth;
        this.Dialog.Nationality = employee.Nationality;

        this.Dialog.StreetName = employee.StreetName;
        this.Dialog.StreetNumber = employee.StreetNumber;
        this.Dialog.ZipCode = employee.ZipCode;
        this.Dialog.City = employee.City;

        this.Dialog.EMailAddress = employee.EMailAddress;
        this.Dialog.PhoneNumberPrivate = employee.PhoneNumberPrivate;
        this.Dialog.PhoneNumberMobile = employee.PhoneNumberMobile;
        this.Dialog.PhoneNumberBusiness = employee.PhoneNumberBusiness;
        this.Dialog.FaxNumber = employee.FaxNumber;

        this.Dialog.Department = employee.Department;
        this.Dialog.EntranceDate = employee.EntranceDate;
        this.Dialog.ExitDate = employee.ExitDate;
        this.Dialog.Employment = employee.Employment;
        this.Dialog.Role = employee.Role;
        this.Dialog.CadreLevel = employee.CadreLevel;
    }

    public void LoadNewEmployee()
    {
        this._employeeId = this.EmployeeService.GetNewId();
        this.Dialog.DateOfBirth = null;
        this.Dialog.ExitDate = null;
    }

    public void Save()
    {
        var employee = this.ReadFromDialog();
        this.EmployeeService.Save(employee);
        this._savedEmployee = employee;
    }

    protected virtual TEmployee ReadFromDialog()
    {
        var employee = new TEmployee
        {
            Id = this._employeeId,
            Salutation = this.Dialog.Salutation,
            FirstName = this.Dialog.FirstName,
            LastName = this.Dialog.LastName,
            DateOfBirth = this.Dialog.DateOfBirth,
            Sex = this.Dialog.Sex,
            Title = this.Dialog.Title,
            State = this.Dialog.State,
            AHV13 = this.Dialog.AHV13,
            Nationality = this.Dialog.Nationality,
            City = this.Dialog.City,
            ZipCode = this.Dialog.ZipCode,
            StreetName = this.Dialog.StreetName,
            StreetNumber = this.Dialog.StreetNumber,
            EMailAddress = this.Dialog.EMailAddress,
            PhoneNumberPrivate = this.Dialog.PhoneNumberPrivate,
            PhoneNumberMobile = this.Dialog.PhoneNumberMobile,
            PhoneNumberBusiness = this.Dialog.PhoneNumberBusiness,
            FaxNumber = this.Dialog.FaxNumber,
            Department = this.Dialog.Department,
            EntranceDate = this.Dialog.EntranceDate,
            ExitDate = this.Dialog.ExitDate,
            Employment = this.Dialog.Employment,
            Role = this.Dialog.Role,
            CadreLevel = this.Dialog.CadreLevel,
        };
        return employee;
    }

    public void ChangeStatus()
    {
        this.Dialog.State = this.Dialog.State == State.Active
            ? State.Passive
            : State.Active;

        this.Save();
    }

    public void OpenHistoryDialog()
    {
        var historyDialog = new HistoryDialog();
        var historyPresenter = new HistoryPresenter(historyDialog, this.HistoryService, this._userService);
        historyPresenter.LoadPerson(this._employeeId, this.PersonType);
        historyDialog.ShowDialog();
    }

    public bool HasUnsavedChanges()
    {
        return this._savedEmployee != null && !this._savedEmployee.IsStringEqual(this.ReadFromDialog());
    }
}

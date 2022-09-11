using contact_manager.Models.Data.Customer;
using contact_manager.Models.Domain.Authentication;
using contact_manager.Models.Domain.Customer;
using contact_manager.Views.Customers;
using contact_manager.Views.Customers.CustomerNotes;

namespace contact_manager.Presenters.Customers;

public class CustomerDetailPresenter : IPresenter
{
    private readonly ICustomerDetailDialog _dialog;
    private readonly ICustomerService _customerService;
    private readonly ICustomerNoteService _customerNotesService;
    private readonly User _user;
    private long _customerId;

    public CustomerDetailPresenter(ICustomerDetailDialog dialog, ICustomerService customerService,
        ICustomerNoteService customerNotesService, User user, bool isNewMode)
    {
        this._dialog = dialog;
        this._user = user;
        this.IsNewMode = isNewMode;
        this._customerService = customerService;
        this._customerNotesService = customerNotesService;
    }

    public void Init()
    {
        this._dialog.SetPresenter(this);
    }

    public bool IsReadOnly
    {
        get { return !this._user.CanWrite; }
    }

    public bool IsNewMode { get; }

    public void LoadCustomer(long id)
    {
        this._customerId = id;
        var customer = this._customerService.GetById(id);
        this._dialog.FirstName = customer.FirstName;
        this._dialog.CustomerNumber = customer.CustomerNumber;
        this._dialog.Salutation = customer.Salutation;
        this._dialog.FirstName = customer.FirstName;
        this._dialog.LastName = customer.LastName;
        this._dialog.Title = customer.Title;
        this._dialog.State = customer.State;
        this._dialog.Sex = customer.Sex;
        this._dialog.AHV13 = customer.AHV13;
        this._dialog.DateOfBirth = customer.DateOfBirth;
        this._dialog.Nationality = customer.Nationality;

        this._dialog.StreetName = customer.StreetName;
        this._dialog.StreetNumber = customer.StreetNumber;
        this._dialog.ZipCode = customer.ZipCode;
        this._dialog.City = customer.City;

        this._dialog.EMailAddress = customer.EMailAddress;
        this._dialog.PhoneNumberPrivate = customer.PhoneNumberPrivate;
        this._dialog.PhoneNumberMobile = customer.PhoneNumberMobile;
        this._dialog.PhoneNumberBusiness = customer.PhoneNumberBusiness;
        this._dialog.FaxNumber = customer.FaxNumber;

        this._dialog.CustomerType = customer.CustomerType;
        this._dialog.CompanyName = customer.CompanyName;
        this._dialog.CompanyContact = customer.CompanyContact;
        this._dialog.CompanyAddress = customer.CompanyAddress;
    }

    public void LoadNewCustomer()
    {
        this._customerId = this._customerService.GetNewId();
    }

    public void ChangeStatus()
    {
        this._dialog.State = this._dialog.State == Models.Data.State.Active
            ? Models.Data.State.Passive
            : Models.Data.State.Active;

        Save();
    }

    public void Save()
    {
        var customer = new Customer
        {
            Id = this._customerId,
            // ToDo: customerNumber auch rein nehmen?
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
            CompanyAddress = this._dialog.CompanyAddress,
            CompanyContact = this._dialog.CompanyContact,
            CompanyName = this._dialog.CompanyName,
            CustomerType = this._dialog.CustomerType
        };
        this._customerService.Save(customer);
    }

    public void OpenCustomerNotesDialog(string customerDisplayText)
    {
        var dialog = new CustomerNotesDialog();
        var presenter = new CustomerNotesPresenter(dialog, this._customerNotesService, this._customerId, this._user);
        presenter.Init();
        presenter.SetTitle(customerDisplayText);
        dialog.ShowDialog();
    }
}

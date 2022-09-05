using contact_manager.Models.Data;
using contact_manager.Models.Data.Customer;
using contact_manager.Models.Domain.Customer;
using contact_manager.Views.Customers;

namespace contact_manager.Presenters.Customers;

public class CustomerDetailPresenter
{
    private readonly ICustomerDetailDialog dialog;
    private readonly ICustomerService customerService;
    private readonly User user;
    private long customerId;
    private readonly bool isNewMode;

    public CustomerDetailPresenter(ICustomerDetailDialog dialog, ICustomerService customerService, User user, bool isNewMode)
    {
        this.dialog = dialog;
        this.user = user;
        this.isNewMode = isNewMode;
        this.dialog.SetPresenter(this);
        this.customerService = customerService;
    }

    public bool IsReadOnly
    {
        get { return !this.user.CanWrite; }
    }

    public bool IsNewMode
    {
        get { return this.isNewMode; }
    }

    public void LoadCustomer(long id)
    {
        this.customerId = id;
        var customer = this.customerService.GetById(id);
        this.dialog.FirstName = customer.FirstName;
        this.dialog.CustomerNumber = customer.CustomerNumber;
        this.dialog.Salutation = customer.Salutation;
        this.dialog.FirstName = customer.FirstName;
        this.dialog.LastName = customer.LastName;
        this.dialog.Title = customer.Title;
        this.dialog.State = customer.State;
        this.dialog.Sex = customer.Sex;
        this.dialog.AHV13 = customer.AHV13;
        this.dialog.DateOfBirth = customer.DateOfBirth;
        this.dialog.Nationality = customer.Nationality;

        this.dialog.StreetName = customer.StreetName;
        this.dialog.StreetNumber = customer.StreetNumber;
        this.dialog.ZipCode = customer.ZipCode;
        this.dialog.City = customer.City;

        this.dialog.EMailAddress = customer.EMailAddress;
        this.dialog.PhoneNumberPrivate = customer.PhoneNumberPrivate;
        this.dialog.PhoneNumberMobile = customer.PhoneNumberMobile;
        this.dialog.PhoneNumberBusiness = customer.PhoneNumberBusiness;
        this.dialog.FaxNumber = customer.FaxNumber;

        this.dialog.CustomerType = customer.CustomerType;
        this.dialog.CompanyName = customer.CompanyName;
        this.dialog.CompanyContact = customer.CompanyContact;
        this.dialog.CompanyAddress = customer.CompanyAddress;
    }

    public void LoadNewCustomer()
    {
        this.customerId = this.customerService.GetNewId();
    }

    public void ChangeStatus()
    {
        this.dialog.State = this.dialog.State == State.Active
            ? State.Passive
            : State.Active;

        Save();
    }

    public void Save()
    {
        var customer = new Customer
        {
            Id = this.customerId,
            // ToDo: customerNumber auch rein nehmen?
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
            CompanyAddress = this.dialog.CompanyAddress,
            CompanyContact = this.dialog.CompanyContact,
            CompanyName = this.dialog.CompanyName,
            CustomerType = this.dialog.CustomerType
        };
        this.customerService.Save(customer);
    }
}

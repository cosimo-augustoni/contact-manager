using contact_manager.Models.Data.Customer;
using contact_manager.Models.Domain.Customer;
using contact_manager.Views.Customers;

namespace contact_manager.Presenters.Customers;

public class CustomerDetailPresenter
{
    private readonly ICustomerDetailDialog dialog;
    private readonly ICustomerService customerService;
    private long customerId;

    public CustomerDetailPresenter(ICustomerDetailDialog dialog, ICustomerService customerService)
    {
        this.dialog = dialog;
        this.dialog.SetPresenter(this);

        this.customerService = customerService;
    }

    public void LoadCustomer(long id)
    {
        this.customerId = id;
        var employee = this.customerService.GetById(id);
        this.dialog.FirstName = employee.FirstName;
        this.dialog.CustomerNumber = employee.CustomerNumber;
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

        //this.dialog.CustomerType = employee.CustomerType;
        //this.dialog.CompanyName = employee.CompanyName;
    }

    public void LoadNewCustomer()
    {
        this.customerId = this.customerService.GetNewId();
    }

    public void Save()
    {
        var customer = new Customer
        {
            Id = this.customerId,
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
            //CompanyName = this.dialog.CompanyName,
            //CustomerType = this.dialog.CustomerType,
        };
        this.customerService.Save(customer);
    }
}

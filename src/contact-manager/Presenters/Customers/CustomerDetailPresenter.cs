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
        //TODO Properties ergänzen
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
            //CompanyName = this.dialog.CompanyName,
            //CustomerType = this.dialog.CustomerType,
        };
        this.customerService.Save(customer);
    }
}
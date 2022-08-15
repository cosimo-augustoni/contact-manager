using contact_manager.Models.Customers.Data;
using contact_manager.Models.Customers.Domain;
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
            FirstName = this.dialog.FirstName,
            //TODO Properties ergänzen
        };
        this.customerService.Save(customer);
    }
}
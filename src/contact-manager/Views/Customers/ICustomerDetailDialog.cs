using contact_manager.Presenters.Customers;

namespace contact_manager.Views.Customers;

public interface ICustomerDetailDialog
{
    void SetPresenter(CustomerDetailPresenter customerDetailPresenter);
    string? FirstName { get; set; }
}
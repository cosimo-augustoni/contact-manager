using contact_manager.Models.Data;
using contact_manager.Models.Data.Customer;
using contact_manager.Presenters.Customers;

namespace contact_manager.Views.Customers;

public interface ICustomerDetailDialog
{
    void SetPresenter(CustomerDetailPresenter customerDetailPresenter);
    string? FirstName { get; set; }
    string? CustomerNumber { get; set; }
    Salutation Salutation { get; set; }
    string? LastName { get; set; }
    string? Title { get; set; }
    State State { get; set; }
    Sex Sex { get; set; }
    string? AHV13 { get; set; }
    DateTime? DateOfBirth { get; set; }
    string? Nationality { get; set; }
    string? StreetName { get; set; }
    string? StreetNumber { get; set; }
    string? ZipCode { get; set; }
    string? City { get; set; }
    string? EMailAddress { get; set; }
    string? PhoneNumberPrivate { get; set; }
    string? PhoneNumberBusiness { get; set; }
    string? FaxNumber { get; set; }
    string? PhoneNumberMobile { get; set; }
    CustomerType CustomerType { get; set; }
    string? CompanyName { get; set; }
    string? CompanyContact { get; set; }
    string? CompanyAddress { get; set; }
}

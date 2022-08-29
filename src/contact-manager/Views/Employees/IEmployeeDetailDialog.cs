using contact_manager.Models.Data;
using contact_manager.Presenters.Employees;

namespace contact_manager.Views.Employees;

public interface IEmployeeDetailDialog
{
    void SetPresenter(EmployeeDetailPresenter employeeDetailPresenter);
    string? FirstName { get; set; }
    string? EmployeeNumber { get; set; }
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
    string? PhoneNumberMobile { get; set; }
    string? PhoneNumberBusiness { get; set; }
    string? FaxNumber { get; set; }
    string? Department { get; set; }
    DateTime EntranceDate { get; set; }
    DateTime? ExitDate { get; set; }
    int Employment { get; set; }
    string? Role { get; set; }
    int CadreLevel { get; set; }
}

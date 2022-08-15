using contact_manager.Presenters.Employees;

namespace contact_manager.Views.Employees;

public interface IEmployeeDetailDialog
{
    void SetPresenter(EmployeeDetailPresenter employeeDetailPresenter);
    string? FirstName { get; set; }
}
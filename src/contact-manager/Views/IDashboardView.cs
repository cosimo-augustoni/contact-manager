using contact_manager.Models.Customers.Data;
using contact_manager.Models.Employees.Data;
using contact_manager.Presenters;

namespace contact_manager.Views;

public interface IDashboardView
{
    void SetPresenter(DashboardPresenter dashboardPresenter);

    void SetEmployeeList(List<Employee> employees);

    void SetCustomerList(List<Customer> customers);
}
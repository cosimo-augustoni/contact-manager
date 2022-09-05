using contact_manager.Models.Data.Customer;
using contact_manager.Models.Data.Employee;
using contact_manager.Presenters;

namespace contact_manager.Views;

public interface IOverviewView
{
    void SetPresenter(OverviewPresenter overviewPresenter);

    void SetEmployeeList(List<Employee> employees);

    void SetCustomerList(List<Customer> customers);
}

using contact_manager.Models.Domain.Search;
using contact_manager.Models.Data;
using contact_manager.Presenters;

namespace contact_manager.Views;

public interface IOverviewView
{
    void SetPresenter(OverviewPresenter overviewPresenter);

    void SetEmployeeList(List<Employee> employees);

    void SetCustomerList(List<Customer> customers);
    string SearchTermCustomer { get; set; }
    SearchScope SearchScopeCustomer { get; set; }
    string SearchTermEmployee { get; set; }
    SearchScope SearchScopeEmployee { get; set; }
    void SetSearchScopeCustomerSource(List<SearchScope> scopes);
    void SetSearchScopeEmployeeSource(List<SearchScope> scopes);

    void SetDashboardData(DashboardData dashboardData);
}

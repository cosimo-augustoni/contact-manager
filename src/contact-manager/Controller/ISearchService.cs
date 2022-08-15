using contact_manager.Model.Customers;
using contact_manager.Model.Employees;

namespace contact_manager.Controller
{
    internal interface ISearchService
    {
        List<Employee> SearchEmployees(string searchTerm);

        List<Customer> SearchCustomers(string searchTerm);
    }
}

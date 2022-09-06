using contact_manager.Models.Data;
using contact_manager.Models.Data.Customer;
using contact_manager.Models.Data.Employee;
using contact_manager.Models.Data.History;
using contact_manager.Models.Domain.Authentication;
using contact_manager.Models.Domain.Customer;
using contact_manager.Models.Domain.Employee;
using contact_manager.Models.Domain.History;
using contact_manager.Presenters;
using contact_manager.Presenters.Authentication;
using contact_manager.Views.Authentication;

namespace contact_manager.Views
{
    internal class DefaultFormFactory : IFormFactory
    {
        public LoginView CreateLoginDialog()
        {
            var loginView = new LoginView();
            var userService = new UserService();
            // ToDo: keine verwendung
            var loginPresenter = new LoginPresenter(loginView, userService, this);

            return loginView;
        }

        public OverviewView CreateOverview(User user)
        {

            var overviewView = new OverviewView();
            var historyService = new HistoryService(new HistoryStore());
            var customerRepository = new PersonRepository<Customer>(new FilePersonStore<Customer>(historyService));
            var customerService = new CustomerService(customerRepository);
            var employeeRepository = new PersonRepository<Employee>(new FilePersonStore<Employee>(historyService));
            var employeeService = new EmployeeService(employeeRepository);
            var overviewPresenter = new OverviewPresenter(overviewView, customerService, employeeService, user, historyService);
            overviewPresenter.LoadAllCustomers();

            return overviewView;
        }
    }
}

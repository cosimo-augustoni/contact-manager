using contact_manager.Models.Data.Customer;
using contact_manager.Models.Data.Employee;
using contact_manager.Models.Domain.Authentication;
using contact_manager.Models.Domain.Customer;
using contact_manager.Models.Domain.Employee;
using contact_manager.Presenters;
using contact_manager.Presenters.Authentication;
using contact_manager.Views.Authentication;
using Data = contact_manager.Models.Data;

namespace contact_manager.Views
{
    internal class DefaultFormFactory : IFormFactory
    {
        public LoginView CreateLoginDialog()
        {
            var loginView = new LoginView();
            var userService = new UserService();
            var loginPresenter = new LoginPresenter(loginView, userService, this);

            return loginView;
        }

        public OverviewView CreateOverview(User user)
        {
            var overviewView = new OverviewView();
            var customerRepository = new Data.PersonRepository<Customer>(new Data.FilePersonStore<Customer>());
            var customerService = new CustomerService(customerRepository);
            var employeeRepository = new Data.PersonRepository<Employee>(new Data.FilePersonStore<Employee>());
            var employeeService = new EmployeeService(employeeRepository);
            var overviewPresenter = new OverviewPresenter(overviewView, customerService, employeeService, user);
            overviewPresenter.LoadAllCustomers();

            return overviewView;
        }
    }
}

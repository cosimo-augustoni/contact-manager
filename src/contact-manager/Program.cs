using System.Diagnostics;
using contact_manager.Models.Data;
using contact_manager.Models.Data.Customer;
using contact_manager.Models.Data.Employee;
using contact_manager.Models.Domain.Customer;
using contact_manager.Models.Domain.Employee;
using contact_manager.Presenters;
using contact_manager.Views;

namespace contact_manager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // todo: noch anpassen
            IUserstore userStore = new IUserstore();
            if (Debugger.IsAttached)
            {
                var user = userStore.GetUser("admin", "1234");
                var dashboardView = new DashboardView();
                var customerRepository = new PersonRepository<Customer>(new FilePersonStore<Customer>());
                var customerService = new CustomerService(customerRepository);
                var employeeRepository = new PersonRepository<Employee>(new FilePersonStore<Employee>());
                var employeeService = new EmployeeService(employeeRepository);
                var dashboardPresenter = new DashboardPresenter(dashboardView, customerService, employeeService, user);
                dashboardPresenter.LoadAllCustomers();
                Application.Run(dashboardView);
            }
            else
            {
                var loginForm = new LoginForm(userStore);
                Application.Run(loginForm);
            }
        }
    }
}

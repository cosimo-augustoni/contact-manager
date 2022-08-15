using contact_manager.Models.Customers.Domain;
using contact_manager.Models.Employees.Domain;
using contact_manager.Presenters;
using contact_manager.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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

            var dashboardView = new DashboardView();
            //TODO Repository mitgeben sobald implementiert
            var customerService = new CustomerService(null!);
            //TODO Repository mitgeben sobald implementiert
            var employeeService = new EmployeeService(null!);
            var dashboardPresenter = new DashboardPresenter(dashboardView, customerService, employeeService);

            Application.Run(dashboardView);
        }
    }
}
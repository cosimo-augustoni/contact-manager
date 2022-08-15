using contact_manager.Models.Customers.Domain;
using contact_manager.Models.Employees.Domain;
using contact_manager.Presenters.Customers;
using contact_manager.Presenters.Employees;
using contact_manager.Views;
using contact_manager.Views.Customers;
using contact_manager.Views.Employees;

namespace contact_manager.Presenters
{
    public class DashboardPresenter
    {
        private readonly IDashboardView dashboardView;
        private readonly ICustomerService customerService;
        private readonly IEmployeeService employeeService;

        public DashboardPresenter(IDashboardView dashboardView, ICustomerService customerService, IEmployeeService employeeService)
        {
            this.dashboardView = dashboardView;
            this.dashboardView.SetPresenter(this);

            this.customerService = customerService;
            this.employeeService = employeeService;
        }

        public void ShowAllEmployees()
        {
            var employees = this.employeeService.GetAll();
            this.dashboardView.SetEmployeeList(employees);
        }

        public void OpenCreateNewEmployeeDialog()
        {
            var dialog = new EmployeeDetailDialog();
            var dialogPresenter = new EmployeeDetailPresenter(dialog, this.employeeService);
            dialogPresenter.LoadNewEmployee();
            dialog.ShowDialog();
        }

        public void OpenEditEmployeeDialog(long employeeId)
        {
            var dialog = new EmployeeDetailDialog();
            var dialogPresenter = new EmployeeDetailPresenter(dialog, this.employeeService);
            dialogPresenter.LoadEmployee(employeeId);
            dialog.ShowDialog();
        }

        public void DeleteEmployee(long employeeId)
        {
            this.employeeService.Delete(employeeId);
            //TODO Evtl. Performance Problem alles wieder zu laden. Evtl eine art caching in der View
            this.ShowAllEmployees();
        }

        public void ShowAllCustomers()
        {
            var customers = this.customerService.GetAll();
            this.dashboardView.SetCustomerList(customers);
        }

        public void OpenCreateNewCustomerDialog()
        {
            var dialog = new CustomerDetailDialog();
            var dialogPresenter = new CustomerDetailPresenter(dialog, this.customerService);
            dialogPresenter.LoadNewCustomer();
            dialog.ShowDialog();
        }

        public void OpenEditCustomerDialog(long customerId)
        {
            var dialog = new CustomerDetailDialog();
            var dialogPresenter = new CustomerDetailPresenter(dialog, this.customerService);
            dialogPresenter.LoadCustomer(customerId);
            dialog.ShowDialog();
        }

        public void DeleteCustomer(long customerId)
        {
            this.customerService.Delete(customerId);
            //TODO Evtl. Performance Problem alles wieder zu laden. Evtl eine art caching in der View
            this.ShowAllCustomers();
        }
    }
}

using contact_manager.Models.Data;
using contact_manager.Models.Domain.Customer;
using contact_manager.Models.Domain.Employee;
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
        private readonly User user;

        public DashboardPresenter(IDashboardView dashboardView, ICustomerService customerService, IEmployeeService employeeService, User user)
        {
            this.dashboardView = dashboardView;
            this.user = user;
            this.dashboardView.SetPresenter(this);

            this.customerService = customerService;
            this.employeeService = employeeService;
        }

        public bool IsReadOnly
        {
            get { return !this.user.CanWrite; }
        }

        public void LoadAllEmployees()
        {
            var employees = this.employeeService.GetAll();
            this.dashboardView.SetEmployeeList(employees);
        }

        public void OpenCreateNewEmployeeDialog()
        {
            var dialog = new EmployeeDetailDialog();
            var dialogPresenter = new EmployeeDetailPresenter(dialog, this.employeeService, this.user, isNewMode: true);
            dialogPresenter.LoadNewEmployee();
            dialog.InitializeMode();
            dialog.Closed += (_, _) => this.LoadAllEmployees();
            dialog.ShowDialog();
        }

        public void OpenEditEmployeeDialog(long employeeId)
        {
            var dialog = new EmployeeDetailDialog();
            var dialogPresenter = new EmployeeDetailPresenter(dialog, this.employeeService, this.user, isNewMode: false);
            dialogPresenter.LoadEmployee(employeeId);
            dialog.InitializeMode();
            dialog.Closed += (_, _) => this.LoadAllEmployees();
            dialog.ShowDialog();
        }

        public void DeleteEmployee(long employeeId)
        {
            this.employeeService.Delete(employeeId);
            //TODO Evtl. Performance Problem alles wieder zu laden. Evtl eine art caching in der View
            this.LoadAllEmployees();
        }

        public void LoadAllCustomers()
        {
            var customers = this.customerService.GetAll();
            this.dashboardView.SetCustomerList(customers);
        }

        public void OpenCreateNewCustomerDialog()
        {
            var dialog = new CustomerDetailDialog();
            var dialogPresenter = new CustomerDetailPresenter(dialog, this.customerService, this.user, isNewMode: true);
            dialogPresenter.LoadNewCustomer();
            dialog.InitializeMode();
            dialog.Closed += (_, _) => this.LoadAllCustomers();
            dialog.ShowDialog();
        }

        public void OpenEditCustomerDialog(long customerId)
        {
            var dialog = new CustomerDetailDialog();
            var dialogPresenter = new CustomerDetailPresenter(dialog, this.customerService, this.user, isNewMode: false);
            dialogPresenter.LoadCustomer(customerId);
            dialog.InitializeMode();
            // ToDo: nach dem laden der daten noch die Controls aktualisieren
            dialog.Closed += (_, _) => this.LoadAllCustomers();
            dialog.ShowDialog();
        }

        public void DeleteCustomer(long customerId)
        {
            this.customerService.Delete(customerId);
            //TODO Evtl. Performance Problem alles wieder zu laden. Evtl eine art caching in der View
            this.LoadAllCustomers();
        }

        public void SelectedTabChanged(int selectedTabPage)
        {
            if(selectedTabPage == 0)
                this.LoadAllCustomers();
            else if(selectedTabPage == 1)
                this.LoadAllEmployees();
        }
    }
}

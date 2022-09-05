using contact_manager.Models.Data;
using contact_manager.Models.Domain.Authentication;
using contact_manager.Models.Domain.Customer;
using contact_manager.Models.Domain.Employee;
using contact_manager.Presenters.Customers;
using contact_manager.Presenters.Employees;
using contact_manager.Views;
using contact_manager.Views.Customers;
using contact_manager.Views.Employees;

namespace contact_manager.Presenters
{
    public class OverviewPresenter
    {
        private readonly IOverviewView overviewView;
        private readonly ICustomerService customerService;
        private readonly IEmployeeService employeeService;
        private readonly User user;

        public OverviewPresenter(IOverviewView overviewView, ICustomerService customerService,
            IEmployeeService employeeService, User user)
        {
            this.overviewView = overviewView;
            this.overviewView.SetPresenter(this);

            this.customerService = customerService;
            this.employeeService = employeeService;
            this.user = user;
        }

        public void LoadAllEmployees()
        {
            var employees = this.employeeService.GetAll();
            this.overviewView.SetEmployeeList(employees);
        }

        public void OpenCreateNewEmployeeDialog()
        {
            var dialog = new EmployeeDetailDialog();
            var dialogPresenter = new EmployeeDetailPresenter(dialog, this.employeeService, this.user);
            dialogPresenter.LoadNewEmployee();
            dialog.Closed += (_, _) => this.LoadAllEmployees();
            dialog.ShowDialog();
        }

        public void OpenEditEmployeeDialog(long employeeId)
        {
            var dialog = new EmployeeDetailDialog();
            var dialogPresenter = new EmployeeDetailPresenter(dialog, this.employeeService, this.user);
            dialogPresenter.LoadEmployee(employeeId);
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
            this.overviewView.SetCustomerList(customers);
        }

        public void OpenCreateNewCustomerDialog()
        {
            var dialog = new CustomerDetailDialog();
            var dialogPresenter = new CustomerDetailPresenter(dialog, this.customerService, this.user);
            dialogPresenter.LoadNewCustomer();
            dialog.Closed += (_, _) => this.LoadAllCustomers();
            dialog.ShowDialog();
        }

        public void OpenEditCustomerDialog(long customerId)
        {
            var dialog = new CustomerDetailDialog();
            var dialogPresenter = new CustomerDetailPresenter(dialog, this.customerService, this.user);
            dialogPresenter.LoadCustomer(customerId);
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

using contact_manager.Models.Domain.Authentication;
using contact_manager.Models.Domain.Customer;
using contact_manager.Models.Domain.Employee;
using contact_manager.Models.Domain.History;
using contact_manager.Presenters.Customers;
using contact_manager.Presenters.Employees;
using contact_manager.Views;
using contact_manager.Views.Customers;
using contact_manager.Views.Employees;

namespace contact_manager.Presenters
{
    public class OverviewPresenter
    {
        private readonly IOverviewView _overviewView;
        private readonly ICustomerService _customerService;
        private readonly IEmployeeService _employeeService;
        private readonly IHistoryService _historyService;
        private readonly User _user;

        public OverviewPresenter(IOverviewView overviewView, ICustomerService customerService,
            IEmployeeService employeeService, User user, IHistoryService historyService)
        {
            this._overviewView = overviewView;
            this._user = user;
            this._overviewView.SetPresenter(this);

            this._customerService = customerService;
            this._employeeService = employeeService;
            this._historyService = historyService;
        }

        public bool IsReadOnly
        {
            get { return !this._user.CanWrite; }
        }

        public void LoadAllEmployees()
        {
            var employees = this._employeeService.GetAll();
            this._overviewView.SetEmployeeList(employees);
        }

        public void OpenCreateNewEmployeeDialog()
        {
            var dialog = new EmployeeDetailDialog();
            var dialogPresenter = new EmployeeDetailPresenter(dialog, this._employeeService, this._user, isNewMode: true, _historyService);
            dialogPresenter.LoadNewEmployee();
            dialog.InitializeMode();
            dialog.Closed += (_, _) => this.LoadAllEmployees();
            dialog.ShowDialog();
        }

        public void OpenEditEmployeeDialog(long employeeId)
        {
            var dialog = new EmployeeDetailDialog();
            var dialogPresenter = new EmployeeDetailPresenter(dialog, this._employeeService, this._user, isNewMode: false, _historyService);
            dialogPresenter.LoadEmployee(employeeId);
            dialog.InitializeMode();
            dialog.Closed += (_, _) => this.LoadAllEmployees();
            dialog.ShowDialog();
        }

        public void DeleteEmployee(long employeeId)
        {
            this._employeeService.Delete(employeeId);
            //TODO Evtl. Performance Problem alles wieder zu laden. Evtl eine art caching in der View
            this.LoadAllEmployees();
        }

        public void LoadAllCustomers()
        {
            var customers = this._customerService.GetAll();
            this._overviewView.SetCustomerList(customers);
        }

        public void OpenCreateNewCustomerDialog()
        {
            var dialog = new CustomerDetailDialog();
            var dialogPresenter = new CustomerDetailPresenter(dialog, this._customerService, this._user, isNewMode: true, _historyService);
            dialogPresenter.LoadNewCustomer();
            dialog.InitializeMode();
            dialog.Closed += (_, _) => this.LoadAllCustomers();
            dialog.ShowDialog();
        }

        public void OpenEditCustomerDialog(long customerId)
        {
            var dialog = new CustomerDetailDialog();
            var dialogPresenter = new CustomerDetailPresenter(dialog, this._customerService, this._user, isNewMode: false, _historyService);
            dialogPresenter.LoadCustomer(customerId);
            dialog.InitializeMode();
            // ToDo: nach dem laden der daten noch die Controls aktualisieren
            dialog.Closed += (_, _) => this.LoadAllCustomers();
            dialog.ShowDialog();
        }

        public void DeleteCustomer(long customerId)
        {
            this._customerService.Delete(customerId);
            //TODO Evtl. Performance Problem alles wieder zu laden. Evtl eine art caching in der View
            this.LoadAllCustomers();
        }

        public void SelectedTabChanged(int selectedTabPage)
        {
            if (selectedTabPage == 0)
                this.LoadAllCustomers();
            else if (selectedTabPage == 1)
                this.LoadAllEmployees();
        }
    }
}

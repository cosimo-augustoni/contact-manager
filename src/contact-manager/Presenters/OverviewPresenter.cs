using contact_manager.Models.Data;
using contact_manager.Models.Domain;
using contact_manager.Models.Domain.Authentication;
using contact_manager.Models.Domain.CsvImport;
using contact_manager.Models.Domain.History;
using contact_manager.Presenters.Customers;
using contact_manager.Presenters.Employees;
using contact_manager.Views;
using contact_manager.Views.Customers;
using contact_manager.Views.Employees;

namespace contact_manager.Presenters
{
    public class OverviewPresenter : IPresenter
    {
        private readonly IOverviewView _overviewView;
        private readonly ICustomerService _customerService;
        private readonly ICustomerNoteService _customerNotesService;
        private readonly IEmployeeService _employeeService;
        private readonly IHistoryService _historyService;
        private readonly ICsvImporter _csvImporter;
        private readonly IUserService _userService;
        private readonly User _user;

        public OverviewPresenter(IOverviewView overviewView, ICustomerService customerService,
            ICustomerNoteService customerNotesService,
            IEmployeeService employeeService, User user, IHistoryService historyService, ICsvImporter csvImporter, IUserService userService)
        {
            this._overviewView = overviewView;
            this._user = user;

            this._customerService = customerService;
            this._customerNotesService = customerNotesService;
            this._employeeService = employeeService;
            this._historyService = historyService;
            this._csvImporter = csvImporter;
            this._userService = userService;
        }

        public void Init()
        {
            this._overviewView.SetPresenter(this);
            this._overviewView.SetSearchScopeEmployeeSource(this._employeeService.GetSearchScopes());
            this._overviewView.SetSearchScopeCustomerSource(this._customerService.GetSearchScopes());
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

        public void SearchEmployees()
        {
            var employees = this._employeeService.GetBySearchTerm(this._overviewView.SearchScopeEmployee, this._overviewView.SearchTermEmployee);
            this._overviewView.SetEmployeeList(employees);
        }

        public void OpenCreateNewEmployeeDialog()
        {
            var dialog = new EmployeeDetailDialog();
            var dialogPresenter = new EmployeeDetailPresenter(dialog, this._employeeService, this._user, isNewMode: true, _historyService, _userService);
            dialogPresenter.Init();
            dialogPresenter.LoadNewEmployee();
            dialog.InitializeMode();
            dialog.Closed += (_, _) => this.LoadAllEmployees();
            dialog.ShowDialog();
        }

        public void OpenEditEmployeeDialog(long employeeId)
        {
            var dialog = new EmployeeDetailDialog();
            var dialogPresenter = new EmployeeDetailPresenter(dialog, this._employeeService, this._user, isNewMode: false, _historyService,_userService);
            dialogPresenter.Init();
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

        public void SearchCustomers()
        {
            var customers = this._customerService.GetBySearchTerm(this._overviewView.SearchScopeCustomer, this._overviewView.SearchTermCustomer);
            this._overviewView.SetCustomerList(customers);
        }

        public void OpenCreateNewCustomerDialog()
        {
            var dialog = new CustomerDetailDialog();
            var dialogPresenter = new CustomerDetailPresenter(dialog, this._customerService, this._customerNotesService, this._user, isNewMode: true, _historyService,_userService);
            dialogPresenter.Init();
            dialogPresenter.LoadNewCustomer();
            dialog.InitializeMode();
            dialog.Closed += (_, _) => this.LoadAllCustomers();
            dialog.ShowDialog();
        }

        public void OpenEditCustomerDialog(long customerId)
        {
            var dialog = new CustomerDetailDialog();
            var dialogPresenter = new CustomerDetailPresenter(dialog, this._customerService, this._customerNotesService, this._user, isNewMode: false, _historyService,_userService);
            dialogPresenter.Init();
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

        public void ImportCsv<T>(OpenFileDialog openFileDialog) where T : Person
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    var importedPersons = this._csvImporter.ParseCsv<T>(openFileDialog.FileName);
                    var importType = "";
                    foreach (var person in importedPersons)
                    {
                        if (typeof(T) == typeof(Employee))
                        {
                            person.Id = this._employeeService.GetNewId();
                            this._employeeService.Save(person as Employee);
                            importType = "Mitarbeiter";
                        }
                        else
                        {
                            person.Id = this._customerService.GetNewId();
                            this._customerService.Save(person as Customer);
                            importType = "Kunden";
                        }
                    }

                    this.LoadAllCustomers();
                    this.LoadAllEmployees();
                    MessageBox.Show($"{importedPersons.Count()} {importType} erfolgreich importiert!");
                }
                catch (CsvHelper.FieldValidationException e)
                {
                    var context = e.Context;
                    var header = context.Reader.HeaderRecord[context.Reader.CurrentIndex];
                    MessageBox.Show(
                        $"Validierungsfehler beim Import:\r\n\r\n" +
                        $"Ungültiger Wert: {e.Field}\r\n" +
                        $"Spalte: {header}\r\n" +
                        $"Zeile: {context.Parser.Row - 1}",
                        "Validierungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Warning
                        );
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);

                }

            }
        }

        public void SelectedTabChanged(int selectedTabPage)
        {
            if (selectedTabPage == 0)
                this.LoadAllCustomers();
            else if (selectedTabPage == 1)
                this.LoadAllEmployees();
            else if (selectedTabPage == 2)
                this.LoadDashbaordData();
        }

        public void LoadDashbaordData()
        {
            var customers = this._customerService.GetAll();
            var activeCustomerCount = customers.Where(a => a.State == Models.Data.State.Active).Count();
            var passiveCustomerCount = customers.Where(a => a.State == Models.Data.State.Passive).Count();
            var cityNames = new List<string?>();
            var cityCounts = new List<double>();
            var customerTypes = new List<string>();
            var customerTypeCounts = new List<double>();

            var cityData = customers
                .Where(c => !String.IsNullOrEmpty(c.City))
                .GroupBy(c => c.City)
                .Select(c => new
                {
                    CityName = $"{c.Key} ({c.Count()})",
                    Count = c.Count()
                });

            if (cityData.Count() > 3)
            {
                var threeCitiesWithHighestCountData = cityData.OrderByDescending(c => c.Count).Take(3);
                var othersCount = cityData.OrderBy(c => c.Count).Take(cityData.Count() - 3).Sum(c => (double) c.Count);
                cityNames.AddRange(threeCitiesWithHighestCountData.Select(c => c.CityName).ToList());
                cityNames.Add($"Andere ({othersCount})");

                cityCounts.AddRange(threeCitiesWithHighestCountData.Select(c => (double) c.Count).ToList());
                cityCounts.Add(othersCount);
            }
            else
            {
                cityNames.AddRange(cityData.Select(c => c.CityName).ToList());
                cityCounts.AddRange(cityData.Select(c => (double)c.Count).ToList());
            }

            var customerTypeData = customers
                .GroupBy(c => c.CustomerType)
                .Select(c => new
                {
                    CustomerType = $"{c.Key} ({c.Count()})",
                    Count = c.Count()
                });

            customerTypes.AddRange(customerTypeData.Select(c => c.CustomerType).ToList());
            customerTypeCounts.AddRange(customerTypeData.Select(c => (double)c.Count).ToList());
 
            var dashboardData = new DashboardData(activeCustomerCount, passiveCustomerCount, cityNames.ToArray(), cityCounts.ToArray(),
                customerTypes.ToArray(), customerTypeCounts.ToArray());

            this._overviewView.SetDashboardData(dashboardData);
        }
    }
}

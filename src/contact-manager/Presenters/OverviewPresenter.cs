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
        private readonly IEmployeeService<Employee> _employeeService;
        private readonly IEmployeeService<Trainee> _traineeService;
        private readonly IHistoryService _historyService;
        private readonly ICsvImporter _csvImporter;
        private readonly IUserService _userService;
        private readonly User _user;

        public OverviewPresenter(IOverviewView overviewView,
            ICustomerService customerService,
            ICustomerNoteService customerNotesService,
            IEmployeeService<Employee> employeeService,
            IEmployeeService<Trainee> traineeService,
            User user,
            IHistoryService historyService,
            ICsvImporter csvImporter, IUserService userService)
        {
            this._overviewView = overviewView;
            this._user = user;

            this._customerService = customerService;
            this._customerNotesService = customerNotesService;
            this._employeeService = employeeService;
            this._traineeService = traineeService;
            this._historyService = historyService;
            this._csvImporter = csvImporter;
            this._userService = userService;
        }

        public void Init()
        {
            this._overviewView.SetPresenter(this);
            this._overviewView.SetSearchScopeEmployeeSource(this._employeeService.GetSearchScopes());
            this._overviewView.SetSearchScopeCustomerSource(this._customerService.GetSearchScopes());
            this._overviewView.SetSearchScopeTraineeSource(this._traineeService.GetSearchScopes());
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
            var dialogPresenter = new EmployeeDetailPresenter(dialog, this._employeeService, this._user, isNewMode: false, _historyService, _userService);
            dialogPresenter.Init();
            dialogPresenter.LoadEmployee(employeeId);
            dialog.InitializeMode();
            dialog.Closed += (_, _) => this.LoadAllEmployees();
            dialog.ShowDialog();
        }

        public void DeleteEmployee(long employeeId)
        {
            this._employeeService.Delete(employeeId);
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
            var dialogPresenter = new CustomerDetailPresenter(dialog, this._customerService, this._customerNotesService, this._user, isNewMode: true, _historyService, _userService);
            dialogPresenter.Init();
            dialogPresenter.LoadNewCustomer();
            dialog.InitializeMode();
            dialog.Closed += (_, _) => this.LoadAllCustomers();
            dialog.ShowDialog();
        }

        public void OpenEditCustomerDialog(long customerId)
        {
            var dialog = new CustomerDetailDialog();
            var dialogPresenter = new CustomerDetailPresenter(dialog, this._customerService, this._customerNotesService, this._user, isNewMode: false, _historyService, _userService);
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
            this.LoadAllCustomers();
        }

        public void LoadAllTrainees()
        {
            var trainees = this._traineeService.GetAll();
            this._overviewView.SetTraineeList(trainees);
        }

        public void SearchTrainees()
        {
            var employees = this._traineeService.GetBySearchTerm(this._overviewView.SearchScopeTrainee, this._overviewView.SearchTermTrainee);
            this._overviewView.SetTraineeList(employees);
        }

        public void OpenCreateNewTraineeDialog()
        {
            var dialog = new TraineeDetailDialog();
            var dialogPresenter = new TraineeDetailPresenter(dialog, this._traineeService, this._user, isNewMode: true, _historyService, _userService);
            dialogPresenter.Init();
            dialogPresenter.LoadNewEmployee();
            dialog.InitializeMode();
            dialog.Closed += (_, _) => this.LoadAllTrainees();
            dialog.ShowDialog();
        }

        public void OpenEditTraineeDialog(long traineeId)
        {
            var dialog = new TraineeDetailDialog();
            var dialogPresenter = new TraineeDetailPresenter(dialog, this._traineeService, this._user, isNewMode: false, _historyService, _userService);
            dialogPresenter.Init();
            dialogPresenter.LoadEmployee(traineeId);
            dialog.InitializeMode();
            dialog.Closed += (_, _) => this.LoadAllTrainees();
            dialog.ShowDialog();
        }

        public void DeleteTrainee(long traineeId)
        {
            this._traineeService.Delete(traineeId);
            this.LoadAllTrainees();
        }

        public void ImportCsv<T>(OpenFileDialog openFileDialog) where T : Person
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                var importedPersons = this._csvImporter.ParseCsv<T>(openFileDialog.FileName);
                var importType = "";

                if (typeof(T) == typeof(Employee))
                {
                    foreach (var person in importedPersons.Cast<Employee>())
                    {
                        person.Id = this._employeeService.GetNewId();
                        this._employeeService.Save(person);
                        importType = "Mitarbeiter";
                    }
                    this.LoadAllEmployees();
                }
                else if (typeof(T) == typeof(Trainee))
                {
                    foreach (var person in importedPersons.Cast<Trainee>())
                    {
                        person.Id = this._traineeService.GetNewId();
                        this._traineeService.Save(person);
                        importType = "Lernende";
                    }
                    this.LoadAllTrainees();
                }
                else if (typeof(T) == typeof(Customer))
                {
                    foreach (var person in importedPersons.Cast<Customer>())
                    {
                        person.Id = this._customerService.GetNewId();
                        this._customerService.Save(person as Customer);
                        importType = "Kunden";
                    }
                    this.LoadAllCustomers();
                }
                else
                {
                    MessageBox.Show($"Personentyp ist nicht bekannt. Der Import ist fehlgeschlagen!", "Import fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show($"{importedPersons.Count} {importType} erfolgreich importiert!");
            }
            catch (CsvHelper.FieldValidationException e)
            {
                var context = e.Context;
                var header = context.Reader.HeaderRecord?[context.Reader.CurrentIndex];
                MessageBox.Show(
                    $@"Validierungsfehler beim Import:

Ungültiger Wert: {e.Field}
Spalte: {header}
Zeile: {context.Parser.Row - 1}",
                    "Validierungsfehler", MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void SelectedTabChanged(int selectedTabPage)
        {
            if (selectedTabPage == 0)
                this.LoadAllCustomers();
            else if (selectedTabPage == 1)
                this.LoadAllEmployees();
            else if (selectedTabPage == 2)
                this.LoadAllTrainees();
            else if (selectedTabPage == 3)
                this.LoadDashboardData();
        }

        public void LoadDashboardData()
        {
            var customers = this._customerService.GetAll();
            var employeeCount = this._employeeService.GetAll().Count;
            var traineeCount = this._traineeService.GetAll().Count;
            var activeCustomerCount = customers.Count(a => a.State == State.Active);
            var passiveCustomerCount = customers.Count(a => a.State == State.Passive);
            var cityStatistics = this.GetCityStatistics(customers);
            var customerTypeStatistics = this.GetCustomerTypeStatistics(customers);
            var dashboardData = new DashboardData(activeCustomerCount, passiveCustomerCount,
                employeeCount, traineeCount, cityStatistics, customerTypeStatistics);

            this._overviewView.SetDashboardData(dashboardData);
        }

        private Dictionary<string, int> GetCustomerTypeStatistics(List<Customer> customers)
        {
            var customerTypeStatistics = customers
                .GroupBy(c => c.CustomerType)
                .ToDictionary(g => $"{g.Key} ({g.Count()})", g => g.Count());
            return customerTypeStatistics;
        }

        private Dictionary<string, int> GetCityStatistics(List<Customer> customers)
        {
            var cityData = customers
                .Where(c => !string.IsNullOrEmpty(c.City))
                .GroupBy(c => c.City)
                .Select(c => new
                {
                    CityName = $"{c.Key} ({c.Count()})",
                    Count = c.Count()
                })
                .OrderByDescending(c => c.Count)
                .ToList();

            var cityStatistics = cityData.Take(3).ToDictionary(c => c.CityName, c => c.Count);
            if (cityData.Count > 3)
            {
                var otherCount = cityData.Skip(3).Sum(c => c.Count);
                cityStatistics.Add($"Andere ({otherCount})", otherCount);
            }

            return cityStatistics;
        }

        
    }
}

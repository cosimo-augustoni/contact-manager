using contact_manager.Models.Data;
using contact_manager.Models.Data.History;
using contact_manager.Models.Domain;
using contact_manager.Models.Domain.Authentication;
using contact_manager.Models.Domain.CsvImport;
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
            var loginPresenter = new LoginPresenter(loginView, userService, this);
            loginPresenter.Init();

            return loginView;
        }

        public OverviewView CreateOverview(User user)
        {
            var customerRepository = new RepositoryWithHistorization<Customer>(user);
            var customerService = new CustomerService(customerRepository);

            var employeeRepository = new RepositoryWithHistorization<Employee>(user);
            var employeeService = new EmployeeService<Employee>(employeeRepository);

            var traineeRepository = new RepositoryWithHistorization<Trainee>(user);
            var traineeService = new EmployeeService<Trainee>(traineeRepository);

            var customerNoteRepository = new Repository<CustomerNote>(new FileStore<CustomerNote>());
            var customerNotesService = new CustomerNoteService(customerNoteRepository);

            var historyService = new HistoryService(new Repository<HistoryEntry>(new FileStore<HistoryEntry>()));

            var overviewView = new OverviewView();
            var csvImporter = new CsvImporter();
            var userService = new UserService();
            var overviewPresenter = new OverviewPresenter(
                    overviewView,
                    customerService,
                    customerNotesService,
                    employeeService,
                    traineeService,
                    user,
                    historyService,
                    csvImporter,
                    userService);

            overviewPresenter.Init();
            overviewPresenter.LoadAllCustomers();

            return overviewView;
        }
    }
}

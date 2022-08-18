using contact_manager.Models.Data.Customer;
using contact_manager.Models.Data.Employee;
using contact_manager.Presenters;

namespace contact_manager.Views
{
    public partial class DashboardView : Form, IDashboardView
    {
        private DashboardPresenter? presenter;

        public DashboardView()
        {
            this.InitializeComponent();
        }

        public void SetPresenter(DashboardPresenter dashboardPresenter)
        {
            this.presenter = dashboardPresenter;
        }

        public void SetEmployeeList(List<Employee> employees)
        {
            throw new NotImplementedException();
        }

        public void SetCustomerList(List<Customer> customers)
        {
            throw new NotImplementedException();
        }

        private void CmdCreateNewEmployee_Click(object sender, EventArgs e)
        {
            this.presenter?.OpenCreateNewEmployeeDialog();
        }

        private void CmdCreateNewCustomer_Click(object sender, EventArgs e)
        {
            this.presenter?.OpenCreateNewCustomerDialog();
        }
    }
}
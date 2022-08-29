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
            this.dataGridViewEmployee.DataSource = employees;
        }

        public void SetCustomerList(List<Customer> customers)
        {
            dataGridViewCustomer.DataSource = customers;
        }

        private void CmdCreateNewEmployee_Click(object sender, EventArgs e)
        {
            this.presenter?.OpenCreateNewEmployeeDialog();
        }

        private void CmdCreateNewCustomer_Click(object sender, EventArgs e)
        {
            this.presenter?.OpenCreateNewCustomerDialog();
        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewCustomer.CurrentRow?.DataBoundItem is Customer customer)
            {
                // todo: indexes als constanten festhalten
                if (e.ColumnIndex == 11)
                {
                    OpenEditCustomerDialog(customer.Id);
                }
                if (e.ColumnIndex == 12)
                {
                    this.presenter?.DeleteCustomer(customer.Id);
                }
            }
        }

        private void dataGridViewCustomer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewCustomer.CurrentRow?.DataBoundItem is Customer customer)
            {
                OpenEditCustomerDialog(customer.Id);
            }
        }

        private void OpenEditCustomerDialog(long customerId)
        {
                this.presenter?.OpenEditCustomerDialog(customerId);
        }

        private void OpenEditEmployeeDialog(long employeeId)
        {
            this.presenter?.OpenEditEmployeeDialog(employeeId);
        }

        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewEmployee.CurrentRow?.DataBoundItem is Employee employee)
            {
                if (e.ColumnIndex == 10)
                {
                    OpenEditEmployeeDialog(employee.Id);
                }
                if (e.ColumnIndex == 11)
                {
                    this.presenter?.DeleteEmployee(employee.Id);
                }
            }
        }

        private void dataGridViewEmployee_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewEmployee.CurrentRow?.DataBoundItem is Employee employee)
            {
                OpenEditEmployeeDialog(employee.Id);
            }
        }

        private void TcPerson_Selected(object sender, TabControlEventArgs e)
        {
            this.presenter?.SelectedTabChanged(e.TabPageIndex);
        }
    }
}

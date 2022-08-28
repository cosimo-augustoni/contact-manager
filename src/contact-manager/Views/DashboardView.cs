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
            // todo npa: wieder entfernen
            SetCustomerList(null);
        }

        public void SetPresenter(DashboardPresenter dashboardPresenter)
        {
            this.presenter = dashboardPresenter;
        }

        public void SetEmployeeList(List<Employee> employees)
        {
            employees = new List<Employee>()
            {
                new Employee()
                {
                    LastName = "Nef",
                    FirstName = "Patrick"
                }
            };
            //throw new NotImplementedException();
        }

        public void SetCustomerList(List<Customer> customers)
        {
            // todo so wieder entfernen
            customers = new List<Customer>() {
                new Customer() {
                    LastName = "Nef",
                    FirstName = "Patrick",
                }
            };

            dataGridViewCustomer.DataSource = customers;
            //throw new NotImplementedException();
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
            if (dataGridViewCustomer.CurrentRow != null)
            {
                // todo: indexes als constanten festhalten
                if (e.ColumnIndex == 11)
                {
                    OpenEditCustomerDialog();
                }
                if (e.ColumnIndex == 12)
                {
                    // todo: delete customer
                }
            }
        }

        private void dataGridViewCustomer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           if (dataGridViewCustomer.CurrentRow != null)
            {
                OpenEditCustomerDialog();
            }
        }

        private void OpenEditCustomerDialog()
        {
            Customer? customer = dataGridViewCustomer.CurrentRow.DataBoundItem as Customer;
            if (customer != null)
            {
                this.presenter?.OpenEditCustomerDialog(customer.Id);
            }
        }

        private void OpenEditEmployeeDialog()
        {
            Employee? employee = dataGridViewEmployee.CurrentRow.DataBoundItem as Employee;
            if (employee != null)
            {
                this.presenter?.OpenEditEmployeeDialog(employee.Id);
            }
        }

        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEmployee.CurrentRow != null)
            {
                if (e.ColumnIndex == 10)
                {
                    OpenEditEmployeeDialog();
                }
                if (e.ColumnIndex == 11)
                {
                    // todo: delete employee
                }
            }
        }

        private void dataGridViewEmployee_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEmployee.CurrentRow != null)
            {
                OpenEditEmployeeDialog();
            }
        }
    }
}

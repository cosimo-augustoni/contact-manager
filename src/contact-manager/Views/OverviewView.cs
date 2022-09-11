using contact_manager.Models.Data.Customer;
using contact_manager.Models.Data.Employee;
using contact_manager.Presenters;

namespace contact_manager.Views
{
    public partial class OverviewView : Form, IOverviewView
    {
        private OverviewPresenter? presenter;

        public OverviewView()
        {
            this.InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public void SetPresenter(OverviewPresenter overviewPresenter)
        {
            this.presenter = overviewPresenter;
            InitializeMode();
        }

        public void SetEmployeeList(List<Employee> employees)
        {
            this.dataGridViewEmployee.DataSource = employees;
        }

        public void SetCustomerList(List<Customer> customers)
        {
            dataGridViewCustomer.DataSource = customers;
        }

        private void InitializeMode()
        {
            var isEnabled = !this.presenter?.IsReadOnly ?? false;

            CmdCreateNewCustomer.Enabled = isEnabled;
            CmdCreateNewEmployee.Enabled = isEnabled;
            CmdDeleteCustomer.Enabled = isEnabled;
            CmdDeleteEmployee.Enabled = isEnabled;
            CmdImportCustomer.Enabled = isEnabled;
            CmdImportEmployee.Enabled = isEnabled;

            if (isEnabled)
            {
                CmdEditCustomer.Text = CmdEditEmployee.Text = "Bearbeiten";
                CmdEditCustomer.Image = CmdEditEmployee.Image = contact_manager.Properties.Resources.Edit;
            }
            else
            {
                CmdEditCustomer.Text = CmdEditEmployee.Text = "Anzeigen";
                CmdEditCustomer.Image = CmdEditEmployee.Image = contact_manager.Properties.Resources.ShowDataPreview;
            }
        }

        //----------------------------------------------------------------------------------------------------
        #region New
        //----------------------------------------------------------------------------------------------------

        private void CmdCreateNewCustomer_Click(object sender, EventArgs e)
        {
            this.presenter?.OpenCreateNewCustomerDialog();
            // ToDo npa: nach dem neu, wenn gespeichert wurde dann den neuen eintrag gleich markieren im datagridview?
        }

        private void CmdCreateNewEmployee_Click(object sender, EventArgs e)
        {
            this.presenter?.OpenCreateNewEmployeeDialog();
        }

        #endregion // New

        //----------------------------------------------------------------------------------------------------
        #region Edit
        //----------------------------------------------------------------------------------------------------

        private void CmdEditCustomer_Click(object sender, EventArgs e)
        {
            EditCustomer();
        }

        private void EditCustomer()
        {
            var customer = GetCurrentSelectedCustomer();
            if (customer != null)
            {
                this.presenter?.OpenEditCustomerDialog(customer.Id);
            }
        }

        private void CmdEditEmployee_Click(object sender, EventArgs e)
        {
            EditEmployee();
        }

        private void EditEmployee()
        {
            var employee = GetCurrentSelectedEmployee();
            if (employee != null)
            {
                this.presenter?.OpenEditEmployeeDialog(employee.Id);
                // todo: nach dem bearbeiten wieder denselben eintrag markieren wie vorher?
            }
        }

        private void dataGridViewCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditCustomer();
        }

        private void dataGridViewEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditEmployee();
        }

        #endregion // Edit

        //----------------------------------------------------------------------------------------------------
        #region Delete
        //----------------------------------------------------------------------------------------------------

        private void CmdDeleteCustomer_Click(object sender, EventArgs e)
        {
            var customer = GetCurrentSelectedCustomer();
            if (customer != null)
            {
                var dialogResult = MessageBox.Show("Möchten Sie diesen Kunden wirklich löschen", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this.presenter?.DeleteCustomer(customer.Id);
                }
            }
        }

        private void CmdDeleteEmployee_Click(object sender, EventArgs e)
        {
            var employee = GetCurrentSelectedEmployee();
            if (employee != null)
            {
                var dialogResult = MessageBox.Show("Möchten Sie diesen Mitarbeiter wirklich löschen?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this.presenter?.DeleteEmployee(employee.Id);
                }
            }
        }

        private Customer? GetCurrentSelectedCustomer()
        {
            return this.dataGridViewCustomer.CurrentRow?.DataBoundItem as Customer;
        }

        private Employee? GetCurrentSelectedEmployee()
        {
            return this.dataGridViewEmployee.CurrentRow?.DataBoundItem as Employee;
        }

        #endregion // Delete

        //----------------------------------------------------------------------------------------------------
        #region Search
        //----------------------------------------------------------------------------------------------------

        private void TxtSearchCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Todo: search
            }
        }

        private void CmdSearchCustomer_Click(object sender, EventArgs e)
        {
            // ToDo: search customer
        }

        private void CmdResetSearchCustomer_Click(object sender, EventArgs e)
        {
            TxtSearchCustomer.Clear();
            this.presenter?.LoadAllCustomers();
        }

        private void TxtSearchEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            // todo: search employee
        }

        private void CmdSearchEmployee_Click(object sender, EventArgs e)
        {
            // todo: search employee
        }

        private void CmdResetSearchEmployee_Click(object sender, EventArgs e)
        {
            TxtSearchEmployee.Clear();
            this.presenter?.LoadAllEmployees();
        }

        #endregion // Search

        //----------------------------------------------------------------------------------------------------
        #region TabControl
        //----------------------------------------------------------------------------------------------------

        private void TcPerson_Selected(object sender, TabControlEventArgs e)
        {
            this.presenter?.SelectedTabChanged(e.TabPageIndex);
        }

        #endregion // TabControl

        //----------------------------------------------------------------------------------------------------
        #region Import
        //----------------------------------------------------------------------------------------------------

        private void CmdImportCustomer_Click(object sender, EventArgs e)
        {
            // ToDo: import customer
        }

        private void CmdImportEmployee_Click(object sender, EventArgs e)
        {
            // ToDo: import employee
        }
        #endregion // Import
    }
}

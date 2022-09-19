using contact_manager.Models.Domain.Search;
using contact_manager.Models.Data;
using contact_manager.Presenters;

namespace contact_manager.Views
{
    public partial class OverviewView : Form, IOverviewView
    {
        private OverviewPresenter? _presenter;

        public OverviewView()
        {
            this.InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public void SetPresenter(OverviewPresenter overviewPresenter)
        {
            this._presenter = overviewPresenter;
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
            var isEnabled = !this._presenter?.IsReadOnly ?? false;

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
            this._presenter?.OpenCreateNewCustomerDialog();
            // ToDo npa: nach dem neu, wenn gespeichert wurde dann den neuen eintrag gleich markieren im datagridview?
        }

        private void CmdCreateNewEmployee_Click(object sender, EventArgs e)
        {
            this._presenter?.OpenCreateNewEmployeeDialog();
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
                this._presenter?.OpenEditCustomerDialog(customer.Id);
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
                this._presenter?.OpenEditEmployeeDialog(employee.Id);
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
                    this._presenter?.DeleteCustomer(customer.Id);
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
                    this._presenter?.DeleteEmployee(employee.Id);
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

        public string SearchTermCustomer
        {
            get => this.TxtSearchCustomer.Text;
            set => this.TxtSearchCustomer.Text = value;
        }

        public SearchScope SearchScopeCustomer
        {
            get => (SearchScope)this.CmbSearchScopeCustomer.SelectedItem;
            set => this.CmbSearchScopeCustomer.SelectedItem = value;
        }

        public void SetSearchScopeCustomerSource(List<SearchScope> scopes)
        {
            this.CmbSearchScopeCustomer.DataSource = scopes;
            this.CmbSearchScopeCustomer.DisplayMember = nameof(SearchScope.DisplayName);

            this.CmbSearchScopeCustomer.SelectedItem = scopes.First(s => s.ScopeType == ScopeType.All);
        }

        private void TxtSearchCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this._presenter?.SearchCustomers();
            }
        }

        private void CmdSearchCustomer_Click(object sender, EventArgs e)
        {
            this._presenter?.SearchCustomers();
        }

        private void CmdResetSearchCustomer_Click(object sender, EventArgs e)
        {
            TxtSearchCustomer.Clear();
            this._presenter?.LoadAllCustomers();
        }

        public string SearchTermEmployee
        {
            get => this.TxtSearchEmployee.Text;
            set => this.TxtSearchEmployee.Text = value;
        }

        public SearchScope SearchScopeEmployee
        {
            get => (SearchScope)this.CmbSearchScopeEmployee.SelectedItem;
            set => this.CmbSearchScopeEmployee.SelectedItem = value;
        }

        public void SetSearchScopeEmployeeSource(List<SearchScope> scopes)
        {
            this.CmbSearchScopeEmployee.DataSource = scopes;
            this.CmbSearchScopeEmployee.DisplayMember = nameof(SearchScope.DisplayName);

            this.CmbSearchScopeEmployee.SelectedItem = scopes.First(s => s.ScopeType == ScopeType.All);
        }

        private void TxtSearchEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this._presenter?.SearchEmployees();
            }
        }

        private void CmdSearchEmployee_Click(object sender, EventArgs e)
        {
            this._presenter?.SearchEmployees();
        }

        private void CmdResetSearchEmployee_Click(object sender, EventArgs e)
        {
            TxtSearchEmployee.Clear();
            this._presenter?.LoadAllEmployees();
        }

        #endregion // Search

        //----------------------------------------------------------------------------------------------------
        #region TabControl
        //----------------------------------------------------------------------------------------------------

        private void TcPerson_Selected(object sender, TabControlEventArgs e)
        {
            this._presenter?.SelectedTabChanged(e.TabPageIndex);
        }

        #endregion // TabControl

        //----------------------------------------------------------------------------------------------------
        #region Import
        //----------------------------------------------------------------------------------------------------

        private void CmdImportCustomer_Click(object sender, EventArgs e)
        {
            this.openFileDialog.Title = "Kunden importieren";
            this._presenter?.ImportCsv<Customer>(this.openFileDialog);
        }

        private void CmdImportEmployee_Click(object sender, EventArgs e)
        {
            this.openFileDialog.Title = "Mitarbeiter importieren";
            this._presenter?.ImportCsv<Employee>(this.openFileDialog);
        }

        #endregion // Import

        //----------------------------------------------------------------------------------------------------
        #region Dashboard
        //----------------------------------------------------------------------------------------------------

        public void SetDashboardData(DashboardData dashboardData)
        {
            CreateCustomerCountFormsPlot(dashboardData);
            CreateCustomerCityFormsPlot(dashboardData);
            CreateCustomerTypeFormsPlot(dashboardData);
        }

        private void CreateCustomerCountFormsPlot(DashboardData dashboardData)
        {
            CustomerCountFormsPlot.Plot.Clear();
            var activeCustomerCount = dashboardData.ActiveCustomerCount;
            var passiveCustomerCount = dashboardData.PassiveCustomerCount;

            var max = activeCustomerCount >= passiveCustomerCount ? activeCustomerCount : passiveCustomerCount;

            List<ScottPlot.Plottable.Bar> bars = new List<ScottPlot.Plottable.Bar>();
            ScottPlot.Plottable.Bar activeBar = new ScottPlot.Plottable.Bar()
            {
                Position = 0,
                Value = activeCustomerCount,
                Label = $"aktiv ({activeCustomerCount})",
                FillColor = Color.Blue

            };
            ScottPlot.Plottable.Bar passiveBar = new ScottPlot.Plottable.Bar()
            {
                Position = 2,
                Value = passiveCustomerCount,
                Label = $"passiv ({passiveCustomerCount})",
                FillColor = Color.Tomato
            };
            bars.Add(activeBar);
            bars.Add(passiveBar);
            CustomerCountFormsPlot.Plot.XAxis.Ticks(false);
            CustomerCountFormsPlot.Plot.YAxis.Label("Anzahl");
            CustomerCountFormsPlot.Plot.XAxis.Label("Status");
            CustomerCountFormsPlot.Plot.AddBarSeries(bars);
            CustomerCountFormsPlot.Plot.SetAxisLimits(yMin: 0, yMax: max + 10);
            CustomerCountFormsPlot.Plot.Legend(location: ScottPlot.Alignment.UpperRight);
            CustomerCountFormsPlot.Refresh();
        }

        private void CreateCustomerCityFormsPlot(DashboardData dashboardData)
        {
            CustomerCityFormsPlot.Plot.Clear();
            var pie = CustomerCityFormsPlot.Plot.AddPie(dashboardData.CityStatistics.Values.Select(v => (double)v).ToArray());

            pie.SliceLabels = dashboardData.CityStatistics.Keys.ToArray();
            pie.Explode = true;

            CustomerCityFormsPlot.Plot.Legend(location: ScottPlot.Alignment.UpperRight);
            CustomerCityFormsPlot.Refresh();
        }

        private void CreateCustomerTypeFormsPlot(DashboardData dashboardData)
        {
            CustomerTypeFormsPlot.Plot.Clear();
            var pie = CustomerTypeFormsPlot.Plot.AddPie(dashboardData.CustomerTypeStatistics.Values.Select(v => (double)v).ToArray());
            pie.SliceLabels = dashboardData.CustomerTypeStatistics.Keys.ToArray();
            pie.Explode = true;
            CustomerTypeFormsPlot.Plot.Legend(location: ScottPlot.Alignment.UpperRight);
            CustomerTypeFormsPlot.Refresh();
        }
        #endregion // Dashboard

        private void CmdCreateNewTrainee_Click(object sender, EventArgs e)
        {

        }

        private void CmdEditTrainee_Click(object sender, EventArgs e)
        {

        }

        private void CmdDeleteTrainee_Click(object sender, EventArgs e)
        {

        }

        private void CmdImportTrainee_Click(object sender, EventArgs e)
        {

        }

        private void CmdSearchTrainee_Click(object sender, EventArgs e)
        {
            // events bitte analog dem mitarbeiter ergänzen, allenfalls fehlen noch welche
        }

        private void CmdResetSearchTrainee_Click(object sender, EventArgs e)
        {

        }
    }
}

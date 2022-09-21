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
            this.InitializeMode();
        }

        public void SetEmployeeList(List<Employee> employees)
        {
            this.dataGridViewEmployee.DataSource = employees;
        }

        public void SetCustomerList(List<Customer> customers)
        {
            this.dataGridViewCustomer.DataSource = customers;
        }

        public void SetTraineeList(List<Trainee> trainees)
        {
            this.dataGridViewTrainee.DataSource = trainees;
        }
        

        private void InitializeMode()
        {
            var isEnabled = !this._presenter?.IsReadOnly ?? false;

            this.CmdCreateNewCustomer.Enabled = isEnabled;
            this.CmdCreateNewEmployee.Enabled = isEnabled;
            this.CmdDeleteCustomer.Enabled = isEnabled;
            this.CmdDeleteEmployee.Enabled = isEnabled;
            this.CmdImportCustomer.Enabled = isEnabled;
            this.CmdImportEmployee.Enabled = isEnabled;

            if (isEnabled)
            {
                this.CmdEditCustomer.Text = this.CmdEditEmployee.Text = "Bearbeiten";
                this.CmdEditCustomer.Image = this.CmdEditEmployee.Image = Properties.Resources.Edit;
            }
            else
            {
                this.CmdEditCustomer.Text = this.CmdEditEmployee.Text = "Anzeigen";
                this.CmdEditCustomer.Image = this.CmdEditEmployee.Image = Properties.Resources.ShowDataPreview;
            }
        }

        //----------------------------------------------------------------------------------------------------
        #region New
        //----------------------------------------------------------------------------------------------------

        private void CmdCreateNewCustomer_Click(object sender, EventArgs e)
        {
            this._presenter?.OpenCreateNewCustomerDialog();
        }

        private void CmdCreateNewEmployee_Click(object sender, EventArgs e)
        {
            this._presenter?.OpenCreateNewEmployeeDialog();
        }

        private void CmdCreateNewTrainee_Click(object sender, EventArgs e)
        {
            this._presenter?.OpenCreateNewTraineeDialog();
        }

        #endregion // New

        //----------------------------------------------------------------------------------------------------
        #region Edit
        //----------------------------------------------------------------------------------------------------

        private void CmdEditCustomer_Click(object sender, EventArgs e)
        {
            this.EditCustomer();
        }

        private void EditCustomer()
        {
            var customer = this.GetCurrentSelectedCustomer();
            if (customer != null)
            {
                this._presenter?.OpenEditCustomerDialog(customer.Id);
            }
        }

        private void CmdEditEmployee_Click(object sender, EventArgs e)
        {
            this.EditEmployee();
        }

        private void EditEmployee()
        {
            var employee = this.GetCurrentSelectedEmployee();
            if (employee != null)
            {
                this._presenter?.OpenEditEmployeeDialog(employee.Id);
            }
        }

        private void CmdEditTrainee_Click(object sender, EventArgs e)
        {
            this.EditTrainee();
        }

        private void EditTrainee()
        {
            var trainee = this.GetCurrentSelectedTrainee();
            if (trainee != null)
            {
                this._presenter?.OpenEditTraineeDialog(trainee.Id);
            }
        }

        private void dataGridViewCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.EditCustomer();
        }

        private void dataGridViewEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.EditEmployee();
        }

        private void dataGridViewTrainee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.EditTrainee();
        }

        #endregion // Edit

        //----------------------------------------------------------------------------------------------------
        #region Delete
        //----------------------------------------------------------------------------------------------------

        private void CmdDeleteCustomer_Click(object sender, EventArgs e)
        {
            var customer = this.GetCurrentSelectedCustomer();
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
            var employee = this.GetCurrentSelectedEmployee();
            if (employee != null)
            {
                var dialogResult = MessageBox.Show("Möchten Sie diesen Mitarbeiter wirklich löschen?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this._presenter?.DeleteEmployee(employee.Id);
                }
            }
        }

        private void CmdDeleteTrainee_Click(object sender, EventArgs e)
        {
            var trainee = this.GetCurrentSelectedTrainee();
            if (trainee != null)
            {
                var dialogResult = MessageBox.Show("Möchten Sie diesen Lernenden wirklich löschen?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this._presenter?.DeleteTrainee(trainee.Id);
                }
            }
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
            this.TxtSearchCustomer.Clear();
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
            this.TxtSearchEmployee.Clear();
            this._presenter?.LoadAllEmployees();
        }

        public string SearchTermTrainee
        {
            get => this.TxtSearchTrainee.Text;
            set => this.TxtSearchTrainee.Text = value;
        }

        public SearchScope SearchScopeTrainee
        {
            get => (SearchScope)this.CmbSearchScopeTrainee.SelectedItem;
            set => this.CmbSearchScopeTrainee.SelectedItem = value;
        }

        public void SetSearchScopeTraineeSource(List<SearchScope> scopes)
        {
            this.CmbSearchScopeTrainee.DataSource = scopes;
            this.CmbSearchScopeTrainee.DisplayMember = nameof(SearchScope.DisplayName);

            this.CmbSearchScopeTrainee.SelectedItem = scopes.First(s => s.ScopeType == ScopeType.All);
        }

        private void TxtSearchTrainee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this._presenter?.SearchTrainees();
            }
        }

        private void CmdSearchTrainee_Click(object sender, EventArgs e)
        {
            this._presenter?.SearchTrainees();
        }

        private void CmdResetSearchTrainee_Click(object sender, EventArgs e)
        {
            this.TxtSearchTrainee.Clear();
            this._presenter?.LoadAllTrainees();
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

        private void CmdImportTrainee_Click(object sender, EventArgs e)
        {
            this.openFileDialog.Title = "Lernende importieren";
            this._presenter?.ImportCsv<Trainee>(this.openFileDialog);
        }

        #endregion // Import

        //----------------------------------------------------------------------------------------------------
        #region Dashboard
        //----------------------------------------------------------------------------------------------------

        public void SetDashboardData(DashboardData dashboardData)
        {
            this.CreateCustomerCountFormsPlot(dashboardData);
            this.CreateCustomerCityFormsPlot(dashboardData);
            this.CreateCustomerTypeFormsPlot(dashboardData);
            this.CreatePersonsCountFormsPlot(dashboardData);
        }

        private void CreatePersonsCountFormsPlot(DashboardData dashboardData)
        {
            this.PersonsCountFormsPlot.Plot.Clear();
            var customerCount = dashboardData.ActiveCustomerCount + dashboardData.PassiveCustomerCount;
            var employeeCount = dashboardData.EmployeeCount;
            var traineeCount = dashboardData.TraineeCount;

            int[] counts = new int[3];
            counts[0] = customerCount;
            counts[1] = employeeCount;
            counts[2] = traineeCount;
            int maxCounts = counts.Max();

            List<ScottPlot.Plottable.Bar> bars = new List<ScottPlot.Plottable.Bar>();

            ScottPlot.Plottable.Bar customerBar = new ScottPlot.Plottable.Bar()
            {
                Position = 0,
                Value = customerCount,
                Label = $"Kunden ({customerCount})",
                FillColor = Color.Blue

            };
            ScottPlot.Plottable.Bar employeeBar = new ScottPlot.Plottable.Bar()
            {
                Position = 2,
                Value = employeeCount,
                Label = $"Mitarbeiter ohne Lernende ({employeeCount})",
                FillColor = Color.Tomato
            };
            ScottPlot.Plottable.Bar traineeBar = new ScottPlot.Plottable.Bar()
            {
                Position = 4,
                Value = traineeCount,
                Label = $"Lernende ({traineeCount})",
                FillColor = Color.Yellow
            };
            bars.Add(customerBar);
            bars.Add(employeeBar);
            bars.Add(traineeBar);
            this.PersonsCountFormsPlot.Plot.XAxis.Ticks(false);
            this.PersonsCountFormsPlot.Plot.YAxis.Label("Anzahl");
            this.PersonsCountFormsPlot.Plot.XAxis.Label("Personen");
            this.PersonsCountFormsPlot.Plot.AddBarSeries(bars);
            this.PersonsCountFormsPlot.Plot.SetAxisLimits(yMin: 0, yMax: maxCounts + 10);
            this.PersonsCountFormsPlot.Plot.Legend(location: ScottPlot.Alignment.UpperRight);
            this.PersonsCountFormsPlot.Refresh();
        }

        private void CreateCustomerCountFormsPlot(DashboardData dashboardData)
        {
            this.CustomerCountFormsPlot.Plot.Clear();
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
            this.CustomerCountFormsPlot.Plot.XAxis.Ticks(false);
            this.CustomerCountFormsPlot.Plot.YAxis.Label("Anzahl");
            this.CustomerCountFormsPlot.Plot.XAxis.Label("Status");
            this.CustomerCountFormsPlot.Plot.AddBarSeries(bars);
            this.CustomerCountFormsPlot.Plot.SetAxisLimits(yMin: 0, yMax: max + 10);
            this.CustomerCountFormsPlot.Plot.Legend(location: ScottPlot.Alignment.UpperRight);
            this.CustomerCountFormsPlot.Refresh();
        }

        private void CreateCustomerCityFormsPlot(DashboardData dashboardData)
        {
            if (dashboardData.CityStatistics.Count == 0) return;

            this.CustomerCityFormsPlot.Plot.Clear();
            var pie = this.CustomerCityFormsPlot.Plot.AddPie(dashboardData.CityStatistics.Values.Select(v => (double)v).ToArray());

            pie.SliceLabels = dashboardData.CityStatistics.Keys.ToArray();
            pie.Explode = true;

            this.CustomerCityFormsPlot.Plot.Legend(location: ScottPlot.Alignment.UpperRight);
            this.CustomerCityFormsPlot.Refresh();
        }

        private void CreateCustomerTypeFormsPlot(DashboardData dashboardData)
        {
            if (dashboardData.CustomerTypeStatistics.Count == 0) return;

            this.CustomerTypeFormsPlot.Plot.Clear();
            var pie = this.CustomerTypeFormsPlot.Plot.AddPie(dashboardData.CustomerTypeStatistics.Values.Select(v => (double)v).ToArray());
            pie.SliceLabels = dashboardData.CustomerTypeStatistics.Keys.ToArray();
            pie.Explode = true;
            this.CustomerTypeFormsPlot.Plot.Legend(location: ScottPlot.Alignment.UpperRight);
            this.CustomerTypeFormsPlot.Refresh();
        }
        #endregion // Dashboard

        private Customer? GetCurrentSelectedCustomer()
        {
            return this.dataGridViewCustomer.CurrentRow?.DataBoundItem as Customer;
        }

        private Employee? GetCurrentSelectedEmployee()
        {
            return this.dataGridViewEmployee.CurrentRow?.DataBoundItem as Employee;
        }

        private Trainee? GetCurrentSelectedTrainee()
        {
            return this.dataGridViewTrainee.CurrentRow?.DataBoundItem as Trainee;
        }
    }
}

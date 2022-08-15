using contact_manager.Presenters.Employees;

namespace contact_manager.Views.Employees
{
    public partial class EmployeeDetailDialog : Form, IEmployeeDetailDialog
    {
        private EmployeeDetailPresenter? presenter;

        #region FormProperties

        public string? FirstName
        {
            get => this.TxtFirstName.Text;
            set => this.TxtFirstName.Text = value;
        }

        //TODO Properties ergänzen

        #endregion

        public EmployeeDetailDialog()
        {
            this.InitializeComponent();
        }

        public void SetPresenter(EmployeeDetailPresenter employeeDetailPresenter)
        {
            this.presenter = employeeDetailPresenter;
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            this.presenter?.Save();
        }
    }
}

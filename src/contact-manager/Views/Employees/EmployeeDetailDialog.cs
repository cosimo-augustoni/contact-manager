using contact_manager.Models.Data;
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

        public Salutation Salutation
        {
            get; set;
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

        private void EmployeeDetailDialog_Load(object sender, EventArgs e)
        {

        }

        private void DateTimePickerBirthDate_ValueChanged(object sender, EventArgs e)
        {
            // Todo: klären, ob dies für alle so in ordnung ist
            // wird verwendet, um das Datum leer zuzulassen
            DateTimePickerBirthDate.CustomFormat = "dd-MM-yyyy";
        }

        private void DateTimePickerBirthDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Escape)
            {
                DateTimePickerBirthDate.CustomFormat = " ";
            }
        }

        // todo: für Postalcode control auch masked textbox verwenden?
    }
}

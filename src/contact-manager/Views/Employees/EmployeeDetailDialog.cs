using contact_manager.Models.Data;
using contact_manager.Presenters.Employees;

namespace contact_manager.Views.Employees
{
    public partial class EmployeeDetailDialog : Form, IEmployeeDetailDialog
    {
        private EmployeeDetailPresenter? presenter;

        #region FormProperties

        public string? EmployeeNumber
        {
            get => this.TxtEmployeeNumber.Text;
            set => this.TxtEmployeeNumber.Text = value;
        }

        public Salutation Salutation
        {
            get => (Salutation)this.CmbSalutation.SelectedValue;
            set => this.CmbSalutation.SelectedValue = value;
        }

        public string? FirstName
        {
            get => this.TxtFirstName.Text;
            set => this.TxtFirstName.Text = value;
        }

        public string? LastName
        {
            get => this.TxtLastname.Text;
            set => this.TxtLastname.Text = value;
        }

        public string? Title
        {
            get => this.TxtTitle.Text;
            set => this.TxtTitle.Text = value;
        }

        public State State
        {
            get => (State)this.CmbState.SelectedValue;
            set => this.CmbState.SelectedValue = value;
        }

        public Sex Sex
        {
            get => (Sex)this.CmbSex.SelectedValue;
            set => this.CmbSex.SelectedValue = value;
        }

        public string? AHV13
        {
            get => this.MTxtAHV13.Text;
            set => this.MTxtAHV13.Text = value;
        }

        public DateTime? DateOfBirth
        {
            get => this.DateTimePickerDateOfBirth.Value != DateTimePicker.MinimumDateTime ? this.DateTimePickerDateOfBirth.Value : null;
            set
            {
                if (value == null)
                {
                    this.DateTimePickerDateOfBirth.CustomFormat = "";
                    this.DateTimePickerDateOfBirth.Value = DateTimePicker.MinimumDateTime.Date;
                }
                else
                {
                    this.DateTimePickerDateOfBirth.CustomFormat = "dd.MM.yyyy";
                    this.DateTimePickerDateOfBirth.Value = value.Value.Date;
                }
            }
        }

        public string? Nationality
        {
            get => this.TxtNationality.Text;
            set => this.TxtNationality.Text = value;
        }

        public string? StreetName
        {
            get => this.TxtStreetName.Text;
            set => this.TxtStreetName.Text = value;
        }

        public string? StreetNumber
        {
            get => this.TxtStreetNumber.Text;
            set => this.TxtStreetNumber.Text = value;
        }

        public string? ZipCode
        {
            get => this.TxtZipCode.Text;
            set => this.TxtZipCode.Text = value;
        }

        public string? City
        {
            get => this.TxtCity.Text;
            set => this.TxtCity.Text = value;
        }

        public string? EMailAddress
        {
            get => this.TxtEMailAddress.Text;
            set => this.TxtEMailAddress.Text = value;
        }

        public string? PhoneNumberPrivate
        {
            get => this.TxtPhoneNumberPrivate.Text;
            set => this.TxtPhoneNumberPrivate.Text = value;
        }

        public string? PhoneNumberMobile
        {
            get => this.TxtPhoneNumberMobile.Text;
            set => this.TxtPhoneNumberMobile.Text = value;
        }

        public string? PhoneNumberBusiness
        {
            get => this.TxtPhoneNumberBusiness.Text;
            set => this.TxtPhoneNumberBusiness.Text = value;
        }

        public string? FaxNumber
        {
            get => this.TxtFaxNumber.Text;
            set => this.TxtFaxNumber.Text = value;
        }

        public string? Department
        {
            get => this.TxtDeparment.Text;
            set => this.TxtDeparment.Text = value;
        }

        public DateTime EntranceDate
        {
            get => this.DatePickerEntranceDate.Value;
            set => this.DatePickerEntranceDate.Value = value.Date;
        }

        public DateTime? ExitDate
        {
            get => this.DatePickerExitDate.Value != DateTimePicker.MinimumDateTime ? this.DatePickerExitDate.Value : null;
            set
            {
                if (value == null)
                {
                    this.DatePickerExitDate.CustomFormat = "";
                    this.DatePickerExitDate.Value = DateTimePicker.MinimumDateTime.Date;
                }
                else
                {
                    this.DatePickerExitDate.CustomFormat = "dd.MM.yyyy";
                    this.DatePickerExitDate.Value = value.Value.Date;
                }
            }
        }

        public int Employment
        {
            get => (int)this.NumEmployment.Value;
            set => this.NumEmployment.Value = value;
        }

        public string? Role
        {
            get => this.TxtRole.Text;
            set => this.TxtRole.Text = value;
        }

        public int CadreLevel
        {
            get => (int)this.NumCadreLevel.Value;
            set => this.NumCadreLevel.Value = value;
        }

        #endregion

        public EmployeeDetailDialog()
        {
            this.InitializeComponent();
            this.CmbSalutation.SetDataSource<Salutation>();
            this.CmbSex.SetDataSource<Sex>();
            this.CmbState.SetDataSource<State>();
        }

        public void InitializeMode()
        {
            var isEnabled = !this.presenter?.IsReadOnly ?? false;
            var isNewMode = this.presenter?.IsNewMode ?? false;
            CmdSave.Enabled = isEnabled;
            CmdCancel.Enabled = isEnabled && !isNewMode;
            CmdChangeStatus.Enabled = isEnabled && !isNewMode;
            CmdProtocol.Enabled = !isNewMode;

            // ToDo: auslagern?
            if (isNewMode)
            {
                State = State.Active;
            }

            GrpAddress.Enabled = isEnabled && State == State.Active;
            GrpPersonalData.Enabled = isEnabled && State == State.Active;
            GrpContactData.Enabled = isEnabled && State == State.Active;
            GrpEmploymentData.Enabled = isEnabled && State == State.Active;

            CmdChangeStatus.Text = State == State.Active ? "Deaktivieren" : "Aktivieren";
        }

        public void SetPresenter(EmployeeDetailPresenter employeeDetailPresenter)
        {
            this.presenter = employeeDetailPresenter;
            // todo: noch auslagern
            // todo: als Property erstellen?
            var isEnabled = !this.presenter?.IsReadOnly ?? false;

            this.GrpPersonalData.Enabled = isEnabled;
            this.GrpAddress.Enabled = isEnabled;
            this.GrpEmploymentData.Enabled = isEnabled;
            this.GrpContactData.Enabled = isEnabled;
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            this.presenter?.Save();
        }

        private void CmdProtocol_Click(object sender, EventArgs e)
        {
            this.presenter?.OpenHistoryDialog();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            // ToDo: cancel (wieder die daten von anfang an anzeigen?)
            // wie soll es sich beim Abbrechen verhalten (auch für Customer noch einbauen)
        }

        private void CmdChangeStatus_Click(object sender, EventArgs e)
        {
            this.presenter?.ChangeStatus();
            InitializeMode();
        }
    }
}

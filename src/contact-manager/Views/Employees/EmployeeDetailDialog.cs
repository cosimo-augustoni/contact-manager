using contact_manager.Models.Data;
using contact_manager.Presenters.Employees;
using contact_manager.Views.Validation;

namespace contact_manager.Views.Employees
{
    public partial class EmployeeDetailDialog : Form, IEmployeeDetailDialog
    {
        private EmployeeDetailPresenter? _presenter;
        private readonly EmployeeValidator _employeeValidator;

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
            get { return this.MTxtAHV13.MaskFull ? this.MTxtAHV13.Text : ""; }
            set => this.MTxtAHV13.Text = value;
        }

        public DateTime? DateOfBirth
        {
            get => this.DateTimePickerDateOfBirth.Value != DateTimePicker.MinimumDateTime ? this.DateTimePickerDateOfBirth.Value : null;
            set
            {
                if (value == null)
                {
                    this.DateTimePickerDateOfBirth.CustomFormat = " ";
                    this.DateTimePickerDateOfBirth.Format = DateTimePickerFormat.Custom;
                    this.DateTimePickerDateOfBirth.Value = DateTimePicker.MinimumDateTime;
                }
                else
                {
                    this.DateTimePickerDateOfBirth.Format = DateTimePickerFormat.Short;
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
                    this.DatePickerExitDate.CustomFormat = " ";
                    this.DatePickerExitDate.Format = DateTimePickerFormat.Custom;
                    this.DatePickerExitDate.Value = DateTimePicker.MinimumDateTime;
                }
                else
                {
                    this.DatePickerExitDate.Format = DateTimePickerFormat.Short;
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
            this._employeeValidator = new EmployeeValidator(EmployeeErrorProvider, this);
        }

        public void InitializeMode()
        {
            var isEnabled = !this._presenter?.IsReadOnly ?? false;
            var isNewMode = this._presenter?.IsNewMode ?? false;
            CmdSave.Enabled = isEnabled;
            CmdChangeStatus.Enabled = isEnabled && !isNewMode;
            CmdProtocol.Enabled = !isNewMode;

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
            this._presenter = employeeDetailPresenter;
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if (_employeeValidator.Validate())
            {
                this._presenter?.Save();
            }
            else
            {
                MessageBox.Show("Fehler beim Speichern" + Environment.NewLine
                    + "Kontrollien Sie die Eingaben und versuchen Sie es erneut.", "Speichern", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdProtocol_Click(object sender, EventArgs e)
        {
            this._presenter?.OpenHistoryDialog();
        }

        private void CmdChangeStatus_Click(object sender, EventArgs e)
        {
            this._presenter?.ChangeStatus();
            InitializeMode();
        }

        private void TxtFirstName_TextChanged(object sender, EventArgs e)
        {
            EmployeeErrorProvider.SetError(TxtFirstName, null);
        }

        private void TxtLastname_TextChanged(object sender, EventArgs e)
        {
            EmployeeErrorProvider.SetError(TxtLastname, null);
        }

        private void TxtStreetName_TextChanged(object sender, EventArgs e)
        {
            EmployeeErrorProvider.SetError(TxtStreetName, null);
        }

        private void TxtZipCode_TextChanged(object sender, EventArgs e)
        {
            EmployeeErrorProvider.SetError(TxtZipCode, null);
        }

        private void TxtCity_TextChanged(object sender, EventArgs e)
        {
            EmployeeErrorProvider.SetError(TxtCity, null);
        }

        private void MTxtAHV13_TextChanged(object sender, EventArgs e)
        {
            EmployeeErrorProvider.SetError(MTxtAHV13, null);
        }

        private void DateTimePickerDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            if (this.DateOfBirth != null)
                this.DateTimePickerDateOfBirth.Format = DateTimePickerFormat.Short;

            EmployeeErrorProvider.SetError(DateTimePickerDateOfBirth, null);
        }

        private void DatePickerExitDate_ValueChanged(object sender, EventArgs e)
        {
            if (this.ExitDate != null)
                this.DatePickerExitDate.Format = DateTimePickerFormat.Short;

            EmployeeErrorProvider.SetError(DatePickerExitDate, null);
        }

        private void DatePickerEntranceDate_ValueChanged(object sender, EventArgs e)
        {
            EmployeeErrorProvider.SetError(DatePickerExitDate, null);
        }

        private void TxtEMailAddress_TextChanged(object sender, EventArgs e)
        {
            EmployeeErrorProvider.SetError(TxtEMailAddress, null);
        }

        private void TxtPhoneNumberPrivate_TextChanged(object sender, EventArgs e)
        {
            EmployeeErrorProvider.SetError(TxtPhoneNumberPrivate, null);
            EmployeeErrorProvider.SetError(TxtEMailAddress, null);
        }

        private void TxtPhoneNumberMobile_TextChanged(object sender, EventArgs e)
        {
            EmployeeErrorProvider.SetError(TxtPhoneNumberMobile, null);
            EmployeeErrorProvider.SetError(TxtEMailAddress, null);
        }

        private void TxtPhoneNumberBusiness_TextChanged(object sender, EventArgs e)
        {
            EmployeeErrorProvider.SetError(TxtPhoneNumberBusiness, null);
            EmployeeErrorProvider.SetError(TxtEMailAddress, null);
        }

        private void TxtFaxNumber_TextChanged(object sender, EventArgs e)
        {
            EmployeeErrorProvider.SetError(TxtFaxNumber, null);
            EmployeeErrorProvider.SetError(TxtEMailAddress, null);
        }

        private void TxtZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private void DatePickerExitDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                this.ExitDate = null;
        }

        private void DatePickerDateOfBirth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                this.DateOfBirth = null;
        }
    }
}

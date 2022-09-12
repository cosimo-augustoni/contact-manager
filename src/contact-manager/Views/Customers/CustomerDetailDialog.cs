using contact_manager.Models.Data;
using contact_manager.Presenters.Customers;
using contact_manager.Views.Validation;

namespace contact_manager.Views.Customers
{
    public partial class CustomerDetailDialog : Form, ICustomerDetailDialog
    {
        private CustomerDetailPresenter? presenter;
        private readonly CustomerValidator _customerValidator;

        #region FormProperties

        public string? CustomerNumber
        {
            get => this.TxtCustomerNumber.Text;
            set => this.TxtCustomerNumber.Text = value;
        }

        public Salutation Salutation
        {
            get => (Salutation)this.CmbSalutation.SelectedValue;
            set => this.CmbSalutation.SelectedValue = value;
        }

        public string CustomerDisplayText
        {
            get { return CustomerNumber + " - " + LastName + " " + FirstName; }
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
        public CustomerType CustomerType
        {
            get => (CustomerType)this.CmbCustomerType.SelectedValue;
            set => this.CmbCustomerType.SelectedValue = value;
        }

        public string? CompanyName
        {
            get => this.TxtCompanyName.Text;
            set => this.TxtCompanyName.Text = value;
        }

        public string? CompanyContact
        {
            get => this.TxtCompanyContact.Text;
            set => this.TxtCompanyContact.Text = value;
        }
        public string? CompanyAddress
        {
            get => this.TxtCompanyAddress.Text;
            set => this.TxtCompanyAddress.Text = value;
        }
        #endregion

        public CustomerDetailDialog()
        {
            this.InitializeComponent();
            this.CmbSalutation.SetDataSource<Salutation>();
            this.CmbCustomerType.SetDataSource<CustomerType>();
            this.CmbSex.SetDataSource<Sex>();
            this.CmbState.SetDataSource<State>();
            this._customerValidator = new CustomerValidator(CustomerErrorProvider, this);
        }

        public void SetPresenter(CustomerDetailPresenter customerDetailPresenter)
        {
            this.presenter = customerDetailPresenter;
        }

        public void InitializeMode()
        {
            var isEnabled = !this.presenter?.IsReadOnly ?? false;
            var isNewMode = this.presenter?.IsNewMode ?? false;
            CmdSave.Enabled = isEnabled;
            CmdCancel.Enabled = isEnabled && !isNewMode;
            CmdChangeStatus.Enabled = isEnabled && !isNewMode;
            CmdShowCustomerNotes.Enabled = !isNewMode;
            CmdProtocol.Enabled = !isNewMode;

            if (isNewMode)
            {
                State = State.Active;
            }

            GrpAddress.Enabled = isEnabled && State == State.Active;
            GrpPersonalData.Enabled = isEnabled && State == State.Active;
            GrpContactData.Enabled = isEnabled && State == State.Active;
            GrpCustomerData.Enabled = isEnabled && State == State.Active;

            CmdChangeStatus.Text = State == State.Active ? "Deaktivieren" : "Aktivieren";
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            // ToDo npa: rückmeldung, dass das speichern erfolgreich war?

            if (_customerValidator.Validate())
            {
                this.presenter?.Save();
                CmdProtocol.Enabled = true;
            }
            else
            {
                MessageBox.Show("Fehler beim Speichern" + Environment.NewLine
                    + "Kontrollien Sie die Eingaben und versuchen Sie es erneut.", "Speichern", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            // ToDo: falls noch nicht gespeichert fragen, ob die Änderungen verworfen werden sollen
            this.Close();
        }

        private void TxtZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private void CustomerDetailDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            // todo: prüfen, ob änderungen vorhanden sind
        }

        private void CmdProtocol_Click(object sender, EventArgs e)
        {
            presenter?.OpenHistoryDialog();
        }

        private void CmdShowCustomerNotes_Click(object sender, EventArgs e)
        {
            this.presenter?.OpenCustomerNotesDialog(CustomerDisplayText);
        }

        private void CmdChangeStatus_Click(object sender, EventArgs e)
        {
            this.presenter?.ChangeStatus();
            InitializeMode();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            // todo: daten in Maske auf default zurücksetzen bei neu
            // und bei bearbeiten sollen die Werte vor der bearbeitung angezeigt werden (sofern noch nicht gespeichert)
            // auch beim Mitarbeiter
        }

        private void TxtFirstName_TextChanged(object sender, EventArgs e)
        {
            CustomerErrorProvider.SetError(TxtFirstName, null);
        }

        private void TxtLastname_TextChanged(object sender, EventArgs e)
        {
            CustomerErrorProvider.SetError(TxtLastname, null);
        }

        private void TxtStreetName_TextChanged(object sender, EventArgs e)
        {
            CustomerErrorProvider.SetError(TxtStreetName, null);
        }

        private void TxtZipCode_TextChanged(object sender, EventArgs e)
        {
            CustomerErrorProvider.SetError(TxtZipCode, null);
        }

        private void MTxtAHV13_TextChanged(object sender, EventArgs e)
        {
            CustomerErrorProvider.SetError(MTxtAHV13, null);
        }

        private void DateTimePickerDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            if (this.DateOfBirth != null)
                this.DateTimePickerDateOfBirth.Format = DateTimePickerFormat.Short;

            CustomerErrorProvider.SetError(DateTimePickerDateOfBirth, null);
        }

        private void TxtCity_TextChanged(object sender, EventArgs e)
        {
            CustomerErrorProvider.SetError(TxtCity, null);
        }

        private void TxtEMailAddress_TextChanged(object sender, EventArgs e)
        {
            CustomerErrorProvider.SetError(TxtEMailAddress, null);
        }

        private void TxtPhoneNumberPrivate_TextChanged(object sender, EventArgs e)
        {
            CustomerErrorProvider.SetError(TxtPhoneNumberPrivate, null);
            CustomerErrorProvider.SetError(TxtEMailAddress, null);
        }

        private void TxtPhoneNumberMobile_TextChanged(object sender, EventArgs e)
        {
            CustomerErrorProvider.SetError(TxtPhoneNumberMobile, null);
            CustomerErrorProvider.SetError(TxtEMailAddress, null);
        }

        private void TxtPhoneNumberBusiness_TextChanged(object sender, EventArgs e)
        {
            CustomerErrorProvider.SetError(TxtPhoneNumberBusiness, null);
            CustomerErrorProvider.SetError(TxtEMailAddress, null);
        }

        private void TxtFaxNumber_TextChanged(object sender, EventArgs e)
        {
            CustomerErrorProvider.SetError(TxtFaxNumber, null);
            CustomerErrorProvider.SetError(TxtEMailAddress, null);
        }

        private void DatePickerDateOfBirth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                this.DateOfBirth = null;
        }
    }
}

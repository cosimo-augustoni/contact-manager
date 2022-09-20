using contact_manager.Models.Data;
using contact_manager.Presenters.Customers;
using contact_manager.Views.Validation;

namespace contact_manager.Views.Customers
{
    public partial class CustomerDetailDialog : Form, ICustomerDetailDialog
    {
        private CustomerDetailPresenter? _presenter;
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
            this._presenter = customerDetailPresenter;
        }

        public void InitializeMode()
        {
            var isEnabled = !this._presenter?.IsReadOnly ?? false;
            var isNewMode = this._presenter?.IsNewMode ?? false;
            CmdSave.Enabled = isEnabled;
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
            if (_customerValidator.Validate())
            {
                this._presenter?.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show("Fehler beim Speichern" + Environment.NewLine
                    + "Kontrollien Sie die Eingaben und versuchen Sie es erneut.", "Speichern", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CustomerDetailDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(this._presenter?.HasUnsavedChanges() ?? false)) return;

            var closeDialogResult = MessageBox.Show(
                "Es gibt ungespeicherte Änderungen, wollen sie diese speichern?",
                "Ungespeicherte Änderungen",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning
            );

            if (closeDialogResult == DialogResult.Yes)
            {
                if (this._customerValidator.Validate())
                    this._presenter?.Save();
                else
                    e.Cancel = true;
            }
            if (closeDialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void CmdProtocol_Click(object sender, EventArgs e)
        {
            _presenter?.OpenHistoryDialog();
        }

        private void CmdShowCustomerNotes_Click(object sender, EventArgs e)
        {
            this._presenter?.OpenCustomerNotesDialog(CustomerDisplayText);
        }

        private void CmdChangeStatus_Click(object sender, EventArgs e)
        {
            this._presenter?.ChangeStatus();
            InitializeMode();
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

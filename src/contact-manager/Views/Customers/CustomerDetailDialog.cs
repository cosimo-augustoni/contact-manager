using contact_manager.Models.Data;
using contact_manager.Models.Data.Customer;
using contact_manager.Presenters.Customers;
using contact_manager.Views.Customers.CustomerNotes;

namespace contact_manager.Views.Customers
{
    public partial class CustomerDetailDialog : Form, ICustomerDetailDialog
    {
        private CustomerDetailPresenter? presenter;

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
                    this.DateTimePickerDateOfBirth.Value = DateTimePicker.MinimumDateTime;
                }
                else
                {
                    this.DateTimePickerDateOfBirth.CustomFormat = "dd.MM.yyyy";
                    this.DateTimePickerDateOfBirth.Value = value.Value;
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
        public CustomerType CustomerType {
            get => (CustomerType)this.CmbCustomerType.SelectedValue;
            set => this.CmbCustomerType.SelectedValue = value;
        }

        public string? CompanyName
        {
            get => this.TxtCompanyName.Text;
            set => this.TxtCompanyName.Text = value;
        }

        public string? CompanyContact {
            get => this.TxtCompanyContact.Text;
            set => this.TxtCompanyContact.Text = value;
        }
        public string? CompanyAddress {
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
            CmdCancel.Enabled = isEnabled;
            CmdChangeStatus.Enabled = isEnabled && !isNewMode;
            CmdShowCustomerNotes.Enabled = !isNewMode;
            CmdProtocol.Enabled = !isNewMode;

            // ToDo: auslagern?
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
            this.presenter?.Save();
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            // ToDo: falls noch nicht gespeichert fragen, ob die Änderungen verworfen werden sollen
            this.Close();
        }

    // ToDo: wie kann man neue Notizen hinzufügen?
    // ToDo: evtl. mit tabs arbeiten?
    // wird ansonsten evtl. etwas zu unübersichtlich
    // dies evtl. für die notizen, dann könnten wir dort wie eine übersicht machen wie auf der Hauptmaske

    private void TxtPostalCode_KeyPress(object sender, KeyPressEventArgs e) {
      // ToDo: lassen wir nur zahlen zu?
      // also nur schweizer adressen? => evt. masked-textbox verwenden?
      e.Handled = !Char.IsDigit(e.KeyChar);
    }

        private void CustomerDetailDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            // todo: prüfen, ob änderungen vorhanden sind
        }

        private void CmdProtocol_Click(object sender, EventArgs e)
        {
            // ToDo: protokollierung customer
        }

        private void CmdShowCustomerNotes_Click(object sender, EventArgs e)
        {
            this.presenter?.OpenCustomerNotesDialog();
        }

        private void CmdChangeStatus_Click(object sender, EventArgs e)
        {
            this.presenter?.ChangeStatus();
            InitializeMode();
        }
    }
}

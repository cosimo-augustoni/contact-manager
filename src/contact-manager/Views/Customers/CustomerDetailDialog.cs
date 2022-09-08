using System.Net.Mail;
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
            // todo: muss nochmals angeschaut werden
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
                DateOfBirth = null;
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

            // ToDo: validation aufrufen
            if (Validate())
            {
                this.presenter?.Save();
            }
            else
            {
                MessageBox.Show("Fehler beim Speichern" + Environment.NewLine + "Kontrollien Sie die Eingaben und versuchen Sie es erneut.", "Speichern", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            // ToDo: falls noch nicht gespeichert fragen, ob die Änderungen verworfen werden sollen
            this.Close();
        }

        private bool Validate()
        {
            List<Control> controlsWithError = new List<Control>();
            CustomerErrorProvider.Clear();

            ValidateSalutation(controlsWithError);
            ValidateFirstName(controlsWithError);
            ValidateLastName(controlsWithError);
            ValidateDateOfBirth(controlsWithError);
            ValidateStreetName(controlsWithError);
            ValidateZipCode(controlsWithError);
            ValidateCity(controlsWithError);
            VaidateEMailAddress(controlsWithError);

            var firstControlWithError = controlsWithError.FirstOrDefault();
            if (firstControlWithError != null)
            {
                firstControlWithError.Focus();
            }

            return !controlsWithError.Any();
        }

        private void ValidateSalutation(List<Control> controlsWithError)
        {
            if (Salutation == Salutation.None)
            {
                CustomerErrorProvider.SetError(CmbSalutation, "Wählen Sie eine Anrede.");
                controlsWithError.Add(CmbSalutation);
            }
        }

        private void ValidateFirstName(List<Control> controlsWithError)
        {
            if (string.IsNullOrWhiteSpace(FirstName))
            {
                CustomerErrorProvider.SetError(TxtFirstName, "Geben Sie einen Vornamen ein.");
                controlsWithError.Add(TxtFirstName);
            }
        }

        private void ValidateLastName(List<Control> controlsWithError)
        {
            if (string.IsNullOrWhiteSpace(LastName))
            {
                CustomerErrorProvider.SetError(TxtLastname, "Geben Sie einen Nachnamen ein.");
                controlsWithError.Add(TxtLastname);
            }
        }
        private void ValidateDateOfBirth(List<Control> controlsWithError)
        {
            if (!DateOfBirth.HasValue || DateOfBirth == DateTimePicker.MinimumDateTime)
            {
                CustomerErrorProvider.SetError(DateTimePickerDateOfBirth, "Geben Sie das Geburtsdatum ein.");
                controlsWithError.Add(DateTimePickerDateOfBirth);
            }
        }
            
        private void ValidateStreetName(List<Control> controlsWithError)
        {
            if (string.IsNullOrWhiteSpace(StreetName)) {
                CustomerErrorProvider.SetError(TxtStreetName, "Geben Sie die Strasse ein.");
                controlsWithError.Add(TxtStreetName);
            }
        }

        private void ValidateZipCode(List<Control> controlsWithError)
        {
            if (string.IsNullOrWhiteSpace(ZipCode))
            {
                CustomerErrorProvider.SetError(TxtZipCode, "Geben Sie die PLZ ein.");
                controlsWithError.Add(TxtZipCode);
            }
        }

        private void ValidateCity(List<Control> controlsWithError)
        {
            if (string.IsNullOrEmpty(City))
            {
                CustomerErrorProvider.SetError(TxtCity, "Geben Sie die Ortschaft ein.");
                controlsWithError.Add(TxtCity);
            }
        }

        private void VaidateEMailAddress(List<Control> controlsWithError)
        {
            if (!String.IsNullOrEmpty(EMailAddress))
            {
                // todo: email auf gültiges format prüfen
                try
                {
                    MailAddress mailAddress = new MailAddress(EMailAddress);
                }
                catch (FormatException)
                {
                    CustomerErrorProvider.SetError(TxtEMailAddress, "E-Mail hat ein ungültiges Format.");
                    controlsWithError.Add(TxtEMailAddress);
                }
            }
        }

        private void ValidateAHV13(List<Control> controlsWithError)
        {
            if (!String.IsNullOrEmpty(AHV13))
            {
                // ToDo npa: auf gültiges format prüfen

                //public String validateSsn(String ssn)
                //{
                //    String error = null;
                //    if (!StringT.isNullOrEmpty(ssn))
                //    {
                //        if (ssn.length() != SSN_VALID_LENGTH)
                //        {
                //            error = _resourceProvider.getString(R.string.ErrorInvalidSsn);
                //        }
                //        else
                //        {
                //            String newSsn = ssn.replace(".", "");
                //            if (StringT.isNullOrWhiteSpace(newSsn) || !StringT.isEAN13Valid(newSsn))
                //            {
                //                error = _resourceProvider.getString(R.string.ErrorInvalidSsn);
                //            }
                //        }
                //    }

                //    return error;
                //}

            }
        }

        public static Boolean isEAN13Valid(String value)
        {
            value = value.Replace(".", "");
            if (value.Length != 12)
            {
                return false;
            }

            return true;
            //char givenCheckDigit = value.charAt(EAN_13_POSITION_CHECK_DIGIT);
            //if (givenCheckDigit == EAN_13_INVALID_CHECK_DIGIT)
            //{
            //    return false;
            //}
            //Character calculatedCheckDigit = getEAN13CheckDigit(value.substring(0, EAN_13_LENGTH_DIGITS));
            //return givenCheckDigit == calculatedCheckDigit;
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

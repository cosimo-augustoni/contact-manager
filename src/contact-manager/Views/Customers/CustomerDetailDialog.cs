using System.Net.Mail;
using System.Text.RegularExpressions;
using contact_manager.Models.Data;
using contact_manager.Models.Data.Customer;
using contact_manager.Presenters.Customers;
using contact_manager.Views.Customers.CustomerNotes;

namespace contact_manager.Views.Customers
{
    public partial class CustomerDetailDialog : Form, ICustomerDetailDialog
    {
        private CustomerDetailPresenter? presenter;
        // todo: noch auslagern, dass es für den MA auch verwendet werden kann
        string _pattern = @"^(\+?)(\d{2,4})(\s?)(\-?)((\(0\))?)(\s?)(\d{2})(\s?)(\-?)(\d{3})(\s?)(\-?)(\d{2})(\s?)(\-?)(\d{2})";

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
            // ToDo: protokollierung customer
            // nur ermöglichen, wenn keine Änderungen in der Maske vorhanden sind
        }

        private void CmdShowCustomerNotes_Click(object sender, EventArgs e)
        {
            // ToDo npa: nur ermöglichen, wenn keine Änderungen vorhanden sind
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


        //----------------------------------------------------------------------------------------------------
        #region Validation
        //----------------------------------------------------------------------------------------------------

        // todo: in separate klasse auslagern?

        private new bool Validate()
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
            ValidateAHV13(controlsWithError);
            ValidateContactInformations(controlsWithError);
            ValidateEMailAddress(controlsWithError);
            ValidatePhoneNumberPrivate(controlsWithError);
            ValidatePhoneNumberBusiness(controlsWithError);
            ValidatePhoneNumberMobile(controlsWithError);
            ValidateFaxNumber(controlsWithError);

            var firstControlWithError = controlsWithError.FirstOrDefault();
            if (firstControlWithError != null)
            {
                firstControlWithError.Focus();
            }

            return !controlsWithError.Any();
        }

        private void ValidateContactInformations(List<Control> controlsWithError)
        {
            // ToDo: prüfen, dass mindestens eine Kontaktinformation angegeben wurde
            var emailHasValue = !string.IsNullOrWhiteSpace(EMailAddress);
            var phonePrivateHasValue = !string.IsNullOrWhiteSpace(PhoneNumberPrivate);
            var mobilePhoneHasValue = !string.IsNullOrWhiteSpace(PhoneNumberMobile);
            var phoneBusinessHasValue = !string.IsNullOrWhiteSpace(PhoneNumberBusiness);
            var faxHasValue = !string.IsNullOrWhiteSpace(FaxNumber);

            if (!emailHasValue && !phonePrivateHasValue && !mobilePhoneHasValue && !phoneBusinessHasValue && !faxHasValue)
            {
                String error = "Geben Sie mindestens eine Kontaktinformation an.";
                CustomerErrorProvider.SetError(TxtEMailAddress, error);
                controlsWithError.Add(TxtEMailAddress);
            }
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
            // ToDo npa: der Wert im Geburtsdatum ist immer der heutige tag bei neu
            if (!DateOfBirth.HasValue || DateOfBirth == DateTimePicker.MinimumDateTime)
            {
                CustomerErrorProvider.SetError(DateTimePickerDateOfBirth, "Geben Sie das Geburtsdatum ein.");
                controlsWithError.Add(DateTimePickerDateOfBirth);
            }
            else if (DateOfBirth.Value.Date > DateTime.Today)
            {
                CustomerErrorProvider.SetError(DateTimePickerDateOfBirth, "Das Geburtsdatum darf nicht in der Zukunft liegen.");
                controlsWithError.Add(DateTimePickerDateOfBirth);
            }
        }

        private void ValidateStreetName(List<Control> controlsWithError)
        {
            if (string.IsNullOrWhiteSpace(StreetName))
            {
                CustomerErrorProvider.SetError(TxtStreetName, "Geben Sie die Strasse ein.");
                controlsWithError.Add(TxtStreetName);
            }
        }

        private void ValidateZipCode(List<Control> controlsWithError)
        {
            if (string.IsNullOrWhiteSpace(ZipCode) || ZipCode.Length < 4)
            {
                CustomerErrorProvider.SetError(TxtZipCode, "Geben Sie eine gültige PLZ ein.");
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

        private void ValidateEMailAddress(List<Control> controlsWithError)
        {
            if (!String.IsNullOrEmpty(EMailAddress))
            {
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

        private void ValidatePhoneNumberPrivate(List<Control> controlsWithError)
        {
            if (String.IsNullOrEmpty(PhoneNumberPrivate) || Regex.IsMatch(PhoneNumberPrivate, _pattern))
            {
                CustomerErrorProvider.SetError(TxtPhoneNumberPrivate, null);
            }
            else
            {
                CustomerErrorProvider.SetError(TxtPhoneNumberPrivate, "Format der Telefonnummer ist ungültig.");
                controlsWithError.Add(TxtPhoneNumberPrivate);
            }
        }

        private void ValidatePhoneNumberMobile(List<Control> controlsWithError)
        {
            if (String.IsNullOrEmpty(PhoneNumberMobile) || Regex.IsMatch(PhoneNumberMobile, _pattern))
            {
                CustomerErrorProvider.SetError(TxtPhoneNumberMobile, null);
            }
            else
            {
                CustomerErrorProvider.SetError(TxtPhoneNumberMobile, "Format der Mobile-Nr. ist ungültig.");
                controlsWithError.Add(TxtPhoneNumberMobile);
            }
        }

        private void ValidatePhoneNumberBusiness(List<Control> controlsWithError)
        {
            if (String.IsNullOrEmpty(PhoneNumberBusiness) || Regex.IsMatch(PhoneNumberBusiness, _pattern))
            {
                CustomerErrorProvider.SetError(TxtPhoneNumberBusiness, null);
            }
            else
            {
                CustomerErrorProvider.SetError(TxtPhoneNumberBusiness, "Format der Telefonnummer ist ungültig.");
                controlsWithError.Add(TxtPhoneNumberBusiness);
            }
        }

        private void ValidateFaxNumber(List<Control> controlsWithError)
        {
            if (String.IsNullOrEmpty(FaxNumber) || Regex.IsMatch(FaxNumber, _pattern))
            {
                CustomerErrorProvider.SetError(TxtFaxNumber, null);
            }
            else
            {
                CustomerErrorProvider.SetError(TxtFaxNumber, "Format der Fax-Nummer ist ungültig.");
                controlsWithError.Add(TxtPhoneNumberBusiness);
            }
        }

        public static Boolean bIsEAN13Valid(String sValue)
        {
            sValue = sValue.Replace(".", "");
            if (sValue.Length != 13)
            {
                return false;
            }
            Char checkdigit = GetEAN13Checkdigit(sValue.Substring(0, 12));
            if (checkdigit == sValue[12])
            {
                return true;
            }
            return false;
        }
        //----------------------------------------------------------------------------------------------------
        /// <summary>Returns the EAN 13 check digit or ' ' if string is not a valid EAN 13.</summary>
        /// <param name="sValue">The EAN 13.</param>
        /// <returns>Check digit if [EAN 13 is valid]; otherwise, ' '.</returns>
        public static Char GetEAN13Checkdigit(String sValue)
        {
            sValue = sValue.Replace(".", "");
            if (sValue.Length != 12)
            {
                return ' ';
            }
            return GetGS1CheckDigit(sValue);
        }
        //----------------------------------------------------------------------------------------------------
        /// <summary>Returns the check digit for GS1 data structures or ' ' if string is not an entirely numeric.</summary>
        /// <param name="value">The GS1 data structure.</param>
        /// <returns>Check digit if string is valid, otherwise ' '.</returns>
        public static Char GetGS1CheckDigit(String value)
        {
            if (value.Any(c => c - '0' < 0 || c - '0' > 9))
            {
                return ' ';
            }
            Int32 factor = 3;
            Int32 sum = 0;
            for (Int32 index = value.Length; index > 0; index--)
            {
                Int32 digit = value[index - 1] - '0';
                sum += digit * factor;
                factor = 4 - factor;
            }
            Int32 checkDigit = ((10 - (sum % 10)) % 10 + '0');
            return (Char)checkDigit;
        }

        private void ValidateAHV13(List<Control> controlsWithError)
        {
            if (!String.IsNullOrEmpty(AHV13))
            {
                if (!bIsEAN13Valid(AHV13))
                {
                    CustomerErrorProvider.SetError(MTxtAHV13, "AHV-Nr. hat ungültiges Format.");
                    controlsWithError.Add(MTxtAHV13);
                }
            }
        }

        private void CmbSalutation_SelectedValueChanged(object sender, EventArgs e)
        {
            CustomerErrorProvider.SetError(CmbSalutation, null);
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
        }

        private void TxtPhoneNumberMobile_TextChanged(object sender, EventArgs e)
        {
            CustomerErrorProvider.SetError(TxtPhoneNumberMobile, null);
        }

        private void TxtPhoneNumberBusiness_TextChanged(object sender, EventArgs e)
        {
            CustomerErrorProvider.SetError(TxtPhoneNumberBusiness, null);
        }

        private void TxtFaxNumber_TextChanged(object sender, EventArgs e)
        {
            CustomerErrorProvider.SetError(TxtFaxNumber, null);
        }
        #endregion // Validation
    }
}

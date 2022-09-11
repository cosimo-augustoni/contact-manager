using System.Net.Mail;
using System.Text.RegularExpressions;
using contact_manager.Models.Data;
using contact_manager.Views.Customers;

namespace contact_manager.Models.Domain.Validation
{
    internal class CustomerValidator
    {

        private readonly ErrorProvider _errorProvider;
        private readonly List<Control> _controlsWithError = new List<Control>();
        private readonly CustomerDetailDialog _dialog;
        // todo: noch auslagern, dass es für den MA auch verwendet werden kann
        private readonly string _phoneNumberPattern =
            @"^(\+?)(\d{2,4})(\s?)(\-?)((\(0\))?)(\s?)(\d{2})(\s?)(\-?)(\d{3})(\s?)(\-?)(\d{2})(\s?)(\-?)(\d{2})";

        public CustomerValidator(ErrorProvider errorProvider, CustomerDetailDialog customerDetailDialog)
        {
            this._errorProvider = errorProvider;
            this._dialog = customerDetailDialog;
        }

        public bool Validate()
        {
            _controlsWithError.Clear();
            _errorProvider.Clear();

            ValidateSalutation();
            ValidateFirstName();
            ValidateLastName();
            ValidateDateOfBirth();
            ValidateStreetName();
            ValidateZipCode();
            ValidateCity();
            ValidateAHV13();
            ValidateContactInformations();
            ValidateEMailAddress();
            ValidatePhoneNumberPrivate();
            ValidatePhoneNumberBusiness();
            ValidatePhoneNumberMobile();
            ValidateFaxNumber();

            var firstControlWithError = _controlsWithError.FirstOrDefault();
            if (firstControlWithError != null)
            {
                firstControlWithError.Focus();
            }

            return firstControlWithError == null;
        }


        private void ValidateSalutation()
        {
            if (_dialog.Salutation == Salutation.None)
            {
                _errorProvider.SetError(_dialog.CmbSalutation, "Wählen Sie eine Anrede");
                _controlsWithError.Add(_dialog.CmbSalutation);
            }
        }

        private void ValidateContactInformations()
        {
            var emailHasValue = !string.IsNullOrWhiteSpace(_dialog.EMailAddress);
            var phonePrivateHasValue = !string.IsNullOrWhiteSpace(_dialog.PhoneNumberPrivate);
            var mobilePhoneHasValue = !string.IsNullOrWhiteSpace(_dialog.PhoneNumberMobile);
            var phoneBusinessHasValue = !string.IsNullOrWhiteSpace(_dialog.PhoneNumberBusiness);
            var faxHasValue = !string.IsNullOrWhiteSpace(_dialog.FaxNumber);

            if (!emailHasValue && !phonePrivateHasValue && !mobilePhoneHasValue && !phoneBusinessHasValue && !faxHasValue)
            {
                String error = "Geben Sie mindestens eine Kontaktinformation an.";
                _errorProvider.SetError(_dialog.TxtEMailAddress, error);
                _controlsWithError.Add(_dialog.TxtEMailAddress);
            }
        }

        private void ValidateFirstName()
        {
            if (string.IsNullOrWhiteSpace(_dialog.FirstName))
            {
                _errorProvider.SetError(_dialog.TxtFirstName, "Geben Sie einen Vornamen ein.");
                _controlsWithError.Add(_dialog.TxtFirstName);
            }
        }

        private void ValidateLastName()
        {
            if (string.IsNullOrWhiteSpace(_dialog.LastName))
            {
                _errorProvider.SetError(_dialog.TxtLastname, "Geben Sie einen Nachnamen ein.");
                _controlsWithError.Add(_dialog.TxtLastname);
            }
        }
        private void ValidateDateOfBirth()
        {
            if (!_dialog.DateOfBirth.HasValue || _dialog.DateOfBirth == DateTimePicker.MinimumDateTime)
            {
                _errorProvider.SetError(_dialog.DateTimePickerDateOfBirth, "Geben Sie das Geburtsdatum ein.");
                _controlsWithError.Add(_dialog.DateTimePickerDateOfBirth);
            }
            else if (_dialog.DateOfBirth.Value.Date > DateTime.Today)
            {
                _errorProvider.SetError(_dialog.DateTimePickerDateOfBirth, "Das Geburtsdatum darf nicht in der Zukunft liegen.");
                _controlsWithError.Add(_dialog.DateTimePickerDateOfBirth);
            }
        }

        private void ValidateStreetName()
        {
            if (string.IsNullOrWhiteSpace(_dialog.StreetName))
            {
                _errorProvider.SetError(_dialog.TxtStreetName, "Geben Sie die Strasse ein.");
                _controlsWithError.Add(_dialog.TxtStreetName);
            }
        }

        private void ValidateZipCode()
        {
            if (string.IsNullOrWhiteSpace(_dialog.ZipCode) || _dialog.ZipCode.Length < 4)
            {
                _errorProvider.SetError(_dialog.TxtZipCode, "Geben Sie eine gültige PLZ ein.");
                _controlsWithError.Add(_dialog.TxtZipCode);
            }
        }

        private void ValidateCity()
        {
            if (string.IsNullOrEmpty(_dialog.City))
            {
                _errorProvider.SetError(_dialog.TxtCity, "Geben Sie die Ortschaft ein.");
                _controlsWithError.Add(_dialog.TxtCity);
            }
        }

        private void ValidateEMailAddress()
        {
            if (!String.IsNullOrEmpty(_dialog.EMailAddress))
            {
                try
                {
                    MailAddress mailAddress = new MailAddress(_dialog.EMailAddress);
                }
                catch (FormatException)
                {
                    _errorProvider.SetError(_dialog.TxtEMailAddress, "E-Mail hat ein ungültiges Format.");
                    _controlsWithError.Add(_dialog.TxtEMailAddress);
                }
            }
        }

        private void ValidatePhoneNumberPrivate()
        {
            if (String.IsNullOrEmpty(_dialog.PhoneNumberPrivate) || Regex.IsMatch(_dialog.PhoneNumberPrivate, _phoneNumberPattern))
            {
                return;
            }
            else
            {
                _errorProvider.SetError(_dialog.TxtPhoneNumberPrivate, "Format der Telefonnummer ist ungültig.");
                _controlsWithError.Add(_dialog.TxtPhoneNumberPrivate);
            }
        }

        private void ValidatePhoneNumberMobile()
        {
            if (String.IsNullOrEmpty(_dialog.PhoneNumberMobile) || Regex.IsMatch(_dialog.PhoneNumberMobile, _phoneNumberPattern))
            {
                return;
            }
            else
            {
                _errorProvider.SetError(_dialog.TxtPhoneNumberMobile, "Format der Mobile-Nr. ist ungültig.");
                _controlsWithError.Add(_dialog.TxtPhoneNumberMobile);
            }
        }

        private void ValidatePhoneNumberBusiness()
        {
            if (String.IsNullOrEmpty(_dialog.PhoneNumberBusiness) || Regex.IsMatch(_dialog.PhoneNumberBusiness, _phoneNumberPattern))
            {
                return;
            }
            else
            {
                _errorProvider.SetError(_dialog.TxtPhoneNumberBusiness, "Format der Telefonnummer ist ungültig.");
                _controlsWithError.Add(_dialog.TxtPhoneNumberBusiness);
            }
        }

        private void ValidateFaxNumber()
        {
            if (String.IsNullOrEmpty(_dialog.FaxNumber) || Regex.IsMatch(_dialog.FaxNumber, _phoneNumberPattern))
            {
                return;
            }
            else
            {
                _errorProvider.SetError(_dialog.TxtFaxNumber, "Format der Fax-Nummer ist ungültig.");
                _controlsWithError.Add(_dialog.TxtPhoneNumberBusiness);
            }
        }

        private static Boolean IsEAN13Valid(String value)
        {
            value = value.Replace(".", "");
            if (value.Length != 13)
            {
                return false;
            }
            Char checkdigit = GetEAN13Checkdigit(value.Substring(0, 12));
            if (checkdigit == value[12])
            {
                return true;
            }
            return false;
        }

        //----------------------------------------------------------------------------------------------------
        /// <summary>Returns the EAN 13 check digit or ' ' if string is not a valid EAN 13.</summary>
        /// <param name="sValue">The EAN 13.</param>
        /// <returns>Check digit if [EAN 13 is valid]; otherwise, ' '.</returns>
        private static Char GetEAN13Checkdigit(String sValue)
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
        private static Char GetGS1CheckDigit(String value)
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

        private void ValidateAHV13()
        {
            if (!String.IsNullOrEmpty(_dialog.AHV13))
            {
                if (!IsEAN13Valid(_dialog.AHV13))
                {
                    _errorProvider.SetError(_dialog.MTxtAHV13, "AHV-Nr. hat ungültiges Format.");
                    _controlsWithError.Add(_dialog.MTxtAHV13);
                }
            }
        }

    }
}

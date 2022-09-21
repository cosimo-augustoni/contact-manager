using contact_manager.Views.Employees;

namespace contact_manager.Views.Validation
{
    internal class TraineeValidator
    {

        private readonly ErrorProvider _errorProvider;
        private readonly List<Control> _controlsWithError = new List<Control>();
        private readonly TraineeDetailDialog _dialog;

        public TraineeValidator(ErrorProvider errorProvider, TraineeDetailDialog traineeDetailDialog)
        {
            this._errorProvider = errorProvider;
            this._dialog = traineeDetailDialog;
        }

        public bool Validate()
        {
            _controlsWithError.Clear();
            _errorProvider.Clear();

            ValidateFirstName();
            ValidateLastName();
            ValidateDateOfBirth();
            ValidateStreetName();
            ValidateZipCode();
            ValidateCity();
            ValidateAHV13();
            ValidateExitDate();
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

        private void ValidateContactInformations()
        {
            if (!Validator.ExistsAtLeastOneContactInformation(_dialog.EMailAddress, _dialog.PhoneNumberPrivate,
                _dialog.PhoneNumberMobile, _dialog.PhoneNumberBusiness, _dialog.FaxNumber))
            {
                String error = "Geben Sie mindestens eine Kontaktinformation an.";
                _errorProvider.SetError(_dialog.TxtEMailAddress, error);
                _controlsWithError.Add(_dialog.TxtEMailAddress);
            }
        }

        private void ValidateFirstName()
        {
            if (!Validator.IsFirstNameValid(_dialog.FirstName))
            {
                _errorProvider.SetError(_dialog.TxtFirstName, "Geben Sie einen Vornamen ein.");
                _controlsWithError.Add(_dialog.TxtFirstName);
            }
        }

        private void ValidateLastName()
        {
            if (!Validator.IsLastNameValid(_dialog.LastName))
            {
                _errorProvider.SetError(_dialog.TxtLastname, "Geben Sie einen Nachnamen ein.");
                _controlsWithError.Add(_dialog.TxtLastname);
            }
        }
        private void ValidateDateOfBirth()
        {
            if (Validator.ExistsDateOfBirth(_dialog.DateOfBirth))
            {
                if (Validator.IsDateOfBirthIsInFuture(_dialog.DateOfBirth))
                {
                    _errorProvider.SetError(_dialog.DateTimePickerDateOfBirth, "Das Geburtsdatum darf nicht in der Zukunft liegen.");
                    _controlsWithError.Add(_dialog.DateTimePickerDateOfBirth);
                }
            }
            else
            {
                _errorProvider.SetError(_dialog.DateTimePickerDateOfBirth, "Geben Sie das Geburtsdatum ein.");
                _controlsWithError.Add(_dialog.DateTimePickerDateOfBirth);
            }
        }

        private void ValidateStreetName()
        {
            if (!Validator.IsStreetNameValid(_dialog.StreetName))
            {
                _errorProvider.SetError(_dialog.TxtStreetName, "Geben Sie die Strasse ein.");
                _controlsWithError.Add(_dialog.TxtStreetName);
            }
        }

        private void ValidateZipCode()
        {
            if (!Validator.IsZipCodeValid(_dialog.ZipCode))
            {
                _errorProvider.SetError(_dialog.TxtZipCode, "Geben Sie eine gültige PLZ ein.");
                _controlsWithError.Add(_dialog.TxtZipCode);
            }
        }

        private void ValidateCity()
        {
            if (!Validator.IsCityValid(_dialog.City))
            {
                _errorProvider.SetError(_dialog.TxtCity, "Geben Sie die Ortschaft ein.");
                _controlsWithError.Add(_dialog.TxtCity);
            }
        }

        private void ValidateEMailAddress()
        {
            if (!Validator.IsMailAddressValid(_dialog.EMailAddress))
            {
                _errorProvider.SetError(_dialog.TxtEMailAddress, "E-Mail hat ein ungültiges Format.");
                _controlsWithError.Add(_dialog.TxtEMailAddress);
            }
        }

        private void ValidatePhoneNumberPrivate()
        {
            if (!Validator.IsPhoneNumberValid(_dialog.PhoneNumberPrivate))
            {
                _errorProvider.SetError(_dialog.TxtPhoneNumberPrivate, "Format der Telefonnummer ist ungültig.");
                _controlsWithError.Add(_dialog.TxtPhoneNumberPrivate);
            }
        }

        private void ValidatePhoneNumberMobile()
        {
            if (!Validator.IsPhoneNumberValid(_dialog.PhoneNumberMobile))
            {
                _errorProvider.SetError(_dialog.TxtPhoneNumberMobile, "Format der Mobile-Nr. ist ungültig.");
                _controlsWithError.Add(_dialog.TxtPhoneNumberMobile);
            }
        }

        private void ValidatePhoneNumberBusiness()
        {
            if (!Validator.IsPhoneNumberValid(_dialog.PhoneNumberBusiness))
            {
                _errorProvider.SetError(_dialog.TxtPhoneNumberBusiness, "Format der Telefonnummer ist ungültig.");
                _controlsWithError.Add(_dialog.TxtPhoneNumberBusiness);
            }
        }

        private void ValidateFaxNumber()
        {
            if (!Validator.IsPhoneNumberValid(_dialog.FaxNumber))
            {
                _errorProvider.SetError(_dialog.TxtFaxNumber, "Format der Fax-Nummer ist ungültig.");
                _controlsWithError.Add(_dialog.TxtPhoneNumberBusiness);
            }
        }

        private void ValidateAHV13()
        {
            if (!Validator.IsAHV13Valid(_dialog.AHV13))
            {
                _errorProvider.SetError(_dialog.MTxtAHV13, "AHV-Nr. hat ungültiges Format.");
                _controlsWithError.Add(_dialog.MTxtAHV13);
            }
        }

        private void ValidateExitDate()
        {
            if (_dialog.ExitDate.HasValue && _dialog.ExitDate < _dialog.EntranceDate)
            {
                _errorProvider.SetError(_dialog.DatePickerExitDate, "Austrittsdatum darf nicht vor dem Eintrittsdatum sein.");
                _controlsWithError.Add(_dialog.DatePickerExitDate);
            }
        }
    }
}

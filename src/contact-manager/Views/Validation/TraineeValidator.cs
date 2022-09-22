using contact_manager.Models.Domain;
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
            this._controlsWithError.Clear();
            this._errorProvider.Clear();

            this.ValidateFirstName();
            this.ValidateLastName();
            this.ValidateDateOfBirth();
            this.ValidateStreetName();
            this.ValidateZipCode();
            this.ValidateCity();
            this.ValidateAHV13();
            this.ValidateExitDate();
            this.ValidateContactInformations();
            this.ValidateEMailAddress();
            this.ValidatePhoneNumberPrivate();
            this.ValidatePhoneNumberBusiness();
            this.ValidatePhoneNumberMobile();
            this.ValidateFaxNumber();
            this.ValidateYearOfApprenticeship();

            var firstControlWithError = this._controlsWithError.FirstOrDefault();
            if (firstControlWithError != null)
            {
                firstControlWithError.Focus();
            }

            return firstControlWithError == null;
        }

        private void ValidateContactInformations()
        {
            if (!Validator.ExistsAtLeastOneContactInformation(this._dialog.EMailAddress, this._dialog.PhoneNumberPrivate,
                this._dialog.PhoneNumberMobile, this._dialog.PhoneNumberBusiness, this._dialog.FaxNumber))
            {
                String error = "Geben Sie mindestens eine Kontaktinformation an.";
                this._errorProvider.SetError(this._dialog.TxtEMailAddress, error);
                this._controlsWithError.Add(this._dialog.TxtEMailAddress);
            }
        }

        private void ValidateFirstName()
        {
            if (!Validator.IsFirstNameValid(this._dialog.FirstName))
            {
                this._errorProvider.SetError(this._dialog.TxtFirstName, "Geben Sie einen Vornamen ein.");
                this._controlsWithError.Add(this._dialog.TxtFirstName);
            }
        }

        private void ValidateLastName()
        {
            if (!Validator.IsLastNameValid(this._dialog.LastName))
            {
                this._errorProvider.SetError(this._dialog.TxtLastname, "Geben Sie einen Nachnamen ein.");
                this._controlsWithError.Add(this._dialog.TxtLastname);
            }
        }
        private void ValidateDateOfBirth()
        {
            if (Validator.ExistsDateOfBirth(this._dialog.DateOfBirth))
            {
                if (Validator.IsDateOfBirthIsInFuture(this._dialog.DateOfBirth))
                {
                    this._errorProvider.SetError(this._dialog.DateTimePickerDateOfBirth, "Das Geburtsdatum darf nicht in der Zukunft liegen.");
                    this._controlsWithError.Add(this._dialog.DateTimePickerDateOfBirth);
                }
            }
            else
            {
                this._errorProvider.SetError(this._dialog.DateTimePickerDateOfBirth, "Geben Sie das Geburtsdatum ein.");
                this._controlsWithError.Add(this._dialog.DateTimePickerDateOfBirth);
            }
        }

        private void ValidateStreetName()
        {
            if (!Validator.IsStreetNameValid(this._dialog.StreetName))
            {
                this._errorProvider.SetError(this._dialog.TxtStreetName, "Geben Sie die Strasse ein.");
                this._controlsWithError.Add(this._dialog.TxtStreetName);
            }
        }

        private void ValidateZipCode()
        {
            if (!Validator.IsZipCodeValid(this._dialog.ZipCode))
            {
                this._errorProvider.SetError(this._dialog.TxtZipCode, "Geben Sie eine gültige PLZ ein.");
                this._controlsWithError.Add(this._dialog.TxtZipCode);
            }
        }

        private void ValidateCity()
        {
            if (!Validator.IsCityValid(this._dialog.City))
            {
                this._errorProvider.SetError(this._dialog.TxtCity, "Geben Sie die Ortschaft ein.");
                this._controlsWithError.Add(this._dialog.TxtCity);
            }
        }

        private void ValidateEMailAddress()
        {
            if (!Validator.IsMailAddressValid(this._dialog.EMailAddress))
            {
                this._errorProvider.SetError(this._dialog.TxtEMailAddress, "E-Mail hat ein ungültiges Format.");
                this._controlsWithError.Add(this._dialog.TxtEMailAddress);
            }
        }

        private void ValidatePhoneNumberPrivate()
        {
            if (!Validator.IsPhoneNumberValid(this._dialog.PhoneNumberPrivate))
            {
                this._errorProvider.SetError(this._dialog.TxtPhoneNumberPrivate, "Format der Telefonnummer ist ungültig.");
                this._controlsWithError.Add(this._dialog.TxtPhoneNumberPrivate);
            }
        }

        private void ValidatePhoneNumberMobile()
        {
            if (!Validator.IsPhoneNumberValid(this._dialog.PhoneNumberMobile))
            {
                this._errorProvider.SetError(this._dialog.TxtPhoneNumberMobile, "Format der Mobile-Nr. ist ungültig.");
                this._controlsWithError.Add(this._dialog.TxtPhoneNumberMobile);
            }
        }

        private void ValidatePhoneNumberBusiness()
        {
            if (!Validator.IsPhoneNumberValid(this._dialog.PhoneNumberBusiness))
            {
                this._errorProvider.SetError(this._dialog.TxtPhoneNumberBusiness, "Format der Telefonnummer ist ungültig.");
                this._controlsWithError.Add(this._dialog.TxtPhoneNumberBusiness);
            }
        }

        private void ValidateFaxNumber()
        {
            if (!Validator.IsPhoneNumberValid(this._dialog.FaxNumber))
            {
                this._errorProvider.SetError(this._dialog.TxtFaxNumber, "Format der Fax-Nummer ist ungültig.");
                this._controlsWithError.Add(this._dialog.TxtPhoneNumberBusiness);
            }
        }

        private void ValidateAHV13()
        {
            if (!Validator.IsAHV13Valid(this._dialog.AHV13))
            {
                this._errorProvider.SetError(this._dialog.MTxtAHV13, "AHV-Nr. hat ungültiges Format.");
                this._controlsWithError.Add(this._dialog.MTxtAHV13);
            }
        }

        private void ValidateExitDate()
        {
            if (this._dialog.ExitDate.HasValue && this._dialog.ExitDate < this._dialog.EntranceDate)
            {
                this._errorProvider.SetError(this._dialog.DatePickerExitDate, "Austrittsdatum darf nicht vor dem Eintrittsdatum sein.");
                this._controlsWithError.Add(this._dialog.DatePickerExitDate);
            }
        }

        private void ValidateYearOfApprenticeship()
        {
            if (this._dialog.YearsOfApprenticeship < this._dialog.CurrentYearOfApprenticeship)
            {
                this._errorProvider.SetError(this._dialog.NumCurrentYearOfApprenticeship, "Lehrjahr darf nicht grösser als die Lehrdauer sein.");
                this._controlsWithError.Add(this._dialog.NumCurrentYearOfApprenticeship);
            }
        }
    }
}

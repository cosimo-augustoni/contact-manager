using System.Net.Mail;
using System.Text.RegularExpressions;

namespace contact_manager.Models.Domain
{
    internal class Validator
    {
        public static readonly string PhoneNumberPattern =
            @"^(\+?)(\d{2,4})(\s?)(\-?)((\(0\))?)(\s?)(\d{2})(\s?)(\-?)(\d{3})(\s?)(\-?)(\d{2})(\s?)(\-?)(\d{2})";

        public static bool IsZipCodeValid(string? zipCode)
        {
            return !string.IsNullOrWhiteSpace(zipCode) && zipCode.Length == 4;
        }

        public static bool IsStreetNameValid(string? streetName)
        {
            return !string.IsNullOrWhiteSpace(streetName);
        }

        public static bool IsCityValid(string? city)
        {
            return !string.IsNullOrWhiteSpace(city);
        }

        public static bool IsFirstNameValid(string? firstName)
        {
            return !string.IsNullOrWhiteSpace(firstName);
        }

        public static bool IsLastNameValid(string? lastName)
        {
            return !string.IsNullOrWhiteSpace(lastName);
        }

        public static bool ExistsAtLeastOneContactInformation(string? eMailAddress, string? phoneNumberPrivate, string? phoneNumberMobile,
            string? phoneNumberBusiness, string? faxNumber)
        {
            var emailHasValue = !string.IsNullOrWhiteSpace(eMailAddress);
            var phonePrivateHasValue = !string.IsNullOrWhiteSpace(phoneNumberPrivate);
            var mobilePhoneHasValue = !string.IsNullOrWhiteSpace(phoneNumberMobile);
            var phoneBusinessHasValue = !string.IsNullOrWhiteSpace(phoneNumberBusiness);
            var faxHasValue = !string.IsNullOrWhiteSpace(faxNumber);

            return emailHasValue || phonePrivateHasValue || mobilePhoneHasValue || phoneBusinessHasValue || faxHasValue;
        }

        public static bool ExistsDateOfBirth(DateTime? dateOfBirth)
        {
            return dateOfBirth.HasValue && dateOfBirth.Value > DateTimePicker.MinimumDateTime;
        }

        public static bool IsValidDate(string? dateOfBirth)
        {
            return DateTime.TryParse(dateOfBirth, out _);
        }

        public static bool IsDateOfBirthIsInFuture(DateTime? dateOfBirth)
        {
            return dateOfBirth.HasValue && dateOfBirth > DateTime.Today;
        }

        public static bool IsPhoneNumberValid(string? phoneNumber)
        {
            return String.IsNullOrEmpty(phoneNumber) || Regex.IsMatch(phoneNumber, PhoneNumberPattern);
        }

        public static bool IsMailAddressValid(string? emailAddress)
        {
            if (!String.IsNullOrEmpty(emailAddress))
            {
                try
                {
                    var mailAddress = new MailAddress(emailAddress);
                }
                catch (FormatException)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsAHV13Valid(string? value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return true;
            }

            value = value.Replace(".", "");
            if (value.Length != 13)
            {
                return false;
            }
            var checkdigit = GetEAN13Checkdigit(value.Substring(0, 12));
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
            var factor = 3;
            var sum = 0;
            for (var index = value.Length; index > 0; index--)
            {
                var digit = value[index - 1] - '0';
                sum += digit * factor;
                factor = 4 - factor;
            }
            var checkDigit = ((10 - (sum % 10)) % 10 + '0');
            return (Char)checkDigit;
        }
    }
}

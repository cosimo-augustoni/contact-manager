using contact_manager.Models.Data;
using CsvHelper.Configuration;

namespace contact_manager.Models.Domain.CsvImport
{
    internal class PersonMap<T> : ClassMap<T> where T : Person
    {
        public PersonMap()
        {
            this.Map(m => m.FirstName).Name("Vorname").Validate(field => Validator.IsFirstNameValid(field.Field));
            this.Map(m => m.LastName).Name("Nachname").Validate(field => Validator.IsLastNameValid(field.Field));
            this.Map(m => m.City).Name("Ort").Validate(field => Validator.IsStreetNameValid(field.Field));
            this.Map(m => m.ZipCode).Name("PLZ").Validate(field => Validator.IsZipCodeValid(field.Field));
            this.Map(m => m.StreetName).Name("Strasse").Validate(field => Validator.IsStreetNameValid(field.Field));
            this.Map(m => m.EMailAddress).Name("Email").Validate(field => Validator.IsMailAddressValid(field.Field) && !string.IsNullOrWhiteSpace(field.Field));
            this.Map(m => m.PhoneNumberMobile).Name("Mobilnummer").Validate(field => Validator.IsPhoneNumberValid(field.Field));
            this.Map(m => m.DateOfBirth).Name("Geburtsdatum").Validate(field => Validator.IsValidDate(field.Field)).TypeConverterOption.Format("dd.MM.yyyy");
            this.Map(m => m.Sex).Name("Geschlecht").TypeConverter<CustomEnumConverter<Sex>>();
            this.Map(m => m.Salutation).Name("Anrede").TypeConverter<CustomEnumConverter<Salutation>>();
            this.Map(m => m.Nationality).Name("Nationalität");
            this.Map(m => m.StreetNumber).Name("Strassennr");
            this.Map(m => m.State).Default(State.Active, true);
        }
    }

}

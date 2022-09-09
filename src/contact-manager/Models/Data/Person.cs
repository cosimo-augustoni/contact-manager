namespace contact_manager.Models.Data
{
    public class Person : IObjectIdentifier
    {
        public long Id { get; init; }
        public Salutation Salutation { get; init; }
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
        public DateTime? DateOfBirth { get; init; }
        public Sex Sex { get; init; }
        public string? Title { get; init; }
        public State State { get; init; }
        public string? AHV13 { get; init; }
        public string? Nationality { get; init; }
        public string? City { get; init; }
        public string? ZipCode { get; init; }
        public string? StreetName { get; init; }
        public string? StreetNumber { get; init; }
        public string? EMailAddress { get; init; }
        public string? PhoneNumberPrivate { get; init; }
        public string? PhoneNumberMobile { get; init; }
        public string? PhoneNumberBusiness { get; init; }
        public string? FaxNumber { get; init; }
    }
}

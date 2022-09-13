using System.ComponentModel.DataAnnotations;

namespace contact_manager.Models.Data
{
    public class Person : IObjectIdentifier
    {
        [Display(Name = "Id")]
        public long Id { get; set; }
        [Display(Name = "Anrede")]
        public Salutation Salutation { get; init; }
        [Display(Name = "Vorname")]
        public string? FirstName { get; init; }
        [Display(Name = "Nachname")]
        public string? LastName { get; init; }
        [Display(Name = "Geburtsdatum")]
        public DateTime? DateOfBirth { get; init; }
        [Display(Name = "Geschlecht")]
        public Sex Sex { get; init; }
        [Display(Name = "Titel")]
        public string? Title { get; init; }
        [Display(Name = "Status")]
        public State State { get; init; }
        [Display(Name = "AHV-Nummer")]
        public string? AHV13 { get; init; }
        [Display(Name = "Nationalität")]
        public string? Nationality { get; init; }
        [Display(Name = "Ort")]
        public string? City { get; init; }
        [Display(Name = "PLZ")]
        public string? ZipCode { get; init; }
        [Display(Name = "Strasse")]
        public string? StreetName { get; init; }
        [Display(Name = "Strassen Nr.")]
        public string? StreetNumber { get; init; }
        [Display(Name = "E-Mail")]
        public string? EMailAddress { get; init; }
        [Display(Name = "Tel. Privat")]
        public string? PhoneNumberPrivate { get; init; }
        [Display(Name = "Mobile-Nr.")]
        public string? PhoneNumberMobile { get; init; }
        [Display(Name = "Tel. Geschäft")]
        public string? PhoneNumberBusiness { get; init; }
        [Display(Name = "Fax Geschäft")]
        public string? FaxNumber { get; init; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace contact_manager.Models.Data
{
    public class Customer : Person
    {
        [Display(Name = "Kunden-Nr")]
        public string CustomerNumber => this.Id.ToString().PadLeft(5, '0');
        [Display(Name = "Firmenname")]
        public string? CompanyName { get; init; }
        [Display(Name = "Kundentyp")]
        public CustomerType CustomerType { get; init; }
        [Display(Name = "Firmenkontakt")]
        public string? CompanyContact { get; init; }
        [Display(Name = "Geschäftsadresse")]
        public string? CompanyAddress { get; init; }
    }
}

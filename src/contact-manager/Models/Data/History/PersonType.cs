using System.ComponentModel.DataAnnotations;

namespace contact_manager.Models.Data.History
{
    public enum PersonType
    {
        [Display(Name = "Kunde")]
        Customer = 1,
        [Display(Name = "Mitarbeiter")]
        Employee = 2,
        [Display(Name = "Lehrling")]
        Trainee = 3
    }
}

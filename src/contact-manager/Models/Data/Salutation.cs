using System.ComponentModel.DataAnnotations;

namespace contact_manager.Models.Data;

public enum Salutation
{
    [Display(Name = "Keine")]
    None = 0,
    [Display(Name = "Frau")]
    Female = 1,
    [Display(Name = "Herr")]
    Male = 2,
}
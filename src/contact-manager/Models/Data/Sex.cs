using System.ComponentModel.DataAnnotations;

namespace contact_manager.Models.Data;

public enum Sex
{
    [Display(Name = "Nicht Binär")]
    NonBinary = 0,
    [Display(Name = "Weiblich")]
    Female = 1,
    [Display(Name = "Männlich")]
    Male = 2
}
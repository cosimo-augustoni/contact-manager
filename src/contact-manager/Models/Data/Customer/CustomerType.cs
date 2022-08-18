using System.ComponentModel.DataAnnotations;

namespace contact_manager.Models.Data.Customer;

public enum CustomerType
{
    [Display(Name = "A")]
    A = 0,
    [Display(Name = "B")]
    B = 1,
    [Display(Name = "C")]
    C = 2,
    [Display(Name = "D")]
    D = 3,
    [Display(Name = "E")]
    E = 4,
}
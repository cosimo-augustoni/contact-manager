using System.ComponentModel.DataAnnotations;

namespace contact_manager.Models.Data;

public class Trainee : Employee
{
    [Display(Name = "Lehrdauer")]
    public int YearsOfApprenticeship { get; set; }

    [Display(Name = "Lehrjahr")]
    public int CurrentYearOfApprenticeship { get; set; }
}

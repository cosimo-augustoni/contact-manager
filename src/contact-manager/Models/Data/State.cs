using System.ComponentModel.DataAnnotations;

namespace contact_manager.Models.Data;

public enum State
{
    [Display(Name = "Passiv")]
    Passive = 0,
    [Display(Name = "Aktiv")]
    Active = 1,
}
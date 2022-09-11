using System.ComponentModel.DataAnnotations;

namespace contact_manager.Models.Data.Employee;

public class Employee : Person
{
    [Display(Name = "Mitarbeiter-Nr.")]
    public string EmployeeNumber => this.Id.ToString().PadLeft(5, '0');
    [Display(Name = "Abteilung")]
    public string? Department { get; init; }
    [Display(Name = "Eintrittsdatum")]
    public DateTime EntranceDate { get; init; }
    [Display(Name = "Austrittsdatum")]
    public DateTime? ExitDate { get; init; }
    [Display(Name = "Beschäftigungsgrad")]
    public int Employment { get; init; }
    [Display(Name = "Rolle")]
    public string? Role { get; init; }
    [Display(Name = "Kaderstufe")]
    public int CadreLevel { get; init; }
}

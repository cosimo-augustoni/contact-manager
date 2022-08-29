namespace contact_manager.Models.Data.Employee;

public class Employee : Person
{
    public string EmployeeNumber => this.Id.ToString().PadLeft(5, '0');
    public string? Department { get; init; }
    public DateTime EntranceDate { get; init; }
    public DateTime? ExitDate { get; init; }
    public int Employment { get; init; }
    public string? Role { get; init; }
    public int CadreLevel { get; init; }
}

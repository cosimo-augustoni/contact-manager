namespace contact_manager.Views.Employees;

public interface ITraineeDetailDialog : IEmployeeDetailDialog
{
    int YearsOfApprenticeship { get; set; }
    int CurrentYearOfApprenticeship { get; set; }
}

using contact_manager.Models.Data;

namespace contact_manager.Models.Domain.CsvImport;

internal class TraineeMap<T> : EmployeeMap<T> where T : Trainee
{
    public TraineeMap()
    {
        this.Map(m => (m).YearsOfApprenticeship).Name("Lehrdauer");
        this.Map(m => (m).CurrentYearOfApprenticeship).Name("Lehrjahr");
    }
}

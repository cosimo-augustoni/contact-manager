using contact_manager.Models.Data;

namespace contact_manager.Models.Domain.CsvImport
{
    internal class EmployeeMap<T> : PersonMap<T> where T : Employee
    {
        public EmployeeMap()
        {
            this.Map(m => (m).EntranceDate).Name("Eintrittsdatum").TypeConverterOption.Format("dd.MM.yyyy").Default(DateTime.UtcNow, true);
            this.Map(m => (m).Employment).Name("Beschäftigungsgrad").Default(100, true);
            this.Map(m => (m).Department).Name("Abteilung");
            this.Map(m => (m).Role).Name("Rolle");
        }
    }
}

using contact_manager.Models.Data;

namespace contact_manager.Models.Domain.CsvImport
{
    internal class EmployeeMap<T> : PersonMap<T> where T : Employee
    {
        public EmployeeMap()
        {
            Map(m => (m).EntranceDate).Name("Eintrittsdatum").TypeConverterOption.Format("dd.MM.yyyy").Default(DateTime.UtcNow, true);
            Map(m => (m).Employment).Name("Beschäftigungsgrad").Default(100, true);
            Map(m => (m).Department).Name("Abteilung");
            Map(m => (m).Role).Name("Rolle");
        }
    }

}

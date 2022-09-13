using contact_manager.Models.Data;

namespace contact_manager.Models.Domain.CsvImport
{
    public interface ICsvImporter
    {
        IEnumerable<T> ParseCsv<T>(string filePath) where T : Person;
    }
}

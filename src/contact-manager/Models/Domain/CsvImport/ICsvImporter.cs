using contact_manager.Models.Data;

namespace contact_manager.Models.Domain.CsvImport
{
    public interface ICsvImporter
    {
        List<T> ParseCsv<T>(string filePath) where T : Person;
    }
}

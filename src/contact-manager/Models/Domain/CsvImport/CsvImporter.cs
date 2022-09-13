using System.Globalization;
using contact_manager.Models.Data;
using CsvHelper;
using CsvHelper.Configuration;

namespace contact_manager.Models.Domain.CsvImport
{
    internal class CsvImporter : ICsvImporter
    {
        public IEnumerable<T> ParseCsv<T>(string filePath) where T : Person
        {
            if (File.Exists(filePath))
            {
                var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ";",
                    MissingFieldFound = null,
                    HeaderValidated = null,
                    TrimOptions = TrimOptions.Trim,
                };


                using (var streamReader = new StreamReader(filePath))
                using (var csvReader = new CsvReader(streamReader, csvConfig))
                {
                    csvReader.Context.RegisterClassMap<PersonMap<Person>>();

                    csvReader.Context.RegisterClassMap<EmployeeMap<Employee>>();
                    csvReader.Context.RegisterClassMap<CustomerMap<Customer>>();
                    return csvReader.GetRecords<T>().ToList();
                }
            }
            return Array.Empty<T>();
        }
    }

}

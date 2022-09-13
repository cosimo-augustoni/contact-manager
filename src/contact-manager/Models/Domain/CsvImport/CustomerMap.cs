using contact_manager.Models.Data;

namespace contact_manager.Models.Domain.CsvImport
{
    internal class CustomerMap<T> : PersonMap<T> where T : Customer
    {
        public CustomerMap()
        {
            Map(m => (m).CompanyName).Name("Firmenname");
            Map(m => (m).CompanyAddress).Name("Geschäftsadresse");
            Map(m => (m).CustomerType).Name("Kundentyp").TypeConverter<CustomEnumConverter<CustomerType>>();
        }
    }

}

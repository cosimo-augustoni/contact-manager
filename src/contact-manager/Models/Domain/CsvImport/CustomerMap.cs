using contact_manager.Models.Data;

namespace contact_manager.Models.Domain.CsvImport
{
    internal class CustomerMap<T> : PersonMap<T> where T : Customer
    {
        public CustomerMap()
        {
            this.Map(m => (m).CompanyName).Name("Firmenname");
            this.Map(m => (m).CompanyAddress).Name("Geschäftsadresse");
            this.Map(m => (m).CustomerType).Name("Kundentyp").TypeConverter<CustomEnumConverter<CustomerType>>();
        }
    }

}

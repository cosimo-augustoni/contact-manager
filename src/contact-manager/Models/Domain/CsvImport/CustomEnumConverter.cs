using contact_manager.Models.Data;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace contact_manager.Models.Domain.CsvImport
{
    internal class CustomEnumConverter<T> : DefaultTypeConverter
    {
        public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
        {
            if (typeof(T) == typeof(Sex))
            {
                switch (text)
                {
                    case "M":
                        return Sex.Male;
                    case "F":
                        return Sex.Female;
                    default:
                        return Sex.NonBinary;
                }
            }

            if (typeof(T) == typeof(Salutation))
            {
                switch (text)
                {
                    case "Herr":
                        return Salutation.Male;
                    case "Frau":
                        return Salutation.Female;
                    case "Keine":
                        return Salutation.None;
                    default:
                        return Salutation.None;
                }
            }

            if (typeof(T) == typeof(CustomerType))
            {
                if (Enum.TryParse(typeof(CustomerType), text, out var customerTypEnum))
                {
                    return customerTypEnum;
                }
                else
                {
                    return CustomerType.A;
                }
            }

            return new object();

        }

    }

}

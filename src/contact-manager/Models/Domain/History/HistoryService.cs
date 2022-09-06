using System.Reflection;
using contact_manager.Models.Data;
using contact_manager.Models.Data.History;
using contact_manager.Views;

namespace contact_manager.Models.Domain.History
{
    internal class HistoryService : IHistoryService
    {
        private readonly IHistoryStore _historyStore;

        private readonly IDictionary<string, string> _propertyTranslations = new Dictionary<string, string>
        #region Property translations
        {
            {
                "Id", "Id"
            },
            {
                 "Salutation", "Anrede"
            },
            {
                "FirstName", "Vorname"
            },
            {
                "LastName", "Nachname"
            },
            {
                "DateOfBirth", "Geburtsdatum"
            },
            {
                "Sex", "Geschlecht"
            },
            {
                "Title", "Titel"
            },
            {
                "State", "Status"
            },
            {
                "AHV13", "AHV-Nummer"
            },
            {
                "Nationality", "Nationalität"
            },
            {
                "City", "Ort"
            },
            {
                "ZipCode", "PLZ"
            },
            {
                "StreetName", "Strasse"
            },
            {
                "StreetNumber", "Strassen Nr."
            },
            {
                "EMailAddress", "Email"
            },
            {
                "PhoneNumberPrivate", "Tel. Privat"
            },
            {
                "PhoneNumberMobile", "Tel. Mobil"
            },
            {
                "PhoneNumberBusiness", "Tel. Arbeit"
            },
            {
                "FaxNumber", "Fax"
            },
            {
                "EmployeeNumber", "Mitarbeiternr."
            },
            {
                "Department", "Departement"
            },
            {
                "EntranceDate", "Eintrittsdatum"
            },
            {
                "ExitDate", "Austrittsdatum"
            },
            {
                "Employment", "Beschäftigungsgrad"
            },
            {
                "Role", "Funktion"
            },
            {
                "CadreLevel", "Mitarbeiterstufe"
            },
            {
                "CustomerNumber", "Kundennr."
            },
            {
                "CompanyName", "Firmenname"
            },
            {
                "CustomerType", "Kundentyp"
            },
            {
                "YearsOfApprenticeship", "Lehrdauer"
            },
            {
                "CurrentYearOfApprenticeship", "Lehrjahr"
            }
        };

        #endregion
        public HistoryService(IHistoryStore historyStore)
        {
            _historyStore = historyStore;
        }
        public void Add<T>(T personNew, T? personOld = null) where T : Person
        {
            var historyEntry = this.GetDifferences(personNew, personOld);
            historyEntry.Diffs = historyEntry.Diffs.OrderBy(o => o.PropertyName).ToList();
            historyEntry.personType = (personNew is Data.Customer.Customer) ? PersonType.Customer : PersonType.Employee;
            this._historyStore.Add(historyEntry);
        }

        public List<HistoryEntry> Get(long personId, PersonType personType)
        {
            return this._historyStore.Get(personId, personType).OrderByDescending(f => f.TimeStamp).ToList();
        }

        private HistoryEntry GetDifferences<T>(T personNew, T? personOld = null) where T : Person
        {
            var differences = new List<Difference>();

            var historyEntry = new HistoryEntry
            {
                PersonId = personNew.Id,
                TimeStamp = DateTime.Now,
                Diffs = differences
            };

            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in properties)
            {
                var valueNew = this.CleanAndFormatValue(property, personNew);
                var valueOld = this.CleanAndFormatValue(property, personOld);

                var hasDifference = this.HasDifference(valueNew, valueOld);

                if (hasDifference == true)
                {
                    this._propertyTranslations.TryGetValue(property.Name, out var propertyTranslation);

                    var diff = new Difference
                    {
                        PropertyName = propertyTranslation ?? property.Name,
                        ValueNew = valueNew,
                        ValueOld = valueOld
                    };
                    differences.Add(diff);
                }
            }
            return historyEntry;
        }

        private bool HasDifference(object? valueNew, object? valueOld)
        {

            if (valueOld == null && valueNew == null)
            {
                return false;
            }
            if ((valueOld == null && valueNew != null) || (valueOld != null && valueNew == null))
            {
                return true;
            }

            if (!Equals(valueOld, valueNew))
            {
                return true;
            }

            return false;
        }

        private object? CleanAndFormatValue(PropertyInfo property, Person? person = null)
        {
            object? propertyValue = null;

            if (person != null)
            {
                propertyValue = property.GetValue(person);
                var propertyType = property.PropertyType;

                if (propertyValue != null)
                {
                    if (propertyType == typeof(int))
                    {

                        return (int)propertyValue != 0 ? propertyValue : null;
                    }

                    if (propertyType.IsEnum)
                    {

                        return ((Enum)propertyValue).GetDisplayName();
                    }

                    if (propertyType == typeof(string))
                    {

                        return string.IsNullOrWhiteSpace((string)propertyValue) ? null : propertyValue;
                    }

                    if (propertyType == typeof(DateTime))
                    {

                        return ((DateTime)propertyValue).ToLongDateString();
                    }
                }
            }
            return propertyValue;
        }
    }
}

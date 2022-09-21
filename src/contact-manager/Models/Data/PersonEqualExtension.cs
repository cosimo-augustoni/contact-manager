using System.Text.Json;

namespace contact_manager.Models.Data
{
    public static class PersonEqualExtension
    {
        public static bool IsStringEqual<T>(this T person, T otherPerson)
            where T : Person
        {
            return JsonSerializer.Serialize(person).Equals(JsonSerializer.Serialize(otherPerson));
        }
    }
}
using System.Text.Json;

namespace contact_manager.Models.Data;

internal class FilePersonStore<T> : IPersonStore<T> where T : Person
{
    private readonly string dataDirectory = $"{AppDomain.CurrentDomain.BaseDirectory}/Data";

    private readonly string fileName = $"{typeof(T).Name}.json";

    private string FilePath => Path.Combine(this.dataDirectory, this.fileName);

    public List<T> GetAll()
    {
        if (!File.Exists(this.FilePath))
            return new List<T>();

        var jsonString = File.ReadAllText(this.FilePath);
        return JsonSerializer.Deserialize<List<T>>(jsonString) ?? new List<T>();
    }

    public void UpdateOrAdd(T person)
    {
        var persons = this.GetAll();
        var index = persons.FindIndex(p => p.Id == person.Id);
        if (index != -1)
        {
            persons[index] = person;
        }
        else
        {
            persons.Add(person);
        }

        this.Write(persons);
    }

    public void Delete(long id)
    {
        var persons = this.GetAll();
        persons.RemoveAll(p => p.Id == id);
        this.Write(persons);
    }

    private void Write(List<T> persons)
    {
        var jsonString = JsonSerializer.Serialize(persons);
        Directory.CreateDirectory(this.dataDirectory);
        File.WriteAllText(this.FilePath, jsonString);
    }
}

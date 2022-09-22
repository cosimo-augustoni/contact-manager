using System.Text.Json;

namespace contact_manager.Models.Data;

internal class FileStore<T> : IStore<T> where T : IObjectIdentifier
{
    private readonly string _dataDirectory = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/ContactManager/Data";

    private readonly string _fileName = $"{typeof(T).Name}.json";

    private string FilePath => Path.Combine(this._dataDirectory, this._fileName);

    public List<T> GetAll()
    {
        if (!File.Exists(this.FilePath))
            return new List<T>();

        var jsonString = File.ReadAllText(this.FilePath);
        return JsonSerializer.Deserialize<List<T>>(jsonString) ?? new List<T>();
    }

    public void UpdateOrAdd(T entity)
    {
        var entities = this.GetAll();
        var index = entities.FindIndex(p => p.Id == entity.Id);
        if (index != -1)
        {
            entities[index] = entity;
        }
        else
        {
            entities.Add(entity);
        }

        this.Write(entities);
    }

    public void Delete(long id)
    {
        var entities = this.GetAll();
        entities.RemoveAll(p => p.Id == id);
        this.Write(entities);
    }

    private void Write(List<T> entities)
    {
        var jsonString = JsonSerializer.Serialize(entities);
        Directory.CreateDirectory(this._dataDirectory);
        File.WriteAllText(this.FilePath, jsonString);
    }
}

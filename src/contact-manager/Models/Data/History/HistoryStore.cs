using System.Text.Json;

namespace contact_manager.Models.Data.History
{
    internal class HistoryStore : IHistoryStore
    {
        private readonly string _dataDirectory = $"{AppDomain.CurrentDomain.BaseDirectory}/Data";

        private readonly string _fileName = $"History.json";

        private string FilePath => Path.Combine(this._dataDirectory, this._fileName);

        public List<HistoryEntry> Get(long personId, EntityType personType)
        {
            if (!File.Exists(this.FilePath))
                return new List<HistoryEntry>();

            var jsonString = File.ReadAllText(this.FilePath);
            var historyEntries = JsonSerializer.Deserialize<List<HistoryEntry>>(jsonString) ?? new List<HistoryEntry>();

            if (historyEntries.Count > 0)
            {
                return historyEntries.FindAll(f => f.EntityId == personId && f.EntityType == personType);
            }

            return new List<HistoryEntry>();
        }
        public void Add(HistoryEntry historyEntry)
        {
            var historyEntries = this.GetAll();
            historyEntries.Add(historyEntry);
            this.Write(historyEntries);
        }

        private void Write(List<HistoryEntry> historyEntries)
        {
            var jsonString = JsonSerializer.Serialize(historyEntries);
            Directory.CreateDirectory(this._dataDirectory);
            File.WriteAllText(this.FilePath, jsonString);
        }

        private List<HistoryEntry> GetAll()
        {
            if (!File.Exists(this.FilePath))
                return new List<HistoryEntry>();

            var jsonString = File.ReadAllText(this.FilePath);

            return JsonSerializer.Deserialize<List<HistoryEntry>>(jsonString) ?? new List<HistoryEntry>();


        }

    }
}

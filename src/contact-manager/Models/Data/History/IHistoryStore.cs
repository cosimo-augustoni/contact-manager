namespace contact_manager.Models.Data.History
{
    internal interface IHistoryStore
    {
        List<HistoryEntry> Get(long personId, EntityType personType);
        void Add(HistoryEntry variance);
    }
}

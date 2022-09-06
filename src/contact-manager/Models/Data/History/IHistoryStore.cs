namespace contact_manager.Models.Data.History
{
    internal interface IHistoryStore
    {
        List<HistoryEntry> Get(long personId, PersonType personType);
        void Add(HistoryEntry variance);
    }
}

namespace contact_manager.Models.Data.History
{
    public class HistoryEntry
    {
        public long EntityId { get; set; }
        public EntityType EntityType { get; set; }
        public DateTime TimeStamp { get; set; }
        public List<Difference> Diffs { get; set; }

    }
}

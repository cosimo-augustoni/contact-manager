namespace contact_manager.Models.Data.History
{
    public class HistoryEntry
    {
        public long PersonId { get; set; }
        public PersonType personType { get; set; }
        public DateTime TimeStamp { get; set; }
        public List<Difference> Diffs { get; set; }

    }
}

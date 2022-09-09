namespace contact_manager.Models.Data.Customer
{
    public class CustomerNote : IObjectIdentifier
    {
        public long Id { get; init; }

        public string Text { get; init; } = string.Empty;

        public DateTime CreatedAt { get; init; }

        public long CustomerId { get; init; }

        public string CreatedBy { get; init; } = "unbekannt";
    }
}

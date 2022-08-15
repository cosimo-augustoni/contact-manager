namespace contact_manager.Models.Customers.Data
{
    public class CustomerNote
    {
        public string Text { get; init; }

        public DateTime CreationTime { get; init; }

        public long CustomerId { get; init; }
    }
}

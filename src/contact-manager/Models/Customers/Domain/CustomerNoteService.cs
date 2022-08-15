using contact_manager.Models.Customers.Data;

namespace contact_manager.Models.Customers.Domain
{
    internal class CustomerNoteService : ICustomerNoteService
    {
        public List<CustomerNote> GetAllNotesByCustomerId(long customerId)
        {
            throw new NotImplementedException();
        }

        public void CreateNewNote(string text, long customerId)
        {
            throw new NotImplementedException();
        }
    }
}

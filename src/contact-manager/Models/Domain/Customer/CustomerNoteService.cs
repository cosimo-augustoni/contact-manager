using contact_manager.Models.Data.Customer;

namespace contact_manager.Models.Domain.Customer
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

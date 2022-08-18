using contact_manager.Models.Data.Customer;

namespace contact_manager.Models.Domain.Customer;

internal interface ICustomerNoteService
{
    List<CustomerNote> GetAllNotesByCustomerId(long customerId);
    void CreateNewNote(string text, long customerId);
}
using contact_manager.Models.Data.Customer;

namespace contact_manager.Models.Domain.Customer;

public interface ICustomerNoteService
{
    List<CustomerNote> LoadAllNotesByCustomerId(long customerId);
    void CreateNewNote(long customerId, string text, string createdBy);
}

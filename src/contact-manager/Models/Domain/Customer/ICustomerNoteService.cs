
using contact_manager.Models.Data;

namespace contact_manager.Models.Domain;

public interface ICustomerNoteService
{
    List<CustomerNote> LoadAllNotesByCustomerId(long customerId);
    void CreateNewNote(long customerId, string text, string createdBy);
}

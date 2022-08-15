using contact_manager.Models.Customers.Data;

namespace contact_manager.Models.Customers.Domain;

internal interface ICustomerNoteService
{
    List<CustomerNote> GetAllNotesByCustomerId(long customerId);
    void CreateNewNote(string text, long customerId);
}
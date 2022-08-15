using contact_manager.Models.Customers;
using contact_manager.Models.Customers.Data;

namespace contact_manager.Presenters.Customers
{
    internal class CustomerNotesPresenter
    {
        List<CustomerNote> GetAllNotesByCustomerId(long customerId)
        {
            return new List<CustomerNote>();
        }

        void CreateNewNote(string text, long customerId)
        {

        }
    }
}

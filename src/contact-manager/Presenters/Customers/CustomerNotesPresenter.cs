using contact_manager.Models.Data.Customer;

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

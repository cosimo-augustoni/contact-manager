using contact_manager.Models.Data.Customer;
using contact_manager.Presenters.Customers;

namespace contact_manager.Views.Customers.CustomerNotes;

public interface ICustomerNotesView
{
    void SetPresenter(CustomerNotesPresenter notesPresenter);
    string NewNoteText { get; set; }
    void AddNewNoteToHistory(CustomerNote note);
    void ClearAllNotes();
}

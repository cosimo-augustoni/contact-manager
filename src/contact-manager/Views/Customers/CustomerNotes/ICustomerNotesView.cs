using contact_manager.Models.Data;
using contact_manager.Presenters.Customers;

namespace contact_manager.Views.Customers.CustomerNotes;

public interface ICustomerNotesView
{
    void SetPresenter(CustomerNotesPresenter notesPresenter);
    void InitializeMode();
    string NewNoteText { get; set; }
    void AddNewNoteToHistory(CustomerNote note);
    void ClearAllNotes();
    void SetTitle(string customerDisplayText);
}

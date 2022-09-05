using contact_manager.Models.Data.Customer;
using contact_manager.Presenters.Customers;

namespace contact_manager.Views.Customers.CustomerNotes
{
    public partial class CustomerNotesDialog : Form, ICustomerNotesView
    {
        private CustomerNotesPresenter? presenter;

        private readonly Label emptyLabel;

        public CustomerNotesDialog()
        {
            InitializeComponent();
            this.emptyLabel = new Label();
            emptyLabel.Text = "Keine Notizen vorhanden.";
            this.emptyLabel.AutoSize = true;
            this.PnlNotes.Controls.Add(emptyLabel);
        }

        public void SetPresenter(CustomerNotesPresenter notesPresenter)
        {
            this.presenter = notesPresenter;
        }

        public string NewNoteText
        {
            get => this.TxtNewNote.Text;
            set => this.TxtNewNote.Text = value;
        }

        public void AddNewNoteToHistory(CustomerNote note)
        {
            if(this.PnlNotes.Controls.Contains(this.emptyLabel))
                this.PnlNotes.Controls.Remove(this.emptyLabel);

            this.PnlNotes.Controls.Add(new CustomerNoteControl(note.Text, note.CreatedBy, note.CreatedAt));
        }

        public void ClearAllNotes()
        {
            this.PnlNotes.Controls.Clear();
        }

        private void CmdAddNote_Click(object sender, EventArgs e)
        {
            this.presenter?.AddNewNoteFromText();
        }
    }
}

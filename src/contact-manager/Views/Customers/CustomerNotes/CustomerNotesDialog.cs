using contact_manager.Models.Data.Customer;
using contact_manager.Presenters.Customers;

namespace contact_manager.Views.Customers.CustomerNotes
{
    public partial class CustomerNotesDialog : Form, ICustomerNotesView
    {
        private CustomerNotesPresenter? presenter;

        private readonly Label emptyLabel;

        public CustomerNotesDialog(string customerDisplayText)
        {
            InitializeComponent();
            this.emptyLabel = new Label();
            emptyLabel.Text = "Keine Notizen vorhanden.";
            this.emptyLabel.AutoSize = true;
            this.PnlNotes.Controls.Add(emptyLabel);

            this.Text = $"Notizen von Kunde: {customerDisplayText}";
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
            if (ValidateChildren(ValidationConstraints.Enabled)) {
                this.presenter?.AddNewNoteFromText();
            }
            else
            {
                MessageBox.Show("Kontrollieren Sie die Angaben", "Erfassen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //CustomerNoteErrorProvider.Clear();
            //if (string.IsNullOrWhiteSpace(TxtNewNote.Text))
            //{
            //    CustomerNoteErrorProvider.SetError(TxtNewNote, "Geben Sie eine Notiz ein.");
                
            //}
            //else
            //{
            //    this.presenter?.AddNewNoteFromText();
            //}
        }

        private void TxtNewNote_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NewNoteText))
            {
                CustomerNoteErrorProvider.SetError(TxtNewNote, "Geben Sie eine Notiz ein.");
                TxtNewNote.Focus();
                e.Cancel = true;
            }
            else
            {
                CustomerNoteErrorProvider.SetError(TxtNewNote, null);
            }
        }
    }
}

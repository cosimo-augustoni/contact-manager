using contact_manager.Models.Data;
using contact_manager.Presenters.Customers;

namespace contact_manager.Views.Customers.CustomerNotes
{
    public partial class CustomerNotesDialog : Form, ICustomerNotesView
    {
        private CustomerNotesPresenter? _presenter;

        private readonly Label _emptyLabel;

        public CustomerNotesDialog()
        {
            this.InitializeComponent();
            this._emptyLabel = new Label();
            this._emptyLabel.Text = "Keine Notizen vorhanden.";
            this._emptyLabel.AutoSize = true;
            this.PnlNotes.Controls.Add(this._emptyLabel);
        }

        public void SetTitle(string customerDisplayText)
        {
            this.Text = $"Notizen von Kunde: {customerDisplayText}";
        }

        public void SetPresenter(CustomerNotesPresenter notesPresenter)
        {
            this._presenter = notesPresenter;
        }

        public string NewNoteText
        {
            get => this.TxtNewNote.Text;
            set => this.TxtNewNote.Text = value;
        }

        public void AddNewNoteToHistory(CustomerNote note)
        {
            if (this.PnlNotes.Controls.Contains(this._emptyLabel))
                this.PnlNotes.Controls.Remove(this._emptyLabel);

            this.PnlNotes.Controls.Add(new CustomerNoteControl(note.Text, note.CreatedBy, note.CreatedAt));
        }

        public void InitializeMode()
        {
            var isEnabled = !this._presenter?.IsReadOnly ?? false;
            this.TxtNewNote.Enabled = isEnabled;
            this.CmdAddNote.Enabled = isEnabled;
        }

        public void ClearAllNotes()
        {
            this.PnlNotes.Controls.Clear();
        }

        private void CmdAddNote_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                this._presenter?.AddNewNoteFromText();
            }
            else
            {
                MessageBox.Show("Kontrollieren Sie die Angaben", "Erfassen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtNewNote_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.NewNoteText))
            {
                this.CustomerNoteErrorProvider.SetError(this.TxtNewNote, "Geben Sie eine Notiz ein.");
                this.TxtNewNote.Focus();
                e.Cancel = true;
            }
            else
            {
                this.CustomerNoteErrorProvider.SetError(this.TxtNewNote, null);
            }
        }
    }
}

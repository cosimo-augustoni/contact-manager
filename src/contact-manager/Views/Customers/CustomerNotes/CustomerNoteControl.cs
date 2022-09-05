namespace contact_manager.Views.Customers.CustomerNotes
{
    public partial class CustomerNoteControl : UserControl
    {
        public CustomerNoteControl(string noteText, string username, DateTime creationDate)
        {
            this.InitializeComponent();
            this.SetNoteText(noteText);
            this.LblUser.Text = username;
            this.LblTimestamp.Text = creationDate.ToString("dd.MM.yyyy HH:mm");
        }

        private void SetNoteText(string noteText)
        {
            this.LblNoteText.Text = noteText;
            Size sz = new Size(this.LblNoteText.Width, int.MaxValue);
            sz = TextRenderer.MeasureText(noteText, this.LblNoteText.Font, sz, TextFormatFlags.WordBreak);
            this.LblNoteText.Height = sz.Height;
        }
    }
}

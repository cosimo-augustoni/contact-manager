using contact_manager.Presenters.Customers;

namespace contact_manager.Views.Customers
{
    public partial class CustomerDetailDialog : Form, ICustomerDetailDialog
    {
        private CustomerDetailPresenter? presenter;

        #region FormProperties

        public string? FirstName
        {
            get => this.TxtFirstName.Text;
            set => this.TxtFirstName.Text = value;
        }

        //TODO Properties ergänzen

        #endregion

        public CustomerDetailDialog()
        {
            this.InitializeComponent();
        }

        // ToDo npa: was machen wir wegen den Visual Studio einstellungen?
        // sollten alle die gleiche haben

        // ToDo npa: Unit-Tests? => Palmer fragen
        public void SetPresenter(CustomerDetailPresenter customerDetailPresenter)
        {
            this.presenter = customerDetailPresenter;
        }

        private void CmdSave_Click(object sender, EventArgs e) {
          this.presenter?.Save();
        }

        private void CmdClose_Click(object sender, EventArgs e) {
          // ToDo: falls noch nicht gespeichert fragen, ob die Änderungen verworfen werden sollen
          // ToDo: nach dem Schliessen soll die Übersicht aktualisiert werden
          this.Close();
        }

    private void TxtPostalCode_KeyPress(object sender, KeyPressEventArgs e) {
      // ToDo: lassen wir nur zahlen zu?
      // also nur schweizer adressen?
      e.Handled = !Char.IsDigit(e.KeyChar);
    }
  }
}

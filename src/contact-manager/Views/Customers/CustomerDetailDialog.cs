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

        public void SetPresenter(CustomerDetailPresenter customerDetailPresenter)
        {
            this.presenter = customerDetailPresenter;
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            this.presenter?.Save();
        }
    }
}

using System.ComponentModel;
using contact_manager.Presenters.Authentication;

namespace contact_manager.Views.Authentication
{
    public partial class LoginView : Form, ILoginView
    {
        private LoginPresenter? _presenter;

        public LoginView()
        {
            this.InitializeComponent();
        }

        public string Username
        {
            get => this.TxtUserName.Text;
            set => this.TxtUserName.Text = value;
        }

        public string Password
        {
            get => this.TxtPassword.Text;
            set => this.TxtPassword.Text = value;
        }

        public void ShowAuthenticationFailed()
        {
            this.LoginErrorProvider.SetError(this.TxtUserName, "Benutzername und/oder Passwort sind falsch");
        }

        public void SetPresenter(LoginPresenter loginPresenter)
        {
            this._presenter = loginPresenter;
        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {
            this.Authenticate();
        }

        private void Authenticate()
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                this._presenter?.Authenticate();
            }
            else
            {
                MessageBox.Show("Kontrollieren Sie die Benutzereingaben", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.TxtUserName.Text))
            {
                e.Cancel = true;
                this.TxtUserName.Focus();
                this.LoginErrorProvider.SetError(this.TxtUserName, "Geben Sie einen Benutzernamen an");
            }
            else
            {
                e.Cancel = false;
                this.LoginErrorProvider.SetError(this.TxtUserName, null);
            }
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.TxtPassword.Text))
            {
                e.Cancel = true;
                this.TxtPassword.Focus();
                this.LoginErrorProvider.SetError(this.TxtPassword, "Geben Sie ein Passwort ein");
            }
            else
            {
                this.LoginErrorProvider.SetError(this.TxtPassword, null);
            }
        }

        private void LoginView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Authenticate();
            }
        }
    }
}

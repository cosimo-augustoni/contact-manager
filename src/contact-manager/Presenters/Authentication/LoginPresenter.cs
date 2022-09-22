using contact_manager.Models.Domain.Authentication;
using contact_manager.Views;
using contact_manager.Views.Authentication;

namespace contact_manager.Presenters.Authentication
{
    public class LoginPresenter : IPresenter
    {
        private readonly ILoginView _dialog;
        private readonly IUserService _userService;
        private readonly IFormFactory _formFactory;

        public LoginPresenter(ILoginView loginView, IUserService userService, IFormFactory formFactory)
        {
            this._dialog = loginView;
            this._userService = userService;
            this._formFactory = formFactory;
        }

        public void Init()
        {
            this._dialog.SetPresenter(this);
        }

        public void Authenticate()
        {
            if (this._userService.TryAuthenticate(this._dialog.Username, this._dialog.Password, out var user))
            {
                var overviewView = this._formFactory.CreateOverview(user);
                overviewView.Show();
                overviewView.FormClosed += (_, _) => this._dialog.Close();
                this._dialog.Hide();
            }
            else
            {
                this._dialog.ShowAuthenticationFailed();
            }
        }
    }
}

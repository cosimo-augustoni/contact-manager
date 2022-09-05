using contact_manager.Models.Domain.Authentication;
using contact_manager.Views;
using contact_manager.Views.Authentication;

namespace contact_manager.Presenters.Authentication
{
    public class LoginPresenter
    {
        private readonly ILoginView _loginView;
        private readonly IUserService _userService;
        private readonly IFormFactory _formFactory;

        public LoginPresenter(ILoginView loginView, IUserService userService, IFormFactory formFactory)
        {
            this._loginView = loginView;
            this._loginView.SetPresenter(this);

            this._userService = userService;
            this._formFactory = formFactory;
        }

        public void Authenticate()
        {
            if (this._userService.TryAuthenticate(this._loginView.Username, this._loginView.Password, out var user))
            {
                var dashboardView = this._formFactory.CreateOverview(user);
                dashboardView.Show();
                dashboardView.FormClosed += (_, _) => this._loginView.Close();
                this._loginView.Hide();
            }
            else
            {
                this._loginView.ShowAuthenticationFailed();
            }
        }
    }
}

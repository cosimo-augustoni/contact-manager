using contact_manager.Models.Domain.Authentication;
using contact_manager.Views;
using contact_manager.Views.Authentication;

namespace contact_manager.Presenters.Authentication
{
    public class LoginPresenter
    {
        private readonly ILoginView loginView;
        private readonly IUserService userService;
        private readonly IFormFactory formFactory;

        public LoginPresenter(ILoginView loginView, IUserService userService, IFormFactory formFactory)
        {
            this.loginView = loginView;
            this.loginView.SetPresenter(this);

            this.userService = userService;
            this.formFactory = formFactory;
        }

        public void Authenticate()
        {
            if (this.userService.TryAuthenticate(this.loginView.Username, this.loginView.Password, out var user))
            {
                var dashboardView = this.formFactory.CreateOverview(user);
                dashboardView.Show();
                dashboardView.FormClosed += (_, _) => this.loginView.Close();
                this.loginView.Hide();
            }
            else
            {
                this.loginView.ShowAuthenticationFailed();
            }
        }
    }
}

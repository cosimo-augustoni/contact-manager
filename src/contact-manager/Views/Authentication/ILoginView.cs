using contact_manager.Presenters.Authentication;

namespace contact_manager.Views.Authentication;

public interface ILoginView
{
    void ShowAuthenticationFailed();
    void SetPresenter(LoginPresenter loginPresenter);
    void Close();
    void Hide();
    string Username { get; set; }
    string Password { get; set; }
}

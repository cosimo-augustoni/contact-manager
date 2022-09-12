using contact_manager.Views.Authentication;
using contact_manager.Views.Employees;

namespace contact_manager.Views;

public interface IFormFactory
{
    LoginView CreateLoginDialog();
    OverviewView CreateOverview(Models.Domain.Authentication.User user);
}

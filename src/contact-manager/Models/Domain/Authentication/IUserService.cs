using System.Diagnostics.CodeAnalysis;

namespace contact_manager.Models.Domain.Authentication
{
    public interface IUserService
    {
        User Authenticate(string username, string password);

        bool TryAuthenticate(string username, string password, [NotNullWhen(true)] out User? user);
    }
}

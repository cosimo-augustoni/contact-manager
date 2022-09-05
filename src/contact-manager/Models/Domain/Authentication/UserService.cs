using System.Diagnostics.CodeAnalysis;
using System.Security.Authentication;

namespace contact_manager.Models.Domain.Authentication
{
    internal class UserService : IUserService
    {
        private static IEnumerable<User> GetAll()
        {
            yield return Users.AdminUser;
            yield return Users.ReadOnlyUser;
        }

        public User Authenticate(string username, string password)
        {
            var user = GetAll().FirstOrDefault(u => u.UserName == username && u.Password == password);
            if (user == null) throw new AuthenticationException();

            return user;
        }

        public bool TryAuthenticate(string username, string password, [NotNullWhen(true)] out User? user)
        {
            user = GetAll().FirstOrDefault(u => u.UserName == username && u.Password == password);

            return user != null;
        }
    }

    internal static class Users
    {
        //TODO Evtl. Passwort hashen
        public static User AdminUser = new User(1, "admin", "1234", canWrite: true);
        public static User ReadOnlyUser = new User(2, "readonly", "1234", canWrite: false);
    }
}

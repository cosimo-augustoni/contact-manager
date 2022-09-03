namespace contact_manager.Models.Data
{
    internal class IUserstore : IUserStore
    {

        private readonly static List<User> users = new List<User>()
        {
            // todo: passwort hashen
            // todo: benutzernamen noch überdenken
            new User(1, "admin", "1234", canWrite: true),
            new User(2, "read", "1234", canWrite: false)
        };

        public User? GetUser(string username, string password)
        {
            return users.FirstOrDefault(u => u.UserName == username && u.Password == password);
        }
    }
}

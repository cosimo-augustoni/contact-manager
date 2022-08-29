namespace contact_manager.Models.Data
{
    public class User
    {
        public String UserName { get; init; }
        public String Password { get; init; }

        public Boolean CanWrite { get; init; }

        public User(string userName, string password, bool canWrite)
        {
            this.UserName = userName;
            this.Password = password;
            this.CanWrite = canWrite;
        }
    }
}

namespace contact_manager.Models.Data
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; init; }
        public string Password { get; init; }

        public bool CanWrite { get; init; }

        public User(int id, string userName, string password, bool canWrite)
        {
            this.Id = id;
            this.UserName = userName;
            this.Password = password;
            this.CanWrite = canWrite;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contact_manager.Models.Data
{
    internal class IUserstore : IUserStore
    {

        private readonly static List<User> users = new List<User>()
        {
            // todo: passwort hashen
            new User("admin", "1234", canWrite: true),
            new User("read", "1234", canWrite: false)
        };

        public User? GetUser(string username, string password)
        {
            return users.FirstOrDefault(u => u.UserName == username && u.Password == password);
        }
    }
}

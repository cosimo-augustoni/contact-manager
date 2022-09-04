using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using contact_manager.Models.Data;

namespace contact_manager.Models
{
    public interface IUserStore
    {
        User? GetUser(string username, string password);
    }
}

using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
{
    public class User : IUser
    {
        public string Username { get; set; }

        public User(string username)
        {
            this.Username = username;
        }
    }
}

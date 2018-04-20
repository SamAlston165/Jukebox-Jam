using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public class AUser : IUser
    {
        public string Username { get; set; }

        public AUser(string username)
        {
            this.Username = username;
        }
    }
}

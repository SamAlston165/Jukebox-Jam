using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public class Login : ILogin
    {
        public IUser AuthorizeUser(string username, string password)
        {
            if (UsernameAndPasswordAreInDatabase(username, password))
            {
                return new AUser(username);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Return true if the username and password 
        /// match a record in the database
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool UsernameAndPasswordAreInDatabase(string username, string password)
        {
            throw new NotImplementedException();
        }

        public IUser CreateNewUser(string username, string password)
        {
            AddUserToDatabase(username, password);
            return new AUser(username);
        }

        /// <summary>
        /// Create a record for the newly created User in the database
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        private void AddUserToDatabase(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}

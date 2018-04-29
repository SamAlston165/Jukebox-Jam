using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public class Login : ILogin
    {
        // we were unable to authorize users on the server
        // users will be able to login using any username
        // and password
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
            //allow user to "sign in" under any non-empty username
            if(username.Equals(""))
            {
                return false;
            }
            return true;

            /*
            //this code should perform the http requests once server is straightened out
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:64195");
            string host = "http://159.65.235.100:6024/user/";
            HttpResponseMessage x = await client.GetAsync(host + username + "/" + password).ConfigureAwait(false);
            if (x.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
            */
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
            //throw new NotImplementedException();
        }
    }
}

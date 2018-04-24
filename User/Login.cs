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
        public IUser AuthorizeUser(string username, string password)
        {
            if (UsernameAndPasswordAreInDatabase(username, password).GetAwaiter().GetResult())
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
        private async Task<bool> UsernameAndPasswordAreInDatabase(string username, string password)
        {

            if(username == "user" && password == "password")
            {
                return true;
            }
            else
            {
                return false;
            }
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
            throw new NotImplementedException();
        }
    }
}

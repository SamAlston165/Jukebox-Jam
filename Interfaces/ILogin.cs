using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ILogin
    {
        IUser CreateNewUser(string username, string password);

        IUser AuthorizeUser(string username, string password);
    }
}

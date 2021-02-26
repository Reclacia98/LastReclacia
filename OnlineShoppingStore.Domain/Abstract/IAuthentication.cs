using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Abstract
{
    public interface IAuthentication
    {
        bool Authentication(string username, string password);
        bool Logout();
        bool Authenticate(string userName, string password);
    }
}

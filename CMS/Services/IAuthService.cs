using CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Services
{
    public interface IAuthService
    {
        bool IsAuthenticated();
        bool IsAdminUser();
        int Login(string username, string password);
        int Logout();
        int CreateUser(User user);
        int UpdateUser(User user);
        int DeleteUser(int id);
    }
}

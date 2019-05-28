using System.Collections.Generic;
using CMS.Models;

namespace CMS.Services
{
    public interface IAuthService
    {
        string GetCurrentUsername();
        User GetCurrentUser();
        IEnumerable<User> GetAllUsers();
        User GetUser(int id);

        bool IsAuthenticated();
        bool IsAdminUser();
        int Login(string username, string password);
        void Logout();
        int CreateUser(User user);
        int UpdateUser(User user);
        int DeleteUser(int id);
    }
}

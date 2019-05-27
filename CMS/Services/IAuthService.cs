using CMS.Models;

namespace CMS.Services
{
    public interface IAuthService
    {
        string GetCurrentUser();

        bool IsAuthenticated();
        bool IsAdminUser();
        int Login(string username, string password);
        int Logout();
        int CreateUser(User user);
        int UpdateUser(User user);
        int DeleteUser(int id);
    }
}

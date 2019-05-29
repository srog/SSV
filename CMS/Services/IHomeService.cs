using CMS.Models;

namespace CMS.Services
{
    public interface IHomeService
    {
        HomeInfo GetHomeInfo();
        int Login(string username, string password);
        void Logout();
    }
}
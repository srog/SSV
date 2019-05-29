using System.Collections.Generic;
using CMS.Models;

namespace CMS.Services
{
    public interface IHomeService
    {
        HomeInfo GetHomeInfo();
        Dictionary<string, string> GetBookmarks();

        int Login(string username, string password);
        void Logout();

    }
}
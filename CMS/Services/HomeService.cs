using System.Collections.Generic;
using CMS.Data;
using CMS.Models;
using Microsoft.Extensions.Configuration;

namespace CMS.Services
{
    public interface IHomeService
    {
        HomeInfo GetHomeInfo();
        Dictionary<string, string> GetBookmarks();

        int Login(string username, string password);
        void Logout();

    }
    public class HomeService : IHomeService
    {
        private readonly IConfiguration _configuration;
        private readonly IAuthService _authService;

        public HomeService(IConfiguration configuration, IAuthService authService)
        {
            _configuration = configuration;
            _authService = authService;
        }

        public int Login(string username, string password)
        {
            return _authService.Login(username, password);
        }
        public void Logout()
        {
            _authService.Logout();
        }

        public HomeInfo GetHomeInfo()
        {
            var loggedInUsername = _authService.GetCurrentUsername();

            if (loggedInUsername == "")
            {
                _authService.Login("admin", "password1");
            }

            return new HomeInfo
                {
                    SiteCreatedDate = _configuration.GetValue<string>("SiteCreatedDate"),
                    LoggedInUsername = loggedInUsername,
                    DayOffset = 0
                };
        }

        // Todo - make user-definable
        public Dictionary<string, string> GetBookmarks()
        {
            return StaticData.Bookmarks;
        }
    }
}

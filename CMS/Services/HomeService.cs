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

        public HomeInfo GetHomeInfo()
        {

            return new HomeInfo
                {
                    SiteCreatedDate = _configuration.GetValue<string>("SiteCreatedDate"),
                    LoggedInUsername = _authService.GetCurrentUsername(),
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

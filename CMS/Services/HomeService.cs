using CMS.Models;
using Microsoft.Extensions.Configuration;

namespace CMS.Services
{
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
            var loggedInUsername = _authService.GetCurrentUsername();

            if (loggedInUsername == "")
            {
                _authService.Login("admin", "password1");
            }

            return new HomeInfo
                {
                    SiteCreatedDate = _configuration.GetValue<string>("SiteCreatedDate"),
                    LoggedInUsername = loggedInUsername
                };
        }
    }
}

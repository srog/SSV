using CMS.Models;
using Microsoft.Extensions.Configuration;

namespace CMS.Services
{
    public class HomeService : IHomeService
    {
        private readonly IConfiguration _configuration;

        public HomeService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetInfo()
        {
            return "test";
        }

        public HomeInfo GetHomeInfo()
        {
            return new HomeInfo
                {
                    SiteCreatedDate = _configuration.GetValue<string>("SiteCreatedDate")
                };
        }
    }
}

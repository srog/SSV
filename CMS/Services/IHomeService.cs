using CMS.Models;

namespace CMS.Services
{
    public interface IHomeService
    {
        string GetInfo();
        HomeInfo GetHomeInfo();
    }
}
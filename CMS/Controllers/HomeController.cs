using Microsoft.AspNetCore.Mvc;
using CMS.Models;
using CMS.Services;

namespace CMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }
        public IActionResult Index()
        {
            return View(_homeService.GetHomeInfo());
        }

        public IActionResult IndexWithOffset(int daysOffset)
        {
            var homeInfo = _homeService.GetHomeInfo();
            homeInfo.DayOffset = daysOffset;
            return View("Index", homeInfo);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "About Me.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contacts.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

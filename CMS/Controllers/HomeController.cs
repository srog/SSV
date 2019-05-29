using System.Diagnostics;
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

        public RedirectToActionResult Login()
        {
            _homeService.Login("admin", "password1");
            return RedirectToAction("Index");
        }
        public RedirectToActionResult Logout()
        {
            _homeService.Logout();
            return RedirectToAction("Index");
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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

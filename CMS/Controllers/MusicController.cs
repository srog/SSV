using System.Linq;
using CMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    public class MusicController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IEntityService _entityService;
        private readonly IRatingService _ratingService;

        public MusicController(IAuthService authService, IEntityService entityService, IRatingService ratingService)
        {
            _authService = authService;
            _entityService = entityService;
            _ratingService = ratingService;
        }

        public IActionResult Index()
        {
            var musicList = _entityService.GetAllMusic().OrderByDescending(m => m.Id);
            return View("MusicList", musicList);
        }

        [HttpPost]
        public void Rate(int entityId, int ratingValue, string ratingText)
        {
            _ratingService.AddRating(entityId, _authService.GetCurrentUser().Id, ratingValue, ratingText);

            // update view component ?
        }


    }
}
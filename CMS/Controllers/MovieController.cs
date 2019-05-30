using System.Linq;
using CMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    public class MovieController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IEntityService _entityService;
        private readonly IRatingService _ratingService;

        public MovieController(IAuthService authService, IEntityService entityService, IRatingService ratingService)
        {
            _authService = authService;
            _entityService = entityService;
            _ratingService = ratingService;
        }

        public IActionResult Index()
        {
            var movieList = _entityService.GetAllMovies().OrderByDescending(m => m.Id);
            return View("MovieList", movieList);
        }

        [HttpPost]
        public IActionResult Rate(int entityId, int ratingValue, string ratingText)
        {
            _ratingService.AddRating(entityId, _authService.GetCurrentUser().Id, ratingValue, ratingText);
            ModelState.Clear();

            return Index();
            // update view component ?
        }


    }
}
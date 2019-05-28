using System.Linq;
using System.Threading.Tasks;
using CMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Views.Shared.Components.MusicRating
{
    public class MusicRatingViewComponent : ViewComponent
    {
        private readonly IRatingService _ratingService;

        public MusicRatingViewComponent(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int entityId)
        {
            var rating = _ratingService.GetRatingsForEntity(entityId);

            var averageRating = rating.Sum(r => r.RatingValue) / rating.Count();

            return View("MusicRating", averageRating.ToString());
        }

    }
}

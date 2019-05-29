using System.Linq;
using System.Threading.Tasks;
using CMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Views.Shared.Components.EntityRating
{
    public class EntityRatingViewComponent : ViewComponent
    {
        private readonly IRatingService _ratingService;

        public EntityRatingViewComponent(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int entityId)
        {
            var rating = _ratingService.GetRatingsForEntity(entityId);
            decimal averageRating = 0;

            if (rating.Count() != 0)
            {
                averageRating = (decimal)rating.Sum(r => r.RatingValue) / (decimal)rating.Count();
            }
            var ratingString = averageRating.ToString("0.##");
            ratingString += " (" + rating.Count() + " votes)";
            return View("EntityRating", ratingString);
        }

    }
}

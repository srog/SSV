using System.Threading.Tasks;
using CMS.Models;
using CMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Views.Shared.Components.EntityRater
{
    public class EntityRaterViewComponent : ViewComponent
    {
        private readonly IRatingService _ratingService;

        public EntityRaterViewComponent(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int entityId)
        {
            var rater = new Rating {EntityId = entityId};
            return View("EntityRater", rater);
        }

    }
}

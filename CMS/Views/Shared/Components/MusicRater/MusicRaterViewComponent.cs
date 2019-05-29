using System.Threading.Tasks;
using CMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Views.Shared.Components.MusicRater
{
    public class MusicRaterViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int entityId)
        {
            var rater = new Rating {EntityId = entityId};
            return View("MusicRater", rater);
        }

    }
}

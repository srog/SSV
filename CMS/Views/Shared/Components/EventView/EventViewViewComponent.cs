using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Views.Shared.Components.EventView
{
    public class EventViewViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int daysOffset = 0)
        {
            return View("EventView", daysOffset);
        }

    }
}

using System.Threading.Tasks;
using CMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Views.Shared.Components.Bookmarks
{
    public class BookmarksViewComponent : ViewComponent
    {
        private readonly IHomeService _homeService;

        public BookmarksViewComponent(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var bookmarks = _homeService.GetBookmarks();

            return View("Bookmarks", bookmarks);
        }
    }
}


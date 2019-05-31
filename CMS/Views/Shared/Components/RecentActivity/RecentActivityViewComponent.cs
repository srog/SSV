using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using CMS.Models;
using CMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Views.Shared.Components.RecentActivity
{
    public class RecentActivityViewComponent : ViewComponent
    {
        private readonly IBlogService _blogService;
        private readonly IRatingService _ratingService;

        public RecentActivityViewComponent(IBlogService blogService, IRatingService ratingService)
        {
            _blogService = blogService;
            _ratingService = ratingService;
        }

        // Todo - extend to other types
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var recent = new List<Activity>();
            var recentBlogItems = _blogService.GetAllBlogItems().OrderByDescending(b => b.Created);
            foreach (var item in recentBlogItems)
            {
                recent.Add(new Activity
                    {
                        Name = "Blog Entry for: " + _blogService.GetBlog(item.BlogId).Name,
                        DateAdded = item.Created,
                        Username = item.CreatedByFullName,
                        Link = "http://localhost:55136/Blog/" + item.BlogId
                    });
            }

            var recentBlogs = _blogService.GetAllBlogs().OrderByDescending(b => b.Created);
            foreach (var item in recentBlogs)
            {
                recent.Add(new Activity
                    {
                        Name = "New Blog: " + item.Name,
                        DateAdded = item.Created,
                        Username = item.CreatedByFullName,
                        Link = "http://localhost:55136/Blog/" + item.Id
                    });
            }

            var ratings = _ratingService.GetLatest();
            foreach (var rating in ratings)
            {
                recent.Add(new Activity
                    {
                       Name =  "Review for: " + rating.EntityDescription,
                       DateAdded = rating.Created,
                       Link = "http://localhost:55136/Movie",
                       Username = rating.Username
                });
            }

            var recentList = recent.OrderByDescending(r => r.DateAdded).Take(5);

            return View("RecentActivity", recentList);
        }
    }
}

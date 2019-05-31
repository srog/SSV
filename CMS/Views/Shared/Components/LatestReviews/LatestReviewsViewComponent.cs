using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Views.Shared.Components.LatestReviews
{
    public class LatestReviewsViewComponent : ViewComponent
    {
        private readonly IRatingService _ratingService;

        public LatestReviewsViewComponent(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var reviews = _ratingService.GetLatest();


            return View("LatestReviews", reviews);
        }
    }
}

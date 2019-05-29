using System;
using System.Linq;
using System.Threading.Tasks;
using CMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Views.Shared.Components.EventDay
{
    public class EventDayViewComponent : ViewComponent
    {
        private readonly IEventService _eventService;
        public EventDayViewComponent(IEventService eventService)
        {
            _eventService = eventService;
        }

        public async Task<IViewComponentResult> InvokeAsync(DateTime eventDate)
        {
            var eventDay = new Models.EventDay
                {
                    Date = eventDate,
                    Events = _eventService.GetAllEventsForCurrentUser(DateTime.Now.AddDays(-7), DateTime.Now.AddDays(7)).ToList()
                };
            return View("EventDay", eventDay);
        }

    }
}

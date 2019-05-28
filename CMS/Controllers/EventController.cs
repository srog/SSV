using CMS.Models;
using CMS.Models.Enums;
using CMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    public class EventController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IEventService _eventService;

        public EventController(IEventService eventService, IAuthService authService)
        {
            _eventService = eventService;
            _authService = authService;
        }

        public IActionResult Index()
        {
            var events = _eventService.GetAllEventsForuser(_authService.GetCurrentUser().Id);
            return View("Index", events);
        }

        public IActionResult AdminView()
        {
            var events = _eventService.GetAllEvents();
            return View("Index", events);
        }

        public IActionResult Create()
        {
            return View("CreateEvent");
        }

        public IActionResult CreateEvent(Event eventRecord)
        {
            var newId = _eventService.AddEvent(eventRecord);
            return Index();
        }

        public IActionResult DeleteEvent(int id)
        {
            _eventService.UpdateEvent(id, EventStatusEnum.Deleted);
            return Index();
        }
        public IActionResult CompleteEvent(int id)
        {
            _eventService.UpdateEvent(id, EventStatusEnum.Complete);
            return Index();
        }



    }
}
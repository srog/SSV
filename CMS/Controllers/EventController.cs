using System;
using System.Linq;
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
            return View("Index");
        }

        public IActionResult ShowEvents(int day)
        {
            var startDate = DateTime.Today.AddDays(day-1);
            var endDate = DateTime.Today.AddDays(day + 1);
            var eventDay = new EventDay
                {
                    Events = _eventService.GetAllEventsForCurrentUser()
                    .Where(e => e.EventStart > startDate && e.EventEnd < endDate)    
                    .ToList(),
                    Date = DateTime.Now.AddDays(day)
                };

            return View("Index", eventDay);
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
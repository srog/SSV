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



        public IActionResult ShowEventsForDate(DateTime date)
        {
            var eventDay = new EventDay
                {
                    Events = _eventService.GetAllEventsForCurrentUser()
                        .Where(e => Utilities.DateTimeExtensions.IsInDateRange(date, e.EventStart, e.EventEnd))
                        .ToList(),
                    Date = date
                };

            return View("Index", eventDay);
        }

        public IActionResult ShowEvents(int daysOffset)
        {
            var startDate = DateTime.Today.AddDays(daysOffset-1);
            var endDate = DateTime.Today.AddDays(daysOffset + 1);
            var eventDay = new EventDay
                {
                    Events = _eventService.GetAllEventsForCurrentUser()
                    .Where(e => e.EventStart > startDate && e.EventEnd < endDate)    
                    .ToList(),
                    Date = DateTime.Now.AddDays(daysOffset)
                };

            return View("Index", eventDay);
        }

        
        public IActionResult Create(DateTime date)
        {
            var newEvent = new Event() { EventStart = date.Date, EventEnd = date.Date };
            return View("CreateEvent", newEvent);
        }

        public IActionResult AddEvent(Event eventRecord)
        {
            var newId = _eventService.AddEvent(eventRecord);
            return ShowEventsForDate(eventRecord.EventStart);
        }

        public IActionResult DeleteEvent(int id, int daysOffset)
        {
            _eventService.UpdateEvent(id, EventStatusEnum.Deleted);
            return ShowEvents(daysOffset);
        }
        public IActionResult CompleteEvent(int id, int daysOffset)
        {
            _eventService.UpdateEvent(id, EventStatusEnum.Complete);
            return ShowEvents(daysOffset);
        }



    }
}
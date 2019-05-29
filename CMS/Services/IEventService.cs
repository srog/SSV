using System;
using System.Collections.Generic;
using CMS.Models;
using CMS.Models.Enums;

namespace CMS.Services
{
    public interface IEventService
    {
        Event GetEvent(int id);
        IEnumerable<Event> GetAllEvents();
        IEnumerable<Event> GetAllEventsForUser(int userId);
        IEnumerable<Event> GetAllEventsForCurrentUser(DateTime? startDate=null, DateTime? endDate=null);
        int AddEvent(Event eventRecord);
        int UpdateEvent(int id, EventStatusEnum status);
    }
}
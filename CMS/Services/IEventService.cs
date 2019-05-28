using System.Collections.Generic;
using CMS.Models;
using CMS.Models.Enums;

namespace CMS.Services
{
    public interface IEventService
    {
        Event GetEvent(int id);
        IEnumerable<Event> GetAllEvents();
        IEnumerable<Event> GetAllEventsForuser(int userId);
        int AddEvent(Event eventRecord);
        int UpdateEvent(int id, EventStatusEnum status);
    }
}
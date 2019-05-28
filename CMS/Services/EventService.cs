using System.Collections.Generic;
using CMS.DataAccess;
using CMS.Models;
using CMS.Models.Enums;

namespace CMS.Services
{
    public class EventService : IEventService
    {
        private readonly IDataAccessor _dataAccessor;

        private const string GET = "spGetEvent";
        private const string GET_ALL = "spGetAllEvents";
        private const string GET_FOR_USER = "spGetEventsForUser";
        private const string INSERT = "spInsertEvent";
        private const string UPDATE = "spUpdateEvent";
        private const string DELETE = "spDeleteEvent";


        public EventService(IDataAccessor dataAccessor)
        {
            _dataAccessor = dataAccessor;
        }


        #region Implementation of IEventService

        public Event GetEvent(int id)
        {
            return _dataAccessor.QuerySingle<Event>(GET, new {id});
        }

        public IEnumerable<Event> GetAllEvents()
        {
            return _dataAccessor.Query<Event>(GET_ALL);
        }

        public IEnumerable<Event> GetAllEventsForuser(int userId)
        {
            return _dataAccessor.Query<Event>(GET_FOR_USER, new {userId});
        }

        public int AddEvent(Event eventRecord)
        {
            return _dataAccessor.QuerySingle<int>(INSERT, new
                {
                    eventRecord.Name,
                    eventRecord.Description,
                    eventRecord.UserId,
                    eventRecord.Status,
                    eventRecord.IsPublic,
                    eventRecord.EventStart,
                    eventRecord.EventEnd,
                    eventRecord.Location
            });
        }

        public int UpdateEvent(int id, EventStatusEnum status)
        {
            return _dataAccessor.QuerySingle<int>(UPDATE, new {id, status = status.GetHashCode()});
        }

        #endregion
    }
}
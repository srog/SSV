using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using CMS.DataAccess;
using CMS.Models;
using CMS.Models.Enums;
using Dapper;

namespace CMS.Services
{
    public interface IEventService
    {
        Event GetEvent(int id);
        IEnumerable<Event> GetAllEvents();
        IEnumerable<Event> GetAllEventsForUser(int userId);
        IEnumerable<Event> GetAllEventsForCurrentUser(DateTime? startDate = null, DateTime? endDate = null);
        int AddEvent(Event eventRecord);
        int UpdateEvent(int id, EventStatusEnum status);
    }
    public class EventService : IEventService
    {
        private readonly IDataAccessor _dataAccessor;
        private readonly IAuthService _authService;

        private const string GET = "spGetEvent";
        private const string GET_ALL = "spGetAllEvents";
        private const string GET_FOR_USER = "spGetEventsForUser";
        private const string INSERT = "spInsertEvent";
        private const string UPDATE = "spUpdateEvent";
        private const string DELETE = "spDeleteEvent";


        public EventService(IDataAccessor dataAccessor, IAuthService authService)
        {
            _dataAccessor = dataAccessor;
            _authService = authService;
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

        public IEnumerable<Event> GetAllEventsForCurrentUser(DateTime? startDate=null, DateTime? endDate=null)
        {
            var currentUser = _authService.GetCurrentUser().Id;
            var events = GetAllEventsForUser(currentUser);
            
            if (startDate != null)
            {
                events = events.Where(e => e.EventStart > startDate);
            }
            if (endDate != null)
            {
                events = events.Where(e => e.EventStart < endDate);
            }

            return events;
        }

        public IEnumerable<Event> GetAllEventsForUser(int userId)
        {
            return _dataAccessor.Query<Event>(GET_FOR_USER, new {userId});
        }

        public int AddEvent(Event eventRecord)
        {
            var allParam = new DynamicParameters();
            allParam.Add("id", dbType: DbType.Int32, direction: ParameterDirection.Output);
            allParam.Add("name", eventRecord.Name);
            allParam.Add("description", eventRecord.Description);
            allParam.Add("userid", eventRecord.UserId);
            allParam.Add("status", eventRecord.Status);
            allParam.Add("isPublic", eventRecord.IsPublic);
            allParam.Add("eventStart", eventRecord.EventStart);
            allParam.Add("eventEnd", eventRecord.EventEnd);
            allParam.Add("location", eventRecord.Location);

            var result = _dataAccessor.QuerySingle<int>(INSERT, allParam);
            if (result != 0)
            {
                return 0;
            }
            return allParam.Get<int>("id");
        }

        public int UpdateEvent(int id, EventStatusEnum status)
        {
            return _dataAccessor.QuerySingle<int>(UPDATE, new {id, status = status.GetHashCode()});
        }

        #endregion
    }
}
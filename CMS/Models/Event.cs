using System;
using System.Collections.Generic;
using CMS.Models.Enums;

namespace CMS.Models
{
    public class Event
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public EventStatusEnum Status { get; set; }
        public bool IsPublic { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EventStart { get; set; }
        public DateTime EventEnd { get; set; }
        public string Location { get; set; }
    }

    //public class EventList
    //{
    //    public List<Event> Events { get; set; }
    //    public User UserRecord { get; set; }

    //}

    public class EventDay
    {
        public DateTime Date { get; set; }
        public List<Event> Events { get; set; }

    }
}
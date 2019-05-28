using System;
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
}
using System;

namespace CMS.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public int CreatedByUser { get; set; }

        public string CreatedString => Created.ToString("dd MMM yy");

    }
}
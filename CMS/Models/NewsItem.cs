using System;

namespace CMS.Models
{
    public class NewsItem
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }

        public string News { get; set; }
    }
}
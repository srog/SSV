using System;
using System.Collections.Generic;

namespace CMS.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public List<BlogItem> Items { get; set; }
        public string NewItem { get; set; }
    }
}

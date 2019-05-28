using System.Collections.Generic;

namespace CMS.Models
{
    public class Blog : BaseEntity
    {
        public List<BlogItem> Items { get; set; }

        public string NewItem { get; set; }
        public string CreatedByFullName { get; set; }
    }
}

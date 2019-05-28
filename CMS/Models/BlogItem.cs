using System;
using System.ComponentModel.DataAnnotations;

namespace CMS.Models
{
    public class BlogItem
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public DateTime Created { get; set; }
        public int CreatedByUser { get; set; }
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }

        public string CreatedByFullName { get; set; }
    }
}
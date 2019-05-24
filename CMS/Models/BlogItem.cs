using System;
using System.ComponentModel.DataAnnotations;

namespace CMS.Models
{
    public class BlogItem
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }
    }
}
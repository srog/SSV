using System;

namespace CMS.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public int UserId { get; set; }
        public int RatingValue { get; set; }
        public string RatingText { get; set; }
        public DateTime Created { get; set; }

    }
}
namespace CMS.Models
{
    public class MovieDetails
    {
        public int EntityId { get; set; }
        public string  Name { get; set; }
        public string ImdbLink { get; set; }
        public string ImageFilePath { get; set; }
        public decimal ImdbRating { get; set; }
        public int YearReleased { get; set; }
    }
}
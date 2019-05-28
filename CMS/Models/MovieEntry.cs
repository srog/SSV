using CMS.Models.Enums;

namespace CMS.Models
{
    public class MovieEntry : BaseEntity
    {
        public EntityTypeEnum EntityType => EntityTypeEnum.Movie;
    }
}
using CMS.Models.Enums;

namespace CMS.Models
{
    public class MusicEntry : BaseEntity
    {
        public EntityTypeEnum EntityType => EntityTypeEnum.Music;
    }
}
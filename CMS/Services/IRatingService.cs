using System.Collections.Generic;
using CMS.Models;

namespace CMS.Services
{
    public interface IRatingService
    {
        IEnumerable<Rating> GetRatingsForEntity(int entityId);
        int AddRating(int entityId, int userId, int ratingValue, string ratingText);
    }
}
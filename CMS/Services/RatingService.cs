using System.Collections.Generic;
using System.Linq;
using CMS.DataAccess;
using CMS.Models;

namespace CMS.Services
{
    public interface IRatingService
    {
        IEnumerable<Rating> GetRatingsForEntity(int entityId);
        IEnumerable<Rating> GetLatest();
        int AddRating(int entityId, int userId, int ratingValue, string ratingText);
    }

    public class RatingService : IRatingService
    {
        private readonly IDataAccessor _dataAccessor;
        private const string GET_ALL_FOR_ENTITY = "spGetRatingsForEntity";
        private const string GET_ALL = "spGetAllRatings";
        private const string INSERT = "spInsertRating";

        public RatingService(IDataAccessor dataAccessor)
        {
            _dataAccessor = dataAccessor;
        }

        #region Implementation of IRatingService

        public IEnumerable<Rating> GetRatingsForEntity(int entityId)
        {
            return _dataAccessor.Query<Rating>(GET_ALL_FOR_ENTITY, new {entityId});
        }

        public IEnumerable<Rating> GetLatest()
        {
            return _dataAccessor.Query<Rating>(GET_ALL).OrderByDescending(r => r.Created);
        }

        public int AddRating(int entityId, int userId, int ratingValue, string ratingText)
        {
            return _dataAccessor.QuerySingle<int>(INSERT, new {entityId, userId, ratingValue, ratingText });
        }

        #endregion
    }
}
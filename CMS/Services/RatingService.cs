using System.Collections.Generic;
using CMS.DataAccess;
using CMS.Models;

namespace CMS.Services
{
    public class RatingService : IRatingService
    {
        private readonly IDataAccessor _dataAccessor;
        private const string GET_ALL_FOR_ENTITY = "spGetRatingsForEntity";
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

        public int AddRating(int entityId, int userId, int ratingValue, string ratingText)
        {
            return _dataAccessor.QuerySingle<int>(INSERT, new {entityId, userId, ratingValue, ratingText });
        }

        #endregion
    }
}
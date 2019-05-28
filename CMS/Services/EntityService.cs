using System.Collections.Generic;
using CMS.DataAccess;
using CMS.Models;
using CMS.Models.Enums;

namespace CMS.Services
{
    public class EntityService : IEntityService
    {
        private readonly IDataAccessor _dataAccessor;

        private const string GET = "spGetEntity";
        private const string GET_ALL_MOVIES = "spGetAllMovies";
        private const string GET_ALL_MUSIC = "spGetAllMusic";
        private const string GET_MUSIC = "spGetMusicDetails";
        private const string GET_MOVIE = "spGetMovieDetails";

        private const string INSERT = "spInsertEntity";

        private const string INSERT_MOVIE = "spInsertMovie";
        private const string INSERT_MUSIC = "spInsertMusic";


        public EntityService(IDataAccessor dataAccessor)
        {
            _dataAccessor = dataAccessor;
        }

        #region Implementation of IEntityService
 
        public IEnumerable<MovieEntry> GetAllMovies()
        {
            return _dataAccessor.Query<MovieEntry>(GET_ALL_MOVIES);
        }

        public MovieDetails GetMovieDetails(int entityId)
        {
            return _dataAccessor.QuerySingle<MovieDetails>(GET_MOVIE, new {entityId});
        }

        public MusicDetails GetMusicDetails(int entityId)
        {
            return _dataAccessor.QuerySingle<MusicDetails>(GET_MUSIC, new { entityId });
        }

        public IEnumerable<MusicEntry> GetAllMusic()
        {
            return _dataAccessor.Query<MusicEntry>(GET_ALL_MUSIC);
        }
        
        public BaseEntity GetEntity(int id)
        {
            return _dataAccessor.QuerySingle<BaseEntity>(GET, new {id});
        }

        public int AddMovie(string name)
        {
            return _dataAccessor.QuerySingle<int>(INSERT,
                new {name, entityType = EntityTypeEnum.Movie.GetHashCode()});
        }

        public int AddMusic(MusicDetails music)
        {
            var entityId = _dataAccessor.QuerySingle<int>(INSERT,
                new { name = music.Name, entityType = EntityTypeEnum.Music.GetHashCode() });

            return _dataAccessor.QuerySingle<int>(INSERT_MUSIC,
                new {entityId, music.ImageFilePath, music.SpotifyLink, music.YearReleased});
        }
        public int AddMovie(MovieDetails movie)
        {
            var entityId = _dataAccessor.QuerySingle<int>(INSERT,
                new { name = movie.Name, entityType = EntityTypeEnum.Movie.GetHashCode() });

            return _dataAccessor.QuerySingle<int>(INSERT_MOVIE,
                new { entityId, movie.ImageFilePath, movie.ImdbLink, movie.YearReleased, movie.ImdbRating });
        }

        public int UpdateMovieDetails(MovieDetails movie)
        {
            throw new System.NotImplementedException();
        }
        public int UpdateMusicDetails(MusicDetails music)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
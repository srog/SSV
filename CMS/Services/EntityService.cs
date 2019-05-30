using System.Collections.Generic;
using System.Data;
using CMS.DataAccess;
using CMS.Models;
using CMS.Models.Enums;
using Dapper;

namespace CMS.Services
{
    public interface IEntityService
    {
        IEnumerable<MovieEntry> GetAllMovies();
        IEnumerable<MusicEntry> GetAllMusic();
        IEnumerable<MovieDetails> GetAllMovieDetails();
        IEnumerable<MusicDetails> GetAllMusicDetails();

        BaseEntity GetEntity(int id);
        int AddMovie(MovieDetails movie);
        int AddMusic(MusicDetails music);
        MovieDetails GetMovieDetails(int entityId);
        MusicDetails GetMusicDetails(int entityId);
        int UpdateMovieDetails(MovieDetails movie);
        int UpdateMusicDetails(MusicDetails music);
    }

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

        public IEnumerable<MovieDetails> GetAllMovieDetails()
        {
            var movies = _dataAccessor.Query<MovieEntry>(GET_ALL_MOVIES);
            var movieList = new List<MovieDetails>();

            foreach(var movie in movies)
            {
                var detail = GetMovieDetails(movie.Id);
                movieList.Add(detail);
            }
            return movieList;

        }
        public IEnumerable<MusicDetails> GetAllMusicDetails()
        {
            var musics = _dataAccessor.Query<MusicEntry>(GET_ALL_MUSIC);
            var musicList = new List<MusicDetails>();

            foreach (var music in musics)
            {
                var detail = GetMusicDetails(music.Id);
                musicList.Add(detail);
            }
            return musicList;
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
            var allParam = new DynamicParameters();
            allParam.Add("id", dbType: DbType.Int32, direction: ParameterDirection.Output);
            allParam.Add("name", music.Name);
            allParam.Add("entityType", EntityTypeEnum.Music.GetHashCode());
            var result = _dataAccessor.QuerySingle<int>(INSERT, allParam);
            var newId = allParam.Get<int>("id");

            return _dataAccessor.QuerySingle<int>(INSERT_MUSIC,
                new {entityId = newId, music.ImageFilePath, music.SpotifyLink, music.YearReleased, music.Name});
        }
        public int AddMovie(MovieDetails movie)
        {
            var allParam = new DynamicParameters();
            allParam.Add("id", dbType: DbType.Int32, direction: ParameterDirection.Output);
            allParam.Add("name", movie.Name);
            allParam.Add("entityType", EntityTypeEnum.Movie.GetHashCode());
            
            var result = _dataAccessor.QuerySingle<int>(INSERT, allParam);
            var newId = allParam.Get<int>("id");

            return _dataAccessor.QuerySingle<int>(INSERT_MOVIE,
                new { entityId = newId, movie.ImageFilePath, movie.ImdbLink, movie.YearReleased, movie.ImdbRating, movie.Name });
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
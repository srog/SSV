using System.Collections.Generic;
using CMS.Models;

namespace CMS.Services
{
    public interface IEntityService
    {
        IEnumerable<MovieEntry> GetAllMovies();
        IEnumerable<MusicEntry> GetAllMusic();

        BaseEntity GetEntity(int id);
        int AddMovie(MovieDetails movie);
        int AddMusic(MusicDetails music);
        MovieDetails GetMovieDetails(int entityId);
        MusicDetails GetMusicDetails(int entityId);
        int UpdateMovieDetails(MovieDetails movie);
        int UpdateMusicDetails(MusicDetails music);
    }
}
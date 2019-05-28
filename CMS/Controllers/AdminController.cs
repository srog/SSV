using CMS.Models;
using CMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAuthService _authService;
        private readonly IEntityService _entityService;

        public AdminController(IAuthService authService, IEntityService entityService)
        {
            _authService = authService;
            _entityService = entityService;
        }
        public IActionResult Index()
        {
            return View();
        }

        // users

        public IActionResult UserList()
        {
            var userList = _authService.GetAllUsers();
            return View("UserList", userList);
        }

        public IActionResult CreateUser()
        {
            return View("CreateUser");
        }

        public IActionResult AddUser(User user)
        {
            _authService.CreateUser(user);
            return UserList();
        }

        public IActionResult DisableUser(int id)
        {
            var user = _authService.GetUser(id);
            user.IsActive = false;
            _authService.UpdateUser(user);
            return UserList();
        }
        public IActionResult ActivateUser(int id)
        {
            var user = _authService.GetUser(id);
            user.IsActive = true;
            _authService.UpdateUser(user);
            return UserList();
        }


        // entities
        // movies
        public IActionResult MovieList()
        {
            var movieList = _entityService.GetAllMovies();
            return View("MovieList", movieList);
        }

        public IActionResult CreateMovie()
        {
            var newMovie = new MovieDetails();
            return View("CreateMovie", newMovie);
        }
        public IActionResult AddMovie(MovieDetails movieDetails)
        {
            _entityService.AddMovie(movieDetails);
            return MovieList();
        }
        public IActionResult EditMovie(int entityId)
        {
            var editMovie = _entityService.GetMovieDetails(entityId);
            return View("EditMovie", editMovie);
        }

        public IActionResult UpdateMovie(MovieDetails movie)
        {
            _entityService.UpdateMovieDetails(movie);
            return MovieList();
        }

        // music
        public IActionResult MusicList()
        {
            var musicList = _entityService.GetAllMusic();
            return View("MusicList", musicList);
        }

        public IActionResult CreateMusic()
        {
            var newMusic = new MusicDetails();
            return View("CreateMusic", newMusic);
        }

        public IActionResult AddMusic(MusicDetails musicDetails)
        {
            _entityService.AddMusic(musicDetails);
            return MusicList();
        }

        public IActionResult EditMusic(int entityId)
        {
            var music = _entityService.GetMusicDetails(entityId);
            return View("EditMusic", music);
        }
        public IActionResult UpdateMusic(MusicDetails music)
        {
            _entityService.UpdateMusicDetails(music);
            return MusicList();
        }

    }
}
using Microsoft.AspNetCore.Mvc;
using Wba.Oefening.Movies.Core;
using Wba.Oefening.Movies.Web.Models;
using Wba.Oefening.Movies.Web.ViewModels;

namespace Wba.Oefening.Movies.Web.Controllers
{
    public class GenresController : Controller
    {
        private readonly GenreRepository _genreRepository = new();
        private readonly MovieRepository _movieRepository
            = new();
        public IActionResult Index()
        {
            GenresIndexViewModel genresIndexViewModel =
                new GenresIndexViewModel
                {
                    Genres = _genreRepository
                    .GetGenres()
                    .Select(g => new BaseViewModel
                    {
                        Id = g?.Id,
                        Name = g?.Name,
                    })
                };
            ViewBag.PageTitle = "Genres";
            return View(genresIndexViewModel);
        }
        public IActionResult ShowMovies(long id)
        {
            var genre = _genreRepository.GetGenres()
                .FirstOrDefault(g => g.Id == id);
            if(genre == null)
            {
                return View("Error", new ErrorViewModel());
            }
            GenresShowMoviesViewModel genresShowMoviesViewModel
                = new();
            genresShowMoviesViewModel.Genre = genre.Name;
            genresShowMoviesViewModel.Movies
                = _movieRepository
                .GetMovies()
                .Where(m => m.Genre.Id == id)
                .Select(m => new MoviesShowMovieViewModel
                {
                    Id = m?.Id,
                    Title = m?.Title,
                    Image = m?.Image
                });
            return View(genresShowMoviesViewModel);
        }
    }
}

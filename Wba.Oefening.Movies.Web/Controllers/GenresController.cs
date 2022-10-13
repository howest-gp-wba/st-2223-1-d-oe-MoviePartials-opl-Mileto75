using Microsoft.AspNetCore.Mvc;
using Wba.Oefening.Movies.Core;

namespace Wba.Oefening.Movies.Web.Controllers
{
    public class GenresController : Controller
    {
        private readonly GenreRepository _genreRepository
            = new();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowMovies(long id)
        {
            return View();
        }
    }
}

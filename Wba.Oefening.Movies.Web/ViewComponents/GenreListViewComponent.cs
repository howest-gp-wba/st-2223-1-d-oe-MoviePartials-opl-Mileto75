using Microsoft.AspNetCore.Mvc;
using Wba.Oefening.Movies.Core;
using Wba.Oefening.Movies.Web.Models;
using Wba.Oefening.Movies.Web.ViewModels;

namespace Wba.Oefening.Movies.Web.ViewComponents
{
    [ViewComponent(Name = "GenreList")]
    public class GenreListViewComponent
        : ViewComponent
    {
        //genrerepository
        private readonly GenreRepository
            _genreRepository = new();
        public async Task<IViewComponentResult>
            InvokeAsync()
        {
            //get the genres
            var genreListComponentViewModel
                = new GenreListComponentViewModel
                {
                    MenuLinks = _genreRepository
                    .GetGenres()
                    .Select(g =>
                    new ActionLink
                    {
                        Controller = "Genres",
                        Action = "ShowMovies",
                        Name = g.Name,
                        Id = g.Id,
                    })
                };
            //fill the model
            //pass tot the view
            return View(genreListComponentViewModel);
        }
    }
}


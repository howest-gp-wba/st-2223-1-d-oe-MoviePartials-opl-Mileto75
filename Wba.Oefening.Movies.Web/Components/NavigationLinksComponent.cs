using Microsoft.AspNetCore.Mvc;
using Wba.Oefening.Movies.Core.Services;
using Wba.Oefening.Movies.Web.ViewModels;

namespace Wba.Oefening.Movies.Web.Components
{
    [ViewComponent(Name = "NavigationLinks")]
    public class NavigationLinksComponent : ViewComponent
    {
        private readonly ActionLinkBuilder _actionLinkBuilder;
        public NavigationLinksComponent()
        {
            _actionLinkBuilder = new ActionLinkBuilder();
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var navigationLinksComponentViewModel
                = new NavigationLinksComponentViewModel
                {
                    NavigationLinks = _actionLinkBuilder
                    .GetLinks()
                };
            return View(navigationLinksComponentViewModel);
        }
    }
}


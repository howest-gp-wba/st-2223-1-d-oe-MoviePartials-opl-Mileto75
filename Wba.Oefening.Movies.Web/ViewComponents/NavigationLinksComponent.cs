using Microsoft.AspNetCore.Mvc;
using Wba.Oefening.Movies.Web.Services;
using Wba.Oefening.Movies.Web.ViewModels;

namespace Wba.Oefening.Movies.Web.ViewComponents
{
    [ViewComponent(Name = "NavigationLinks")]
    public class NavigationLinksComponent
        : ViewComponent
    {
        //props service class..?
        private readonly ActionLinkBuilder _actionLinkBuilder
            = new();
      
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //get the menu links from the service class
            //fill the model
            var navigationLinksComponentViewModel
                = new NavigationLinksComponentViewModel
                {
                    MenuLinks = _actionLinkBuilder
                    .GetMenuLinks()
                };
            //pass the model to the view
            return 
                await 
                Task.FromResult(View(navigationLinksComponentViewModel));
        }
    }
}

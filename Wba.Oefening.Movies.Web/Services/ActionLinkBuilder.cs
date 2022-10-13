using Wba.Oefening.Movies.Web.Models;

namespace Wba.Oefening.Movies.Web.Services
{
    public class ActionLinkBuilder
    {
        public IEnumerable<ActionLink>
            GetMenuLinks()
        {
            return new List<ActionLink>
            { 
                new ActionLink
                {
                    Controller = "Movies",
                    Action = "Index",
                    Name = "Movies"
                },
                new ActionLink
                {
                    Controller = "People",
                    Action = "ShowDirectors",
                    Name = "Directors"
                },
                new ActionLink
                {
                    Controller = "People",
                    Action = "ShowActors",
                    Name = "Actors"
                }
            };
        }
    }
}

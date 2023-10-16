using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wba.Oefening.Movies.Core.Services.Models;

namespace Wba.Oefening.Movies.Core.Services
{
    public class ActionLinkBuilder
    {
        public IEnumerable<ActionLink> GetLinks()
        {
            return new List<ActionLink>
            {
                new ActionLink{Controller="Movies", Action="Index",Name="Movies"},
                new ActionLink{Controller="People", Action="ShowDirectors",Name="Directors"},
                new ActionLink{Controller="People", Action="ShowActors",Name="Actors"},
                new ActionLink{Controller="Company", Action="ShowCompanies",Name="Companies"},
            };
        }
    }
}

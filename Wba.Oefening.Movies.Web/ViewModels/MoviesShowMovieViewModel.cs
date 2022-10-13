namespace Wba.Oefening.Movies.Web.ViewModels
{
    public class MoviesShowMovieViewModel
    {
        public Guid? Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<BaseViewModel> Directors { get; set; }
        public IEnumerable<BaseViewModel> Actors { get; set; }
        public  string Genre{ get; set; }
        public string Image{ get; set; }
    }
}

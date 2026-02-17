namespace BDF.DVDCentral.UI.Controllers
{
    public class MovieController : GenericController<Movie>
    {
        public MovieController(ApiClient httpClient,
                                   ILogger<GenericController<Movie>> logger)
                                   : base(httpClient, logger)
        { }
    }
}

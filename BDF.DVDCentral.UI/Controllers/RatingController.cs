namespace BDF.DVDCentral.UI.Controllers
{
    public class RatingController : GenericController<Rating>
    {
        public RatingController(HttpClient httpClient,
                                   ILogger<GenericController<Rating>> logger)
                                   : base(httpClient, logger)
        { }
    }
}

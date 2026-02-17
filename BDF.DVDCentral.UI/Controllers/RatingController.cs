namespace BDF.DVDCentral.UI.Controllers
{
    public class RatingController : GenericController<Rating>
    {
        public RatingController(ApiClient httpClient,
                                   ILogger<GenericController<Rating>> logger)
                                   : base(httpClient, logger)
        { }
    }
}

namespace BDF.DVDCentral.UI.Controllers
{
    public class GenreController : GenericController<Genre>
    {
        public GenreController(ApiClient httpClient,
                                   ILogger<GenericController<Genre>> logger)
                                   : base(httpClient, logger)
        {
            
        }
    }
}

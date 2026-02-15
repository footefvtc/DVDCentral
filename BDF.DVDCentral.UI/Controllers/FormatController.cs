namespace BDF.DVDCentral.UI.Controllers
{
    public class FormatController : GenericController<Format>
    {
        public FormatController(HttpClient httpClient,
                                   ILogger<GenericController<Format>> logger)
                                   : base(httpClient, logger)
        { }
    }
}

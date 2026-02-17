namespace BDF.DVDCentral.UI.Controllers
{
    public class FormatController : GenericController<Format>
    {
        public FormatController(ApiClient httpClient,
                                   ILogger<GenericController<Format>> logger)
                                   : base(httpClient, logger)
        { }
    }
}

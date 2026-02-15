namespace BDF.DVDCentral.UI.Controllers
{
    public class DirectorController : GenericController<Director>
    {
        public DirectorController(HttpClient httpClient,
                                   ILogger<GenericController<Director>> logger)
                                   : base(httpClient, logger)
        { }
    }
}

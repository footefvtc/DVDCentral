namespace BDF.DVDCentral.UI.Controllers
{
    public class DirectorController : GenericController<Director>
    {
        public DirectorController(ApiClient httpClient,
                                   ILogger<GenericController<Director>> logger)
                                   : base(httpClient, logger)
        { }
    }
}

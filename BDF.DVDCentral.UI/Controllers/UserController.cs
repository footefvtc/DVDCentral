namespace BDF.DVDCentral.UI.Controllers
{
    public class UserController : GenericController<User>
    {
        public UserController(ApiClient httpClient,
                                   ILogger<GenericController<User>> logger)
                                   : base(httpClient, logger)
        { }
    }
}

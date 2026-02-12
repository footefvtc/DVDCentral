namespace BDF.DVDCentral.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : GenericController<User, UserManager, DVDCentralEntities>
    {
        public UserController(ILogger<UserController> logger, DbContextOptions<DVDCentralEntities> options) : base(logger, options)
        {
        }
    }
}

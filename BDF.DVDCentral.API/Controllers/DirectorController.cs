

namespace BDF.DVDCentral.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : GenericController<Director, DirectorManager, DVDCentralEntities>
    {
        public DirectorController(ILogger<DirectorController> logger, DbContextOptions<DVDCentralEntities> options) : base(logger, options)
        {
        }
    }
}

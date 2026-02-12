namespace BDF.DVDCentral.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormatController : GenericController<Format, FormatManager, DVDCentralEntities>
    {
        public FormatController(ILogger<FormatController> logger, DbContextOptions<DVDCentralEntities> options) : base(logger, options)
        {
        }
    }
}

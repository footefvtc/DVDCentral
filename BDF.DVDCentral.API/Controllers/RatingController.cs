

namespace BDF.DVDCentral.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : GenericController<Rating, RatingManager, DVDCentralEntities>
    {
        public RatingController(ILogger<RatingController> logger, DbContextOptions<DVDCentralEntities> options) : base(logger, options)
        {
        }
    }
}

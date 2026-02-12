namespace BDF.DVDCentral.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : GenericController<Movie, MovieManager, DVDCentralEntities>
    {
        public MovieController(ILogger<MovieController> logger, DbContextOptions<DVDCentralEntities> options) : base(logger, options)
        {
        }
    }
}

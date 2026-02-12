namespace BDF.DVDCentral.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : GenericController<Genre, GenreManager, DVDCentralEntities>
    {
        public GenreController(ILogger<GenreController> logger, DbContextOptions<DVDCentralEntities> options) : base(logger, options)
        {
        }
    }
}

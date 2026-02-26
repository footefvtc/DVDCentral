
namespace BDF.DVDCentral.API.Controllers
{
    // T - Entity type - Director
    // U - Manager Type - DirectorManager
    // V - DbContext type - DVDCentralEntities

    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T, U, V> : ControllerBase where V : DbContext
    {
        protected DbContextOptions<V> options;
        protected readonly ILogger logger;
        dynamic manager;

        public GenericController(ILogger logger, DbContextOptions<V> options)
        {
            this.options = options;
            this.logger = logger;
            this.manager = (U)Activator.CreateInstance(typeof(U), options, logger)!;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<T>>> Get()
        {
            try
            {
                return Ok(await manager.LoadAsync());
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<T>> Get(Guid id)
        {
            try
            {
                return Ok(await manager.LoadByIdAsync(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("{rollback?}")]
        public async Task<ActionResult> Post([FromBody] T entity, bool rollback = false)
        {
            try
            {
                Guid id = await manager.InsertAsync(entity, rollback);
                return Ok(id);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut("{id}/{rollback?}")]
        public async Task<ActionResult> Put(Guid id, [FromBody] T entity, bool rollback = false)
        {
            try
            {
                int rowsaffected = await manager.UpdateAsync(entity, rollback);

                // Create a small bit of json to return
                var result = new Dictionary<string, string>();
                result.Add("rowsaffected", rowsaffected.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id}/{rollback?}")]
        public async Task<ActionResult> Delete(Guid id, bool rollback = false)
        {
            try
            {
                int rowsaffected = await manager.DeleteAsync(id, rollback);

                // Create a small bit of json to return
                var result = new Dictionary<string, string>();
                result.Add("rowsaffected", rowsaffected.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}

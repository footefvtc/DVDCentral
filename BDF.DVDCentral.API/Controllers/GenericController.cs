
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

        /// <summary>
        /// Retrieves all entities of type <typeparamref name="T"/> from the data store.
        /// </summary>
        /// <remarks>
        /// This endpoint calls the backing manager's asynchronous <c>LoadAsync</c> method to
        /// obtain a collection of entities. The result is returned inside an <see cref="ActionResult{T}"/>
        /// as an HTTP 200 (OK) response on success.
        /// </remarks>
        /// <returns>
        /// An <see cref="ActionResult{IEnumerable}"/> containing the collection of <typeparamref name="T"/>.
        /// On success the response will be HTTP 200 (OK) with the list in the response body.
        /// If an unhandled error occurs, the method returns HTTP 500 (Internal Server Error)
        /// and the exception message in the response body.
        /// </returns>
        /// <response code="200">Returns the list of entities</response>
        /// <response code="500">If an unexpected error occurs</response>
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

        /// <summary>
        /// Gets a single entity of type <typeparamref name="T"/> by its unique identifier.
        /// </summary>
        /// <param name="id">The id of the entity</param>
        /// <returns>T</returns>
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

        /// <summary>
        /// Creates a new entity of type <typeparamref name="T"/> in the data store.
        /// </summary>
        /// <param name="entity">Entity object</param>
        /// <param name="rollback">Should I rollback?</param>
        /// <returns></returns>
        [Authorize]
        [HttpPost("{rollback?}")]
        public async Task<ActionResult> Post([FromBody] T entity, bool rollback = false)
        {
            try
            {
                Guid id = await manager.InsertAsync(entity, rollback);
                var result = new Dictionary<string, string>();
                result.Add("id", id.ToString());
                return Ok(result);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Edits an existing entity of type <typeparamref name="T"/> in the data store.    
        /// </summary>
        /// <param name="id"></param>
        /// <param name="entity"></param>
        /// <param name="rollback"></param>
        /// <returns></returns>
        [Authorize]
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

        /// <summary>
        /// Deletes an existing entity of type <typeparamref name="T"/> from the data store by its unique identifier.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="rollback"></param>
        /// <returns></returns>
        [Authorize]
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

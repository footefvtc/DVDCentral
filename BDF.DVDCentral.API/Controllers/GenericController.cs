
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
        /// Get all records of type T from the database and return as JSON
        /// </summary>
        /// <returns></returns>
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
        /// Retrieves the resource of type T identified by the specified unique identifier.
        /// </summary>
        /// <remarks>If the resource is not found, a 404 Not Found response is returned. If an internal
        /// error occurs, a 500 Internal Server Error response is returned with the error message.</remarks>
        /// <param name="id">The unique identifier of the resource to retrieve. Must be a valid GUID.</param>
        /// <returns>An ActionResult containing the requested resource of type T if found; otherwise, a 404 Not Found response or
        /// a 500 Internal Server Error response.</returns>
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
        /// Inserts a new entity into the system and returns its unique identifier.
        /// </summary>
        /// <remarks>If the insertion fails, a 500 Internal Server Error status code is returned along
        /// with the error message.</remarks>
        /// <param name="entity">The entity to be inserted into the system. This parameter cannot be null.</param>
        /// <param name="rollback">Specifies whether to roll back the transaction if an error occurs. Defaults to <see langword="false"/>.</param>
        /// <returns>An ActionResult containing a dictionary with the unique identifier of the inserted entity.</returns>
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
        /// Given a unique identifier and an entity, updates the corresponding record in the database. If the update is successful, returns the number of rows affected as a JSON response. If an error occurs during the update process, returns a 500 Internal Server Error status code along with the error message. The optional rollback parameter allows for rolling back the transaction in case of an error, ensuring data integrity.
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
        /// Given a unique identifier and an entity, deletes the corresponding record in the database. If the delete is successful, returns the number of rows affected as a JSON response. If an error occurs during the update process, returns a 500 Internal Server Error status code along with the error message. The optional rollback parameter allows for rolling back the transaction in case of an error, ensuring data integrity.    
        /// </summary>
        /// <param name="id"></param>
        /// <param name="rollback"></param>
        /// <returns></returns>
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

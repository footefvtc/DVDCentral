namespace BDF.DVDCentral.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : GenericController<Customer, CustomerManager, DVDCentralEntities>
    {
        /// <summary>
        /// Initializes a new instance of the CustomerController class with the specified logger and database context
        /// options.
        /// </summary>
        /// <remarks>This constructor is intended for use with dependency injection to supply the required
        /// services for the controller.</remarks>
        /// <param name="logger">The logger used to record diagnostic and operational information for the CustomerController. Cannot be null.</param>
        /// <param name="options">The options used to configure the DVDCentralEntities database context, including connection settings. Cannot
        /// be null.</param>
        public CustomerController(ILogger<CustomerController> logger, DbContextOptions<DVDCentralEntities> options) : base(logger, options)
        {
        }
    }
}

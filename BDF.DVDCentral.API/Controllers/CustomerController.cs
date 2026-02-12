namespace BDF.DVDCentral.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : GenericController<Customer, CustomerManager, DVDCentralEntities>
    {
        public CustomerController(ILogger<CustomerController> logger, DbContextOptions<DVDCentralEntities> options) : base(logger, options)
        {
        }
    }
}

namespace BDF.DVDCentral.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : GenericController<Order, OrderManager, DVDCentralEntities>
    {
        public OrderController(ILogger<OrderController> logger, DbContextOptions<DVDCentralEntities> options) : base(logger, options)
        {
        }
    }
}

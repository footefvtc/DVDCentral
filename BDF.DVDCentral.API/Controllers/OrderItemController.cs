namespace BDF.DVDCentral.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemController : GenericController<OrderItem, OrderItemManager, DVDCentralEntities>
    {
        public OrderItemController(ILogger<OrderItemController> logger, DbContextOptions<DVDCentralEntities> options) : base(logger, options)
        {
        }
    }
}

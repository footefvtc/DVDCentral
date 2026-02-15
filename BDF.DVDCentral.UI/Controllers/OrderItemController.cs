namespace BDF.DVDCentral.UI.Controllers
{
    public class OrderItemController : GenericController<OrderItem>
    {
        public OrderItemController(HttpClient httpClient,
                                   ILogger<GenericController<OrderItem>> logger)
                                   : base(httpClient, logger)
        { }
    }
}

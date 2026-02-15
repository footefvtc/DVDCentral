namespace BDF.DVDCentral.UI.Controllers
{
    public class OrderController : GenericController<Order>
    {
        public OrderController(ApiClient httpClient,
                                   ILogger<GenericController<Order>> logger)
                                   : base(httpClient, logger)
        { }
    }
}

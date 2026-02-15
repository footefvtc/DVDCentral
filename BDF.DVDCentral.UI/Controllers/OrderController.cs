namespace BDF.DVDCentral.UI.Controllers
{
    public class OrderController : GenericController<Order>
    {
        public OrderController(HttpClient httpClient,
                                   ILogger<GenericController<Order>> logger)
                                   : base(httpClient, logger)
        { }
    }
}

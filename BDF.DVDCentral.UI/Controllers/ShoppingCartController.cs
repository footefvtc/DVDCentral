namespace BDF.DVDCentral.UI.Controllers
{
    public class ShoppingCartController : GenericController<ShoppingCart>
    {
        public ShoppingCartController(HttpClient httpClient,
                                   ILogger<GenericController<ShoppingCart>> logger)
                                   : base(httpClient, logger)
        { }
    }
}

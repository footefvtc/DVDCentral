namespace BDF.DVDCentral.UI.Controllers
{
    public class ShoppingCartController : GenericController<ShoppingCart>
    {
        public ShoppingCartController(ApiClient httpClient,
                                   ILogger<GenericController<ShoppingCart>> logger)
                                   : base(httpClient, logger)
        { }
    }
}

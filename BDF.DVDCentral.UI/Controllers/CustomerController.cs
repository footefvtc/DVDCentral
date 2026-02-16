namespace BDF.DVDCentral.UI.Controllers
{
    public class CustomerController : GenericController<Customer>
    {
        public CustomerController(ApiClient httpClient,
                                   ILogger<GenericController<Customer>> logger)
                                   : base(httpClient, logger)
        { }
        public CustomerController() : base()
        {
        }
    }
}

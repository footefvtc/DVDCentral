namespace BDF.DVDCentral.UI.Controllers
{
    public class CustomerController : GenericController<Customer>
    {
        public CustomerController(HttpClient httpClient,
                                   ILogger<GenericController<Customer>> logger)
                                   : base(httpClient, logger)
        { }
    }
}

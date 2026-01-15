using Microsoft.AspNetCore.Mvc;

namespace BDF.DVDCentral.UI.ViewComponents
{
    public class ShoppingCartComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            if (HttpContext.Session.GetObject<ShoppingCart>("cart") != null)
            {
                return View(HttpContext.Session.GetObject<ShoppingCart>("cart"));
            }
            else
            {
                return View(new ShoppingCart());
            }
        }
    }
}

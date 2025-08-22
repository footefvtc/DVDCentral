using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using FVTC.DVDCentral.UI.Models;

namespace FVTC.DVDCentral.UI.Controllers
{
    public class OrderItemController : Controller
    {
        // GET: OrderItemController
        public IActionResult Index()
        {
            ViewBag.Title = "List of All Order Items";
            return View(OrderItemManager.Load());
        }

        // GET: OrderItemController/Delete/5
        public IActionResult Remove(int id)
        {
            var item = OrderItemManager.LoadById(id);
            ViewBag.Title = "Delete Order Item " + item.Title;
            if (Authenticate.IsAuthenticated(HttpContext))
                return View(item);
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: OrderItemController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Remove(int id, bool rollback = false)
        {
            try
            {
                int result = OrderItemManager.Delete(id, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                var item = OrderItemManager.LoadById(id);
                ViewBag.Title = "Delete Order Item " + item.Title;
                ViewBag.Error = ex.Message;
                return View();
            }
        }
    }
}

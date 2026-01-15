using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using BDF.DVDCentral.UI.Models;

namespace BDF.DVDCentral.UI.Controllers
{
    public class OrderController : Controller
    {
        // GET: OrderController
        public ActionResult Index()
        {
            ViewBag.Title = "List of All Orders";
            return View(OrderManager.Load());
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            var item = OrderManager.LoadById(id);
            ViewBag.Title = "Order #" + item.Id + " Details";
            return View(item);
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            ViewBag.Title = "Create an Order";
            if (Authenticate.IsAuthenticated(HttpContext))
                return View();
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order order, bool rollback = false)
        {
            try
            {
                int result = OrderManager.Insert(order, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Title = "Create an Order";
                ViewBag.Error = ex.Message;
                return View(order);
            }
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            var item = OrderManager.LoadById(id);
            ViewBag.Title = "Edit Order #" + item.Id;
            if (Authenticate.IsAuthenticated(HttpContext))
                return View(item);
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Order order, bool rollback = false)
        {
            try
            {
                int result = OrderManager.Update(order, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                var item = OrderManager.LoadById(id);
                ViewBag.Title = "Edit Order #" + item.Id;
                ViewBag.Error = ex.Message;
                return View(order);
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            var item = OrderManager.LoadById(id);
            ViewBag.Title = "Delete Order #" + item.Id;
            if (Authenticate.IsAuthenticated(HttpContext))
                return View(item);
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Order order, bool rollback = false)
        {
            try
            {
                int result = OrderManager.Delete(id, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                var item = OrderManager.LoadById(id);
                ViewBag.Title = "Delete Order #" + item.Id;
                ViewBag.Error = ex.Message;
                return View(order);
            }
        }
    }
}

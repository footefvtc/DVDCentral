using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using BDF.DVDCentral.UI.Models;

namespace BDF.DVDCentral.UI.Controllers
{
    public class CustomerController : Controller
    {
        // GET: CustomerController
        public ActionResult Index()
        {
            ViewBag.Title = "List of All Customers";
            return View(CustomerManager.Load());
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            var item = CustomerManager.LoadById(id);
            ViewBag.Title = "Details for " + item.FirstName + " " + item.LastName;
            return View(item);
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            ViewBag.Title = "Create a Customer";
            if (Authenticate.IsAuthenticated(HttpContext))
                return View();
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer, bool rollback = false)
        {
            try
            {
                int userId = HttpContext.Session.GetObject<int>("userID");
                customer.UserId = userId;
                int result = CustomerManager.Insert(customer, rollback);
                customer.Id = result;
                return RedirectToAction("AssignToCustomer", "ShoppingCart");
            }
            catch (Exception ex)
            {
                ViewBag.Title = "Create a Customer";
                ViewBag.Error = ex.Message;
                return View(customer);
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            var item = CustomerManager.LoadById(id);
            ViewBag.Title = "Edit " + item.FirstName + " " + item.LastName;

            if (Authenticate.IsAuthenticated(HttpContext))
                return View(item);
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Customer customer, bool rollback = false)
        {
            try
            {
                int result = CustomerManager.Update(customer, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                var item = CustomerManager.LoadById(id);
                ViewBag.Title = "Edit " + item.FirstName + " " + item.LastName;
                ViewBag.Error = ex.Message;
                return View(customer);
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            var item = CustomerManager.LoadById(id);
            ViewBag.Title = "Delete " + item.FirstName + " " + item.LastName;

            if (Authenticate.IsAuthenticated(HttpContext))
                return View(item);
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Customer customer, bool rollback = false)
        {
            try
            {
                int result = CustomerManager.Delete(id, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                var item = CustomerManager.LoadById(id);
                ViewBag.Title = "Delete " + item.FirstName + " " + item.LastName;
                ViewBag.Error = ex.Message;
                return View(customer);
            }
        }
    }
}

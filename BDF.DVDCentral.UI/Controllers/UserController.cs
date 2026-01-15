using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using BDF.DVDCentral.PL;
using BDF.DVDCentral.UI.Extensions;
using BDF.DVDCentral.UI.Models;

namespace BDF.DVDCentral.UI.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "List of All Users";
            return View(UserManager.Load());
        }

        private void SetUser(User user)
        {
            HttpContext.Session.SetObject("user", user);

            if(user != null)
            {
                HttpContext.Session.SetObject("fullname", "Welcome " + user.UserFullName);
                HttpContext.Session.SetObject("userID", user.Id);
            }
            else
            {
                HttpContext.Session.SetObject("fullname", string.Empty);
                HttpContext.Session.SetObject("userID", string.Empty);
            }
        }

        public IActionResult Logout()
        {
            ViewBag.Title = "Logout";
            SetUser(null);
            return View();
        }

        public IActionResult Login(string returnUrl)
        {
            TempData["returnUrl"] = returnUrl;
            ViewBag.Title = "Login";
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            try
            {
                bool result = UserManager.Login(user);
                SetUser(user);

                if (TempData["returnUrl"] != null)
                    return Redirect(TempData["returnUrl"]?.ToString());
                return RedirectToAction(nameof(Index), "Movie");
            }
            catch (Exception ex)
            {
                ViewBag.Title = "Login";
                ViewBag.Error = ex.Message;
                return View(user);
            }
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            ViewBag.Title = "Create a User";
            if (Authenticate.IsAuthenticated(HttpContext))
                return View();
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user, bool rollback = false)
        {
            try
            {
                int result = UserManager.Insert(user, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Title = "Create a User";
                ViewBag.Error = ex.Message;
                return View(user);
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            var item = UserManager.LoadById(id);
            ViewBag.Title = "Edit " + item.FirstName + " " + item.LastName;
            if (Authenticate.IsAuthenticated(HttpContext))
                return View(item);
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: UserController/Edit/5
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
                var item = UserManager.LoadById(id);
                ViewBag.Title = "Edit " + item.FirstName + " " + item.LastName;
                ViewBag.Error = ex.Message;
                return View(customer);
            }
        }

        public ActionResult Seed()
        {
            UserManager.Seed();
            ViewBag.Title = "Seed";
            return View();
        }
    }
}

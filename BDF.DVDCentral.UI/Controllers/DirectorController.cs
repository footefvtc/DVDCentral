using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using BDF.DVDCentral.UI.Models;

namespace BDF.DVDCentral.UI.Controllers
{
    public class DirectorController : Controller
    {
        // GET: DirectorController
        public ActionResult Index()
        {
            ViewBag.Title = "List of All Directors";
            return View(DirectorManager.Load());
        }

        // GET: DirectorController/Details/5
        public ActionResult Details(int id)
        {
            var item = DirectorManager.LoadById(id);
            ViewBag.Title = "Details for " + item.FullName;
            return View(item);
        }

        // GET: DirectorController/Create
        public ActionResult Create()
        {
            ViewBag.Title = "Create a Director";
            if (Authenticate.IsAuthenticated(HttpContext))
                return View();
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: DirectorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Director director, bool rollback = false)
        {
            try
            {
                int result = DirectorManager.Insert(director, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Title = "Create a Director";
                ViewBag.Error = ex.Message;
                return View(director);
            }
        }

        // GET: DirectorController/Edit/5
        public ActionResult Edit(int id)
        {
            var item = DirectorManager.LoadById(id);
            ViewBag.Title = "Edit " + item.FullName;
            if (Authenticate.IsAuthenticated(HttpContext))
                return View(item);
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: DirectorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Director director, bool rollback = false)
        {
            try
            {
                int result = DirectorManager.Update(director, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                var item = DirectorManager.LoadById(id);
                ViewBag.Title = "Edit " + item.FullName;
                ViewBag.Error = ex.Message;
                return View(director);
            }
        }

        // GET: DirectorController/Delete/5
        public ActionResult Delete(int id)
        {
            var item = DirectorManager.LoadById(id);
            ViewBag.Title = "Delete " + item.FullName;
            if (Authenticate.IsAuthenticated(HttpContext))
                return View(item);
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: DirectorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Director director, bool rollback = false)
        {
            try
            {
                int result = DirectorManager.Delete(id, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                var item = DirectorManager.LoadById(id);
                ViewBag.Title = "Delete " + item.FullName;
                ViewBag.Error = ex.Message;
                return View(director);
            }
        }
    }
}

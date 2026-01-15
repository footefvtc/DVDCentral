using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using BDF.DVDCentral.UI.Models;

namespace BDF.DVDCentral.UI.Controllers
{
    public class GenreController : Controller
    {
        // GET: GenreController
        public ActionResult Index()
        {
            ViewBag.Title = "List of All Genres";
            return View(GenreManager.Load());
        }

        // GET: GenreController/Details/5
        public ActionResult Details(int id)
        {
            var item = GenreManager.LoadById(id);
            ViewBag.Title = "Details for " + item.Description;
            return View(item);
        }

        // GET: GenreController/Create
        public ActionResult Create()
        {
            ViewBag.Title = "Create a Genre";
            if (Authenticate.IsAuthenticated(HttpContext))
                return View();
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: GenreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Genre genre, bool rollback = false)
        {
            try
            {
                int result = GenreManager.Insert(genre, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Title = "Create a Genre";
                ViewBag.Error = ex.Message;
                return View(genre);
            }
        }

        // GET: GenreController/Edit/5
        public ActionResult Edit(int id)
        {
            var item = GenreManager.LoadById(id);
            ViewBag.Title = "Edit " + item.Description;
            if (Authenticate.IsAuthenticated(HttpContext))
                return View(item);
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: GenreController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Genre genre, bool rollback = false)
        {
            try
            {
                int result = GenreManager.Update(genre, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                var item = GenreManager.LoadById(id);
                ViewBag.Title = "Edit " + item.Description;
                ViewBag.Error = ex.Message;
                return View(genre);
            }
        }

        // GET: GenreController/Delete/5
        public ActionResult Delete(int id)
        {
            var item = GenreManager.LoadById(id);
            ViewBag.Title = "Delete " + item.Description;
            if (Authenticate.IsAuthenticated(HttpContext))
                return View(item);
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: GenreController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Genre genre, bool rollback = false)
        {
            try
            {
                int result = GenreManager.Delete(id, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                var item = GenreManager.LoadById(id);
                ViewBag.Title = "Delete " + item.Description;
                ViewBag.Error = ex.Message;
                return View(genre);
            }
        }
    }
}

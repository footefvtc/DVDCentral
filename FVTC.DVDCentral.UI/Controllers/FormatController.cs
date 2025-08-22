using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using FVTC.DVDCentral.UI.Models;

namespace FVTC.DVDCentral.UI.Controllers
{
    public class FormatController : Controller
    {
        // GET: FormatController
        public ActionResult Index()
        {
            ViewBag.Title = "List of All Formats";
            return View(FormatManager.Load());
        }

        // GET: FormatController/Details/5
        public ActionResult Details(int id)
        {
            var item = FormatManager.LoadById(id);
            ViewBag.Title = "Details for " + item.Description;
            return View(item);
        }

        // GET: FormatController/Create
        public ActionResult Create()
        {
            ViewBag.Title = "Create a Format";
            if (Authenticate.IsAuthenticated(HttpContext))
                return View();
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: FormatController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Format format, bool rollback = false)
        {
            try
            {
                int result = FormatManager.Insert(format, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Title = "Create a Format";
                ViewBag.Error = ex.Message;
                return View(format);
            }
        }

        // GET: FormatController/Edit/5
        public ActionResult Edit(int id)
        {
            var item = FormatManager.LoadById(id);
            ViewBag.Title = "Edit " + item.Description;
            if (Authenticate.IsAuthenticated(HttpContext))
                return View(item);
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: FormatController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Format format, bool rollback = false)
        {
            try
            {
                int result = FormatManager.Update(format, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                var item = FormatManager.LoadById(id);
                ViewBag.Title = "Edit " + item.Description;
                ViewBag.Error = ex.Message;
                return View(format);
            }
        }

        // GET: FormatController/Delete/5
        public ActionResult Delete(int id)
        {
            var item = FormatManager.LoadById(id);
            ViewBag.Title = "Delete " + item.Description;
            if (Authenticate.IsAuthenticated(HttpContext))
                return View(item);
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: FormatController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Format format, bool rollback = false)
        {
            try
            {
                int result = FormatManager.Delete(id, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                var item = FormatManager.LoadById(id);
                ViewBag.Title = "Delete " + item.Description;
                ViewBag.Error = ex.Message;
                return View(format);
            }
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Design;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using BDF.DVDCentral.UI.Models;
using BDF.DVDCentral.UI.ViewModels;
using BDF.DVDCentral.BL.Models;

namespace BDF.DVDCentral.UI.Controllers
{
    public class RatingController : Controller
    {
        #region "Pre-WebAPI"
        // GET: RatingController
        public ActionResult Index()
        {
            ViewBag.Title = "List of All Ratings";
            return View(RatingManager.Load());
        }

        // GET: RatingController/Details/5
        public ActionResult Details(int id)
        {
            var item = RatingManager.LoadById(id);
            ViewBag.Title = "Details for " + item.Description;
            return View(item);
        }

        // GET: RatingController/Create
        public ActionResult Create()
        {
            ViewBag.Title = "Create a Rating";
            if (Authenticate.IsAuthenticated(HttpContext))
                return View();
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: RatingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Rating rating, bool rollback = false)
        {
            try
            {
                int result = RatingManager.Insert(rating, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Title = "Create a Rating";
                ViewBag.Error = ex.Message;
                return View(rating);
            }
        }

        // GET: RatingController/Edit/5
        public ActionResult Edit(int id)
        {
            var item = RatingManager.LoadById(id);
            ViewBag.Title = "Edit " + item.Description;
            if (Authenticate.IsAuthenticated(HttpContext))
                return View(item);
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: RatingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Rating rating, bool rollback = false)
        {
            try
            {
                int result = RatingManager.Update(rating, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                var item = RatingManager.LoadById(id);
                ViewBag.Title = "Edit " + item.Description;
                ViewBag.Error = ex.Message;
                return View(rating);
            }
        }

        // GET: RatingController/Delete/5
        public ActionResult Delete(int id)
        {
            var item = RatingManager.LoadById(id);
            ViewBag.Title = "Delete " + item.Description;
            if (Authenticate.IsAuthenticated(HttpContext))
                return View(item);
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: RatingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Rating rating, bool rollback = false)
        {
            try
            {
                int result = RatingManager.Delete(id, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                var item = RatingManager.LoadById(id);
                ViewBag.Title = "Delete " + item.Description;
                ViewBag.Error = ex.Message;
                return View(rating);
            }
        }
        #endregion

        #region "Web-API"

        private static HttpClient InitializeClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7156/api/");
            return client;
        }

        public IActionResult Get()
        {
            ViewBag.Title = "List of All Ratings";
            HttpClient client = InitializeClient();

            // Call the API
            HttpResponseMessage response = client.GetAsync("Rating").Result;

            //Parse the result
            string result = response.Content.ReadAsStringAsync().Result;
            dynamic items = (JArray)JsonConvert.DeserializeObject(result);
            List<Rating> ratings = items.ToObject<List<Rating>>();

            return View(nameof(Index), ratings);
        }

        public IActionResult GetOne(int id)
        {
            ViewBag.Title = "Rating Details";
            HttpClient client = InitializeClient();

            // Call the API
            HttpResponseMessage response = client.GetAsync("Rating/" + id).Result;

            //Parse the result
            string result = response.Content.ReadAsStringAsync().Result;
            dynamic item = JsonConvert.DeserializeObject(result);
            Rating rating = item.ToObject<Rating>();

            return View(nameof(Details), rating);
        }

        public IActionResult Insert()
        {
            ViewBag.Title = "Create a Rating";
            HttpClient client = InitializeClient();

            return View(nameof(Create));
        }

        [HttpPost]
        public IActionResult Insert(Rating rating)
        {
            try
            {
                HttpClient client = InitializeClient();

                string serializedObject = JsonConvert.SerializeObject(rating);
                var content = new StringContent(serializedObject);
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                // Call the API
                HttpResponseMessage response = client.PostAsync("Rating", content).Result;

                return RedirectToAction(nameof(Get));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(nameof(Create));
            }
        }

        public IActionResult Update(int id)
        {
            ViewBag.Title = "Update";
            HttpClient client = InitializeClient();

            // Call the API
            HttpResponseMessage response = client.GetAsync("Rating/" + id).Result;

            //Parse the result
            string result = response.Content.ReadAsStringAsync().Result;
            dynamic item = JsonConvert.DeserializeObject(result);
            Rating rating = item.ToObject<Rating>();


            return View(nameof(Edit), rating);
        }

        [HttpPost]
        public IActionResult Update(int id, Rating rating)
        {
            try
            {
                HttpClient client = InitializeClient();

                string serializedObject = JsonConvert.SerializeObject(rating);
                var content = new StringContent(serializedObject);
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                // Call the API
                HttpResponseMessage response = client.PutAsync("Rating/" + id, content).Result;

                return RedirectToAction(nameof(Get));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(nameof(Edit));
            }
        }

        public IActionResult Remove(int id)
        {
            ViewBag.Title = "Remove Rating";
            HttpClient client = InitializeClient();

            // Call the API
            HttpResponseMessage response = client.GetAsync("Rating/" + id).Result;

            //Parse the result
            string result = response.Content.ReadAsStringAsync().Result;
            dynamic item = JsonConvert.DeserializeObject(result);
            Rating rating = item.ToObject<Rating>();

            return View(nameof(Delete), rating);
        }

        [HttpPost]
        public IActionResult Remove(int id, Rating rating)
        {
            try
            {
                HttpClient client = InitializeClient();

                // Call the API
                HttpResponseMessage response = client.DeleteAsync("Rating/" + id).Result;

                return RedirectToAction(nameof(Get));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View(nameof(Delete), rating);
            }
        }

        #endregion
    }
}

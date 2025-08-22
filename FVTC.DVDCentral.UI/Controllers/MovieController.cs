using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using FVTC.DVDCentral.BL.Models;
using FVTC.DVDCentral.UI.Models;
using FVTC.DVDCentral.UI.ViewModels;

namespace FVTC.DVDCentral.UI.Controllers
{
    public class MovieController : Controller
    {
        private readonly IWebHostEnvironment _host;
        public MovieController(IWebHostEnvironment host)
        {
            _host = host;
        }

        // GET: MovieController
        public IActionResult Index()
        {
            ViewBag.Title = "List of All Movies";
            var movies = MovieManager.Load();
            return View("IndexCard", movies);
        }

        // Filter the movie by genreId
        public IActionResult Browse(int id)
        {
            var results = GenreManager.LoadById(id);
            ViewBag.Title = "List of " + results.Description + " Movies";
            return View(nameof(Index), MovieManager.Load(id));
        }

        // GET: MovieController/Details/5
        public IActionResult Details(int id)
        {
            var item = MovieManager.LoadById(id);
            ViewBag.Title = "Details for " + item.Title;
            return View(item);
        }

        // GET: MovieController/Delete/5
        public IActionResult Delete(int id)
        {
            if (Authenticate.IsAuthenticated(HttpContext))
            {
                var item = MovieManager.LoadById(id);
                ViewBag.Title = "Delete " + item.Title;

                return View(item);
            }
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        public IActionResult Delete(int id, Movie movie, bool rollback = false)
        {
            try
            {
                int result = MovieManager.Delete(id, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                var item = MovieManager.LoadById(id);
                ViewBag.Title = "Delete " + item.Title;
                ViewBag.Error = ex.Message;
                return View(movie);
            }
        }

        // GET: MovieController/Edit/5
        public IActionResult Edit(int id)
        {
            if (Authenticate.IsAuthenticated(HttpContext))
            {
                MovieVM movieVM = new MovieVM(id);

                ViewBag.Title = "Edit " + movieVM.Movie.Title;
                HttpContext.Session.SetObject("genreids", movieVM.GenreIds);
                return View(movieVM);
            }
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, MovieVM movieVM, bool rollback = false)
        {
            try
            {
                IEnumerable<int> newGenreIds = new List<int>();
                if (movieVM.GenreIds != null)
                    newGenreIds = movieVM.GenreIds;

                IEnumerable<int> oldGenreIds = new List<int>();
                oldGenreIds = GetObject();

                IEnumerable<int> deletes = oldGenreIds.Except(newGenreIds);
                IEnumerable<int> adds = newGenreIds.Except(oldGenreIds);

                deletes.ToList().ForEach(d => MovieGenreManager.Delete(id, d));
                adds.ToList().ForEach(a => MovieGenreManager.Insert(id, a));

                // Process the image
                if(movieVM.File != null)
                {
                    movieVM.Movie.ImagePath = movieVM.File.FileName;

                    string path = _host.WebRootPath + "\\images\\";

                    using (var stream = System.IO.File.Create(path + movieVM.File.FileName))
                    {
                        movieVM.File.CopyTo(stream);
                        ViewBag.Message = "File Uploaded Successfully.";
                    }
                }

                int result = MovieManager.Update(movieVM.Movie, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                movieVM.Movie = MovieManager.LoadById(id);
                ViewBag.Title = "Edit " + movieVM.Movie.Title;

                ViewBag.Error = ex.Message;
                return View(movieVM);
            }
        }

        private IEnumerable<int> GetObject()
        {
            if (HttpContext.Session.GetObject<IEnumerable<int>>("genreids") != null)
                return HttpContext.Session.GetObject<IEnumerable<int>>("genreids");
            else
                return null;
        }

        // GET: MovieController/Create
        public IActionResult Create()
        {
            if (Authenticate.IsAuthenticated(HttpContext))
            {
                ViewBag.Title = "Create a Movie";

                MovieVM movieVM = new MovieVM();

                //movieVM.Movie = new Movie();
                //movieVM.Genres = GenreManager.Load();
                //movieVM.Directors = DirectorManager.Load();
                //movieVM.Ratings = RatingManager.Load();
                //movieVM.Formats = FormatManager.Load();

                return View(movieVM);
            }
            else
                return RedirectToAction("Login", "User", new { returnUrl = UriHelper.GetDisplayUrl(HttpContext.Request) });
        }

        // POST: MovieController/Create
        [HttpPost]
        public IActionResult Create(MovieVM movieVM, bool rollback = false)
        {
            try
            {
                IEnumerable<int> newGenreIds = new List<int>();
                if (movieVM.GenreIds != null)
                    newGenreIds = movieVM.GenreIds;

                newGenreIds.ToList().ForEach(a => MovieGenreManager.Insert(movieVM.Movie.Id, a));

                // Process the image
                if (movieVM.File != null)
                {
                    movieVM.Movie.ImagePath = movieVM.File.FileName;

                    string path = _host.WebRootPath + "\\images\\";

                    using (var stream = System.IO.File.Create(path + movieVM.File.FileName))
                    {
                        movieVM.File.CopyTo(stream);
                        ViewBag.Message = "File Uploaded Successfully.";
                    }
                }
                
                int result = MovieManager.Insert(movieVM.Movie, rollback);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Title = "Create a Movie";
                ViewBag.Error = ex.Message;
                return View(movieVM);
            }
        }
    }
}

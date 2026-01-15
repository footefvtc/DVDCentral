using Microsoft.AspNetCore.Mvc;

namespace BDF.DVDCentral.UI.ViewComponents
{
    public class Sidebar : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View(GenreManager.Load().OrderBy(g => g.Description)); 
        }
    }
}

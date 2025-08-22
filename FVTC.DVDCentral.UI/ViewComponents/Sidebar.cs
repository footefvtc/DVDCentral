using Microsoft.AspNetCore.Mvc;

namespace FVTC.DVDCentral.UI.ViewComponents
{
    public class Sidebar : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View(GenreManager.Load().OrderBy(g => g.Description)); 
        }
    }
}

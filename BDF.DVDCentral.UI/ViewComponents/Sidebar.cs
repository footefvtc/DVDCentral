using BDF.DVDCentral.UI.Models;
using FVTC.Utility;
using Microsoft.AspNetCore.Mvc;

namespace FVTC.DVDCentral.UI.ViewComponents
{
    public class Sidebar : ViewComponent
    {
        private ApiClient apiClient;

        public Sidebar(ApiClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public IViewComponentResult Invoke()
        {
            var entities = apiClient.GetList<Genre>(typeof(Genre).Name);
            return View(entities);
        }
    }
}

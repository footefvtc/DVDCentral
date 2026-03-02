using BDF.DVDCentral.UI.Models;
using Microsoft.AspNetCore.Http.Extensions;
//using Microsoft.AspNetCore.Mvc;

namespace BDF.DVDCentral.UI.Controllers
{
    public class AuthenticateController : Controller
    {
        public IActionResult AuthenticateUser()
        {
            if (!Authenticate.IsAuthenticated(HttpContext))
            {
                return RedirectToAction("Login",
                                        "User",
                                        new
                                        {
                                            returnUrl = (HttpContext?.Request == null ? "/"
                                        : UriHelper.GetDisplayUrl(HttpContext.Request))
                                        });

            }
            return null!;   // Is authenticated...continue on.
        }
    }
}

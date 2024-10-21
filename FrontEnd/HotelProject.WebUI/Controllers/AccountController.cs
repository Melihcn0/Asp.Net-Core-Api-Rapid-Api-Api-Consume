using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            // Oturumu sonlandır
            HttpContext.SignOutAsync();

            // Giriş sayfasına yönlendirme
            return RedirectToAction("Index", "Login");
        }
    }
}

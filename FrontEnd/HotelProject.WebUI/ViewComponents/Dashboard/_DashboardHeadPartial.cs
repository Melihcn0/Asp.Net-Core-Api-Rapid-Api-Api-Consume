using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Ocsp;
using System.Globalization;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardHeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

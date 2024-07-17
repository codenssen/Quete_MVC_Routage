using Microsoft.AspNetCore.Mvc;

namespace Quete_MVC_Routage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

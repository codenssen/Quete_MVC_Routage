using Microsoft.AspNetCore.Mvc;

namespace Quete_MVC_Routage.Controllers
{
    public class HelloController : Controller
    {
        [Route("Say")]
        public IActionResult SayHello()
        {
            return Content("Hello !");
        }

        [Route("Yell")]
        public IActionResult YellHello()
        {
            return Content("HELLO !");
        }

     
    }
}

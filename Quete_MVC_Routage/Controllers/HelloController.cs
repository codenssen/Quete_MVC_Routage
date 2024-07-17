using Microsoft.AspNetCore.Mvc;

namespace Quete_MVC_Routage.Controllers
{
    public class HelloController : Controller
    {
        
        public IActionResult SayHello()
        {
            return Content("Hello !");
        }

        [Route("Say")]
        public IActionResult SayHelloAttribut()
        {
            return Content("Hello !");
        }

        
        public IActionResult YellHello()
        {
            return Content("HELLO !");
        }

        [Route("Yell")]
        public IActionResult YellHelloAttribut()
        {
            return Content("HELLO !");
        }


    }
}

using Microsoft.AspNetCore.Mvc;

namespace _02PC_IdentityChatEmail.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Page403()
        {
            return View();
        }

        public IActionResult Page401()
        {
            return View();
        }
    }
}

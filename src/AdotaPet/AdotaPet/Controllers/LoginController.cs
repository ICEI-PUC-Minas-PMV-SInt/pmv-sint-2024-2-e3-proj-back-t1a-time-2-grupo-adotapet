using Microsoft.AspNetCore.Mvc;

namespace AdotaPet.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

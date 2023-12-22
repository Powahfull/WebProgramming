using Microsoft.AspNetCore.Mvc;

namespace Lighthouse.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

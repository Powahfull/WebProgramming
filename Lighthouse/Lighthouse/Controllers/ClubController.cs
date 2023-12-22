using Microsoft.AspNetCore.Mvc;

namespace Lighthouse.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

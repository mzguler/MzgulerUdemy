using Microsoft.AspNetCore.Mvc;

namespace MzgulerUdemy.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

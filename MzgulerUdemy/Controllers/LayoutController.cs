using Microsoft.AspNetCore.Mvc;

namespace MzgulerUdemy.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

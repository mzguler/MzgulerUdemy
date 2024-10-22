using Microsoft.AspNetCore.Mvc;

namespace MzgulerUdemy.ViewComponents
{
    public class _NavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

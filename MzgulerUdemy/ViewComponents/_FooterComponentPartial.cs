using Microsoft.AspNetCore.Mvc;

namespace MzgulerUdemy.ViewComponents
{
    public class _FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

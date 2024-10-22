using Microsoft.AspNetCore.Mvc;

namespace MzgulerUdemy.ViewComponents
{
    public class _PortfolioComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

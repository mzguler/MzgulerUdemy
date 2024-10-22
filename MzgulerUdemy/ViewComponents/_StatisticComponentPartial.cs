using Microsoft.AspNetCore.Mvc;

namespace MzgulerUdemy.ViewComponents
{
    public class _StatisticComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

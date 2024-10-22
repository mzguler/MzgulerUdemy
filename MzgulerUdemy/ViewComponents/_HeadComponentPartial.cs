using Microsoft.AspNetCore.Mvc;

namespace MzgulerUdemy.ViewComponents
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(); 
        }
    }
}

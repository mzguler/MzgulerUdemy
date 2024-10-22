using Microsoft.AspNetCore.Mvc;
using MzgulerUdemy.DAL.Context;

namespace MzgulerUdemy.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}

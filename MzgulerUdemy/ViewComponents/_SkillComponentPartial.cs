using Microsoft.AspNetCore.Mvc;
using MzgulerUdemy.DAL.Context;

namespace MzgulerUdemy.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values =context.Skills.ToList();
            return View(values);
        }
    }
}

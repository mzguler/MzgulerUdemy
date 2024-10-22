using Microsoft.AspNetCore.Mvc;
using MzgulerUdemy.DAL.Context;

namespace MzgulerUdemy.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        PortfolioContext portfolioContext = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
}

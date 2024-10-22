using Microsoft.AspNetCore.Mvc;

namespace MzgulerUdemy.ViewComponents.LayoutViewComponents
{
	public class _LayoutHeadComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View(); 
		}
	}
}

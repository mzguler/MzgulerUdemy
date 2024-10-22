using Microsoft.AspNetCore.Mvc;

namespace MzgulerUdemy.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View(); 
		}

	}
}

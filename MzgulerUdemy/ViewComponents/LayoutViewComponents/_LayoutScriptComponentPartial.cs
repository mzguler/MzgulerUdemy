using Microsoft.AspNetCore.Mvc;

namespace MzgulerUdemy.ViewComponents.LayoutViewComponents
{
	public class _LayoutScriptComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View(); 
		}
	}
}

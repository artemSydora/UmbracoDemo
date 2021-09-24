using Microsoft.AspNetCore.Mvc;

namespace GoalEnvision.Web.Features.Components.Hero
{
	public class HeroViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke(HeroViewModel heroViewModel)
		{
			return View(heroViewModel);
		}
	}
}

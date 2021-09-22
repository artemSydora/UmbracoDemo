using GoalEnvision.Web.Features.Services;
using Microsoft.AspNetCore.Mvc;

namespace GoalEnvision.Web.Features.Components.Footer
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly SettingsService _settingsService;

        public FooterViewComponent(SettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        public IViewComponentResult Invoke()
        {
            var settings = _settingsService.GetSettings();

            return View(new FooterViewModel()
            {
                Copyright = settings.Copyright,
                Logo = settings.Logo,
                FooterNavigationMenus = settings.FooterNavigationMenus,
                SocialsMenu = settings.SocialsMenu,
                Description = settings.Description,
                Taglines = settings.Taglines
            });
        }
    }
}

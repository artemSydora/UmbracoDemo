using GoalEnvision.Web.Features.Shared.SiteSettings;
using Microsoft.AspNetCore.Mvc;

namespace GoalEnvision.Web.Features.Shared.Components.Header
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly SettingsService _settingsService;

        public HeaderViewComponent(SettingsService settingsService)
        {
            _settingsService = settingsService;
        }


        public IViewComponentResult Invoke()
        {
            var settings = _settingsService.GetSettings();
            return View(new HeaderViewModel()
            {
                HeaderNavigationMenu = settings.HeaderNavigationMenu,
                Logo = settings.Logo,
                CurrentPage = settings.Parent
            });
        }
    }
}

using System.Collections.Generic;
using GoalEnvision.Web.Features.Services;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace GoalEnvision.Web.Features.Components.Header
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly SettingsService _settingsService;
        private readonly CultureService _cultureService;

        public HeaderViewComponent(SettingsService settingsService, CultureService cultureService)
        {
            _settingsService = settingsService;
            _cultureService = cultureService;
        }

        public IViewComponentResult Invoke(string url)
        {
            var settings = _settingsService.GetSettings();

            return View(new HeaderViewModel()
            {
                HeaderNavigationMenu = settings.HeaderNavigationMenu,
                Logo = settings.Logo,
                CurrentPageUrl = url,
                CurrentPageUrls = _cultureService.GetCurrentPageUrls(url)
            });
        }
    }
}

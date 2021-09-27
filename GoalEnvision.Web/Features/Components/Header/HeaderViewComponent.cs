using System.Linq;
using GoalEnvision.Web.Features.Services;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Extensions;

namespace GoalEnvision.Web.Features.Components.Header
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly SettingsService _settingsService;
        private readonly CultureSwitcherService _linksService;

        public HeaderViewComponent(SettingsService settingsService, CultureSwitcherService linksService)
        {
            _settingsService = settingsService;
            _linksService = linksService;
        }

        public IViewComponentResult Invoke(IPublishedContent currentPage)
        {
            var settings = _settingsService.GetSettings();
            var languageSwitcherLinks = _linksService.GetLinks(currentPage);

            return View(new HeaderViewModel()
            {
                CultureSwitcher = new CultureSwitcherModel
                {
                    IsVisible = languageSwitcherLinks.Count() > 1,
                    Links = languageSwitcherLinks
                },
                Logo = settings.Logo,
                NavigationMenu = new NavigationMenuModel
                {
                    CurrentPageUrl = currentPage.Url(),
                    Links = settings.HeaderNavigationMenu
                }
            });
        }
    }
}

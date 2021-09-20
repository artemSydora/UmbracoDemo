using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.Common;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Extensions;

namespace GoalEnvision.Web.Features.Shared.Components.Footer
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly UmbracoHelper _umbracoHelper;

        public FooterViewComponent(UmbracoHelper umbracoHelper)
        {
            _umbracoHelper = umbracoHelper;
        }
        public Settings GetSettings()
        {
            var settings = _umbracoHelper.ContentAtRoot()
                .FirstOrDefault()
                .FirstChild<Settings>();

            return settings;
        }

        public IViewComponentResult Invoke()
        {
            var settings = GetSettings();

            return View(new FooterViewModel()
            {
                Copyright = settings.Copyright,
                FooterLogo = settings.FooterLogo,
                FooterNavigationMenus = settings.FooterNavigationMenus,
                FooterSocialsMenu = settings.FooterSocialsMenu,
                GeneralInfo = settings.GeneralInfo,
                TaglineList = settings.TaglineList
            });
        }
    }
}

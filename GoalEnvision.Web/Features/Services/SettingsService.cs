using System.Linq;
using Umbraco.Cms.Web.Common;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Extensions;

namespace GoalEnvision.Web.Features.Services
{
    public class SettingsService
    {
        private readonly UmbracoHelper _umbracoHelper;

        public SettingsService(UmbracoHelper umbracoHelper)
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
    }
}

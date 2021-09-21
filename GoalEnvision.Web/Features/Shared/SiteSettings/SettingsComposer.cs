using GoalEnvision.Web.Features.Shared.SiteSettings;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace UmbracoNineDemoSite.Core.Features.Shared.Settings
{
    public class SettingsComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.Services.AddTransient<SettingsService>();
        }
    }
}

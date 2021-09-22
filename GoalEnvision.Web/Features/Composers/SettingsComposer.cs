using GoalEnvision.Web.Features.Services;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace UmbracoNineDemoSite.Core.Features.Composers
{
    public class SettingsComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.Services.AddTransient<SettingsService>();
        }
    }
}

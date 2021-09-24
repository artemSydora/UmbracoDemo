using GoalEnvision.Web.Features.Services;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace GoalEnvision.Web.Features.Composers
{
    public class CultureComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.Services.AddTransient<CultureService>();
        }
    }
}

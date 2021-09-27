using Umbraco.Cms.Core.Models;

namespace GoalEnvision.Web.Features.Components.Hero
{
    public class HeroViewModel
    {
        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string Description { get; set; }

        public MediaWithCrops Image { get; set; }

        public Link Button { get; set; }

        public Link Link { get; set; }
    }
}

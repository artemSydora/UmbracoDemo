using Umbraco.Cms.Core.Models;

namespace GoalEnvision.Web.Features.Components.Header
{
    public class HeaderViewModel
    {
        public CultureSwitcherModel CultureSwitcher { get; set; }

        public MediaWithCrops Logo { get; set; }

        public NavigationMenuModel NavigationMenu { get; set; }
    }
}

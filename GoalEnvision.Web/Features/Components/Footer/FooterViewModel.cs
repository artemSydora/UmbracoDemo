using System.Collections.Generic;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace GoalEnvision.Web.Features.Components.Footer
{
    public class FooterViewModel
    {

        public string Copyright { get; set; }

        public string Description { get; set; }

        public MediaWithCrops Logo { get; set; }

        public IEnumerable<NavigationMenu> FooterNavigationMenus { get; set; }

        public IEnumerable<SocialsMenu> SocialsMenu { get; set; }

        public IEnumerable<string> Taglines { get; set; }
    }
}

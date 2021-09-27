using System.Collections.Generic;
using Umbraco.Cms.Core.Models;

namespace GoalEnvision.Web.Features.Components.Header
{
    public class NavigationMenuModel
    {
        public IEnumerable<Link> Links { get; set; }

        public string CurrentPageUrl { get; set; }
    }
}

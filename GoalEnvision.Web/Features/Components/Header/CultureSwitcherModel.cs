using System.Collections.Generic;
using Umbraco.Cms.Core.Models;

namespace GoalEnvision.Web.Features.Components.Header
{
    public class CultureSwitcherModel
    {
        public IEnumerable<Link> Links { get; set; }

        public bool IsVisible { get; set; }
    }
}

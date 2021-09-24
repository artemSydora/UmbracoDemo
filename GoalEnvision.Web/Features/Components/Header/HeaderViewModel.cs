using System.Collections.Generic;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace GoalEnvision.Web.Features.Components.Header
{
    public class HeaderViewModel
    {
        public IEnumerable<Link> HeaderNavigationMenu { get; set; }

        public MediaWithCrops Logo { get; set; }

        public IPublishedContent CurrentPage { get; set; }

        public string CurrentPageUrl { get; set; }

        public IEnumerable<string> CurrentPageUrls { get; set; }
    }
}

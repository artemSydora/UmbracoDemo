using System.Collections.Generic;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Strings;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace GoalEnvision.Web.Features.Shared.Components.Footer
{
    public class FooterViewModel
    {

		public string Copyright { get; set; }

		public MediaWithCrops FooterLogo { get; set; }

		public IEnumerable<MenuItem> FooterNavigationMenus { get; set; }

		public IEnumerable<IconLinkItem> FooterSocialsMenu { get; set; }

		public IHtmlEncodedString GeneralInfo { get; set; }

		public IEnumerable<string> TaglineList { get; set; }
	}
}

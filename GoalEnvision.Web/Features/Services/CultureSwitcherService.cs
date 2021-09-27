using System.Collections.Generic;
using System.Globalization;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Extensions;

namespace GoalEnvision.Web.Features.Services
{
    public class CultureSwitcherService
    {
        public IEnumerable<Link> GetLinks(IPublishedContent currentPage)
        {
            var links = new List<Link>();

            foreach (var (culture, infos) in currentPage.Cultures)
            {
                CultureInfo cultureInfo = new CultureInfo(culture, false);

                links.Add(new Link
                {
                    Name = cultureInfo.NativeName[0].ToString().ToUpper() + cultureInfo.NativeName.Substring(1),
                    Url = currentPage.Url(culture)
                });
            }

            return links;
        }
    }
}

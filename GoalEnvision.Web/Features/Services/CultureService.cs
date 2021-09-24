using System;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Web.Common;

namespace GoalEnvision.Web.Features.Services
{
    public class CultureService
    {
        private readonly UmbracoHelper _umbracoHelper;

        public CultureService(UmbracoHelper umbracoHelper)
        {
            _umbracoHelper = umbracoHelper;
        }

        public IReadOnlyDictionary<string, PublishedCultureInfo> GetCultures()
        {
            var cultures = _umbracoHelper
                .ContentAtRoot()
                .FirstOrDefault()
                .Cultures;

            return cultures;
        }

        public IEnumerable<string> GetCurrentPageUrls(string currentPageUrl)
        {
            var cultures = GetCultures();
            var urls = new List<string>();

            foreach (var culture in cultures.Values)
            {
                var baseUrl = culture.Culture + currentPageUrl;

                if (baseUrl.Contains("en"))
                {
                    baseUrl = currentPageUrl;
                }

                Uri.TryCreate(baseUrl, UriKind.Relative, out Uri result);

                if (!String.IsNullOrEmpty(result.ToString()))
                {
                    urls.Add(result.ToString());
                }
            }

            return urls;
        }
    }
}

using GoalEnvision.Web.Features.Components.Hero;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.Blocks;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace GoalEnvision.Web.Features.Home
{
    public class HomeViewModel : ContentModel
    {
        public HomeViewModel(IPublishedContent content) : base(content) { }
       
        public BlockListModel Blocks => Content.GetProperty("Blocks").GetValue() as BlockListModel;

        public HeroViewModel Hero => new()
        {
            Title = Content.GetProperty("title").GetValue() as string,
            Description = Content.GetProperty("description").GetValue() as string,
            Image = Content.GetProperty("image").GetValue() as MediaWithCrops,
            Button = Content.GetProperty("button").GetValue() as Link,
            Link = Content.GetProperty("link").GetValue() as Link
        };
    }
}

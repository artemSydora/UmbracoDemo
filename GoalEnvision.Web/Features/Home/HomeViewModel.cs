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
            Title = Content.GetProperty("Title").GetValue() as string,
            Subtitle = Content.GetProperty("Subtitle").GetValue() as string
        };
    }
}

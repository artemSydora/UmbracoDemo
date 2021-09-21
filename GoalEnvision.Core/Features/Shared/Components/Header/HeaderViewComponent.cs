using Microsoft.AspNetCore.Mvc;

namespace UmbracoNineDemoSite.Core.Features.Shared.Components.Header
{
    [ViewComponent(Name = "Header")]
    public class HeaderViewComponent : ViewComponent
    {


        public IViewComponentResult Invoke(int selected)
        {
            return View(new HeaderViewModel()
            {
               
            });
        }
    }
}

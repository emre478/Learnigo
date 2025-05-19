using Microsoft.AspNetCore.Mvc;

namespace Learnigo.WebUI.ViewComponents.Home
{
    public class _HomeBannerComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

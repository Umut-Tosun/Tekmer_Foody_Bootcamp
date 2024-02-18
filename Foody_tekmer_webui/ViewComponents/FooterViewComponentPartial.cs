using Microsoft.AspNetCore.Mvc;

namespace Foody_tekmer_webui.ViewComponents
{
    public class FooterViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

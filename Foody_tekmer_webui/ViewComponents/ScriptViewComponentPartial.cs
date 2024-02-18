using Microsoft.AspNetCore.Mvc;

namespace Foody_tekmer_webui.ViewComponents
{
    public class ScriptViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

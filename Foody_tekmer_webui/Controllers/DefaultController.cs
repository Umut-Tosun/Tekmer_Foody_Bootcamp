using Microsoft.AspNetCore.Mvc;

namespace Foody_tekmer_webui.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Ana Sayfa";
            ViewBag.Title2 = "Sayfalar";
            ViewBag.Title3 = "Ürünler";
            return View();

        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialSpinner()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialHeader()
        {
           
            return PartialView();
        }
        public PartialViewResult PartialProducts()
        {
            return PartialView();
        }
        public PartialViewResult FirmVisit()
        {
            return PartialView();
        }
        public PartialViewResult PartialTestimonials()
        {
            return PartialView();
        }      
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
    }
}

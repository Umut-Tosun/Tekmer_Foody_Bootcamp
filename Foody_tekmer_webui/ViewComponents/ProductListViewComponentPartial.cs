using FoodTekmerDataAccessLayer.EntityFramework;
using FoodyTekmerBusinessLayer.Abstract;
using FoodyTekmerBusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Foody_tekmer_webui.ViewComponents
{
    public class ProductListViewComponentPartial : ViewComponent
    {
        private readonly IProductService _productService;

        public ProductListViewComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _productService.TGetListAll();
            return View(values);
        }
    }
}

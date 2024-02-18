using FoodTekmerDataAccessLayer.Context;
using Foody_tekmer_webui.Methods;
using FoodyTekmerBusinessLayer.Abstract;
using FoodyTekmerEntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Foody_tekmer_webui.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var values = _productService.TGetListAll();
            return View(values);
        }
        public IActionResult ChangeStatus(int id)
        {
            var product = _productService.TGetById(id);
            product.status = !product.status;
            _productService.TUpdate(product);
            return RedirectToAction("Index");   
        }
        [HttpGet]
        public IActionResult AddProduct(Product product)
        {
            product.ImageUrl = "https://i.hizliresim.com/qtxfq98.jpg";
            return View(product);
        }
        [HttpPost]
        public IActionResult AddProduct(Product product,IFormFile FileUrl)
        {
            if (FileUrl != null) product.ImageUrl = FileService.CreateToIFormFile(FileUrl);
            else product.ImageUrl = "https://i.hizliresim.com/qtxfq98.jpg";
           
            _productService.TAdd(product);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var product = _productService.TGetById(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product, IFormFile FileUrl)
        {
            if (FileUrl != null) product.ImageUrl = FileService.CreateToIFormFile(FileUrl);
            else product.ImageUrl = "https://i.hizliresim.com/qtxfq98.jpg";

            _productService.TUpdate(product);
            return RedirectToAction("Index");
        }


    }
}

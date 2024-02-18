using FoodTekmerDataAccessLayer.Context;
using FoodyTekmerEntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Foody_tekmer_webui.Controllers;

public class CategoryController : Controller
{
    FoodyTekmerContext context = new FoodyTekmerContext();
    public IActionResult Index()
    {
        var values = context.Categories.ToList();
        return View(values);
    }
    [HttpGet]
    public IActionResult AddCategory()
    {
        return View();
    }
    [HttpPost]
    public IActionResult AddCategory(Category category)
    {
        category.status = true;
        context.Categories.Add(category);
        context.SaveChanges();
        return RedirectToAction("Index");
    }
    [HttpGet]
    public IActionResult UpdateCategory(int id)
    {
        var category = context.Categories.FirstOrDefault(x=>x.Id == id);
        return View(category);
    }
    [HttpPost]
    public IActionResult UpdateCategory(Category category)
    {
         context.Categories.Update(category);
        context.SaveChanges();
        return RedirectToAction("Index");
    }
    public IActionResult ChangeStatus(int id)
    {
        var category = context.Categories.FirstOrDefault(x => x.Id == id);
        category.status = !category.status;
        context.SaveChanges();
        return RedirectToAction("Index");
    }
}

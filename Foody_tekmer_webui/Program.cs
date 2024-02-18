using FoodTekmerDataAccessLayer.Abstract;
using FoodTekmerDataAccessLayer.Context;
using FoodTekmerDataAccessLayer.EntityFramework;
using FoodyTekmerBusinessLayer.Abstract;
using FoodyTekmerBusinessLayer.Concrete;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IProductDal,EfProductDal>();
builder.Services.AddScoped<IProductService,ProductManager>();
builder.Services.AddDbContext<FoodyTekmerContext>();
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();

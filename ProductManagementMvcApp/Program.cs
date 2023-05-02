using Microsoft.EntityFrameworkCore;
using ProductManagementMvcApp.Data;
using ProductManagementMvcApp.Data.Repositories.DataImplimentations;
using ProductManagementMvcApp.Data.Repositories.DataInterfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddDbContext<WebAppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProudctPriceConnection"));
});
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
    name: "products",
    pattern: "{controller=Product}/{action=List}");

app.Run();

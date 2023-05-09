using Microsoft.EntityFrameworkCore;
using Allegra.Models;
using Allegra.Context;
using Allegra.Repositories.Interfaces;
using Allegra.Repositories;
using Microsoft.AspNetCore.Identity;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IJoiaRepository, JoiaRepository>();
builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped(sp => CarrinhoCompra.GetCarrinho(sp));


builder.Services.AddDbContext<AppDbContext>
    (options => options.UseSqlServer(connectionString: "Data Source=GalloNote;Initial Catalog=AllegraDB; Integrated Security=True; TrustServerCertificate=True"));


builder.Services.AddMemoryCache();
builder.Services.AddSession();


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
app.UseSession();

app.MapControllerRoute(
    name: "FiltroCategoria",
    pattern: "{controller=Joia}/{action}/{categoria?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "admin",
    pattern: "admin/{action=Index}/{id?}");



app.Run();

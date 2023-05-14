using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Web_MSI.Data;
using Npgsql;
using Web_MSI.Models;
using Microsoft.AspNetCore.Identity.UI.Services;
using Web_MSI;
using Web_MSI.Areas.Identity.Pages.Account;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("PostgressConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
   options.UseNpgsql(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

    builder.Services.AddTransient<IEmailSender, EmailService>();


builder.Services.AddControllersWithViews();

// Agregar esta línea para habilitar las páginas Razor
builder.Services.AddRazorPages();

var app = builder.Build();

app.MapGet("/", () => {
    return Results.Redirect("/Identity/Account/Login");
});
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Agregar esta línea antes de app.MapRazorPages()
app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
    
app.MapRazorPages();

app.Run();

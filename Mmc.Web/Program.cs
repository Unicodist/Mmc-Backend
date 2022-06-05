using Mechi.Backend;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Mmc.Core;
using Mmc.Data;
using Mmc.Data.Model.User;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(option =>
{
    option.LoginPath = "/Account/Login/";
    option.AccessDeniedPath = "/Account/Unauthorized/";
});
// builder.Services.Configure<CookiePolicyOptions>(options =>
// {
//     options.CheckConsentNeeded = _ => true;
//     options.MinimumSameSitePolicy = SameSiteMode.None;
// });

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession();

//Add DbContext to the solution

builder.Services.AddDbContext<AppDbContext>(option =>
{
    option.UseMySql(builder.Configuration.GetConnectionString("Default"),
        new MySqlServerVersion(new Version(8, 0, 24)));
});

builder.Services.ConfBlog();
builder.Services.ConfData();
builder.Services.ConfNotice();
builder.Services.ConfUser();

//End DbContext

var app = builder.Build();

app.UseAuthentication();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseSession();
app.UseStaticFiles();
app.UseCookiePolicy();

app.UseAuthentication();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
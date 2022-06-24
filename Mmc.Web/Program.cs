using Mechi.Backend;
using Microsoft.EntityFrameworkCore;
using Mmc.Data;
using Serilog;
using Serilog.Events;

Log.Logger = new LoggerConfiguration()
    .WriteTo.File("logs/log.txt",LogEventLevel.Information,rollingInterval:RollingInterval.Day)
    .CreateLogger();
var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog();

builder.Services.AddDbContext<AppDbContext>(option =>
{
    option.UseMySql(builder.Configuration.GetConnectionString("Default"),
        new MySqlServerVersion(new Version(8, 0, 24)));
});

builder.Services.Configure();

var app = builder.Build();

app.ConfigureExceptionHandler();

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

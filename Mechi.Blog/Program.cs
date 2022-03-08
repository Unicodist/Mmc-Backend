using Mechi.Backend.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Mmc.Api.Entities.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v6", new OpenApiInfo() {Title="Mmc.Api",Version="v6"});
});

//Add DbContext to the solution
builder.Services.AddDbContext<BlogDbContext>(options =>
{
    options.UseMySql(ServerVersion.Parse(builder.Configuration.GetConnectionString("DbApiConnection")));
});

builder.Services.AddDbContext<BaseDbContext>(options =>
{
    options.UseMySql(ServerVersion.Parse(builder.Configuration.GetConnectionString("DbApiConnection")));
});

//End DbContext

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

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v6/swagger.json","Mmc.Api");
});

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
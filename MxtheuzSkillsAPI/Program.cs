
using MxtheuzSkillsAPI.Utils.Services;
using MxtheuzSkillsAPI.Utils.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IGistRequest, GistRequest>();
builder.Services.AddScoped<IPingService, PingService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=API}/{action=Index}/{id?}");

app.Run();

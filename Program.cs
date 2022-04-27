using ACP_learn.Interfaces;
using ACP_learn.Models;
using ACP_learn.Mocks;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMvc();
builder.Services.AddTransient<IAllCars, MockCars>();
builder.Services.AddTransient<ICarsCategory, MockCategory>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// * подключение зависимостей *
app.UseHttpsRedirection();
app.UseStatusCodePages();

app.UseStaticFiles();

//app.UseMvcWithDefaultRoute();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

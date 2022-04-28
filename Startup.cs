using ACP_learn.Interfaces;
using ACP_learn.Models;
using ACP_learn;
using ACP_learn.Mocks;
using ACP_learn.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Design;


namespace ACP_learn
{
    class Startup
    {
        private IConfigurationRoot confString;

        public Startup(IHostEnvironment hostEnvironment)
        {
            confString = new ConfigurationBuilder().SetBasePath(hostEnvironment.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddControllersWithViews();
            services.AddTransient<IAllCars, CarsRepository>();
            services.AddTransient<ICarsCategory, CategoryRepository>();
            services.AddDbContext<AppDbContent>(options => options.UseSqlServer(confString.GetConnectionString("DefaultConnection")));
        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
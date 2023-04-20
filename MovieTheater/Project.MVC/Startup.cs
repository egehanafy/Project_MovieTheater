using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;
using Microsoft.Extensions.Hosting;
using Project.BLL.Abstract;
using Project.BLL.AbstractService;
using Project.BLL.Concrete;
using Project.BLL.Service;
using Project.DAL.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using Project.IOC.Container;
using Project.IOC.Seed;
using Project.Entity.Entity;
using Microsoft.AspNetCore.Identity;

namespace Project.MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            //DbContext
            services.AddDbContext<ProjectContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //Service
            ServiceIOC.ServiceConfigure(services);

            //Identity Service
            //Token olusturmak istedigimizde bu metodu dahil etmeliyiz.
            services.AddIdentity<AppUser, AppUserRole>().AddEntityFrameworkStores<ProjectContext>().AddDefaultTokenProviders(); //token olusturmak istedigimizde bu metodu dahil etmeliyiz.

            services.ConfigureApplicationCookie(x =>
            {
                x.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Home/Login");
                x.Cookie = new Microsoft.AspNetCore.Http.CookieBuilder
                {
                    Name = "Login_cookie"
                };
                x.SlidingExpiration = true;
                x.ExpireTimeSpan = TimeSpan.FromMinutes(10);
            });

            services.AddSession(x =>
            {
                x.Cookie.Name = "movie_cart_session";
                x.IdleTimeout = TimeSpan.FromMinutes(10);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseSession();

            SeedData.Seed(app);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //Dashboard Route
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                //Confirmation Route
                endpoints.MapControllerRoute(
                    name: "confirmation",
                    pattern: "{controller=Home}/{action=confirmation}/{id}/{registerCode}");

                //Default Route
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

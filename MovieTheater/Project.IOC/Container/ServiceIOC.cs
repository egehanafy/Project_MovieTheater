using Microsoft.Extensions.DependencyInjection;
using Project.BLL.IntAbstract;
using Project.BLL.Concrete;
using Project.BLL.IntService;
using Project.BLL.Service;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Identity;
using Project.DAL.Context;
using Project.Entity.Entity;

namespace Project.IOC.Container
{
    public static class ServiceIOC
    {
        //ServiceConfigure
        public static void ServiceConfigure(IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IMovieService, MovieService>();
            services.AddScoped<IGenreService, GenreService>();
            services.AddScoped<ITicketService, TicketService>();
            services.AddScoped<ITicketDetailService, TicketDetailService>();
            services.AddScoped<IHallService, HallService>();
            services.AddScoped<ISeatService, SeatService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IEmployeeService, EmployeeService>();

            //Identity Service
            //Token olusturmak istedigimizde bu metodu dahil etmeliyiz.
            services.AddIdentity<AppUser, AppUserRole>().AddEntityFrameworkStores<ProjectContext>().AddDefaultTokenProviders();

            //Jwt Service
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                    {
                        //ValidateIssuer
                        ValidateIssuer = true,
                        //ValidateAudience
                        ValidateAudience = true,
                        //ValidateLifeTime
                        ValidateLifetime = true,
                        //ValidateIssuerSignInKey
                        ValidateIssuerSigningKey = true,
                        //ValidIssuer
                        ValidIssuer = "https://localhost:44301",
                        //ValidaAuidence
                        ValidAudience = "https://localhost:44301",
                        //IssuerSignInKey
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("b51487ad3be4760cada8cfb4523451c2459f8c398d98ee3657ca4729797195d7"))
                    };
                });
        }
    }
}

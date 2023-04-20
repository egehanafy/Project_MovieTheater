using Microsoft.Extensions.DependencyInjection;
using Project.BLL.IntAbstract;
using Project.BLL.Concrete;
using Project.BLL.IntService;
using Project.BLL.Service;
using System;
using System.Collections.Generic;
using System.Text;

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
        }
    }
}

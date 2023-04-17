﻿using Microsoft.Extensions.DependencyInjection;
using Project.BLL.Abstract;
using Project.BLL.AbstractService;
using Project.BLL.Concrete;
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
        }
    }
}
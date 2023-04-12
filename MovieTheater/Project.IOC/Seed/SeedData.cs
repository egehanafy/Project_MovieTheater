using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using Project.DAL.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.IOC.Seed
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            //using blogunu middleware'de servis disinda kalmamak icin kullaniyoruz. Middleware yapisi sadece singleton yapilarini desteklemektedir. Servis yapisini seed class'i icerisinde kullanmak icin using lgouna ihtiyacimiz bulunmaktadir.
            using (var serviceScope=app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ProjectContext>();

                context.Database.Migrate();

                //Genres
                if (!context.Genres.Any())
                {
                    context.Genres.AddRange()
                }

                //Movies
                if (!context.Movies.Any())
                {

                }

                //...
            }
        }
    }
}

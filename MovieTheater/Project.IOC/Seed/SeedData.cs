﻿using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using Project.DAL.Context;
using Project.Entity.Entity;
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
                    context.Genres.AddRange(
                        new Genre
                        {
                            GenreName = "Korku"
                        },
                        new Genre
                        {
                            GenreName = "Bilim Kurgu"
                        });
                }

                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(
                        new Movie
                        {
                            Title = "Star Wars",
                            Description = "Yildiz Savaslari, George Lucsa tarafindan yaratilmis, oncelikle fimleriyle taninmis, sonraki yillarda cizgi roman, video oyunlari, televizyon yapimlari vb. dallarda ununu arttirmis kurgusal bir evren ve markadir.",
                            Duration = TimeSpan.FromHours(2.01),
                            Year = "1977",
                            Rating = 8.8D,
                            ImagePath = "https://t1.gstatic.com/licensed-image?q=tbn:ANd9GcSFqs2AfGte3gdgvgNmHogNiyN3r9VS3x-sAd2PDYe5RuvfMeBz5DdQSR-dcGSW3DZF",
                            GenreId = 2
                        },
                        new Movie
                        {
                            Title = "Exorcism",
                            Description = "Seytan, William Friedkin'in yonettigi 1973 tarihli bir ABD yapimi filmdir. Tum dunyada elestiriler alan bu filmin       setinde de kadronun basina ilginc seyler geldi.",
                            Duration = TimeSpan.FromHours(2.12),
                            Year = "1973",
                            Rating = 8.1D,
                            ImagePath = "https://upload.wikimedia.org/wikipedia/tr/5/59/Exorcistmovie.jpg",
                            GenreId = 1
                        });
                }

                //...

                context.SaveChanges();
            }
        }
    }
}
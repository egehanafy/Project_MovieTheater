using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Project.DAL.Context
{
    public class ProjectContext : IdentityDbContext<AppUser, AppUserRole, int>
    {
        public ProjectContext(DbContextOptions<ProjectContext> options):base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }


        //FakeData

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //AppUser


            //Genre
            List<Genre> genres = new List<Genre>
            {
                new Genre
                {
                    Id = 1,
                    GenreName="Korku"
                },
                new Genre
                {
                    Id = 2,
                    GenreName="Bilim Kurgu"
                }
            };

            //Movie
            List<Movie> movies = new List<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Title = "Star Wars",
                    Description = "Yildiz Savaslari, George Lucsa tarafindan yaratilmis, oncelikle fimleriyle taninmis, sonraki yillarda cizgi roman, video oyunlari, televizyon yapimlari vb. dallarda ununu arttirmis kurgusal bir evren ve markadir.",
                    Duration = TimeSpan.FromHours(2.01),
                    Year = "1977",
                    Rating = 8.8D,
                    ImagePath = "https://t1.gstatic.com/licensed-image?q=tbn:ANd9GcSFqs2AfGte3gdgvgNmHogNiyN3r9VS3x-sAd2PDYe5RuvfMeBz5DdQSR-dcGSW3DZF",
                    GenreId = genres.Where(x=>x.GenreName=="Bilim Kurgu").FirstOrDefault().Id
                },
                new Movie
                {
                    Id = 2,
                    Title = "Exorcism",
                    Description = "Seytan, William Friedkin'in yonettigi 1973 tarihli bir ABD yapimi filmdir. Tum dunyada elestiriler alan bu filmin setinde de kadronun basina ilginc seyler geldi.",
                    Duration = TimeSpan.FromHours(2.12),
                    Year = "1973",
                    Rating = 8.1D,
                    ImagePath = "https://upload.wikimedia.org/wikipedia/tr/5/59/Exorcistmovie.jpg",
                    GenreId = genres.Where(x=>x.GenreName=="Korku").FirstOrDefault().Id
                }
            };

            builder.Entity<Movie>().HasData(movies);
            builder.Entity<Genre>().HasData(genres);

            base.OnModelCreating(builder);
        }
    }
}
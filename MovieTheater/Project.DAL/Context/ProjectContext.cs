using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project.Entity.Entity;

namespace Project.DAL.Context
{
    public class ProjectContext : IdentityDbContext<AppUser, AppUserRole, int>
    {
        public ProjectContext(DbContextOptions<ProjectContext> options):base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("server=EGEHAN\\SQLEXPRESS;database=MovieTheaterDB;uid=sa;pwd=123;");
        //    }

        //    base.OnConfiguring(optionsBuilder);
        //}

        //FakeData

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //AppUser

            //Movie
            Movie movie = new Movie
            {
                Id = 1,
                MovieName = "Starwars",
                UnitPrice = 5,
                UnitsInStock = 10,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas sollicitudin, est et consequat feugiat, nisl magna molestie arcu, eu maximus tellus risus sit amet quam. Phasellus eleifend dapibus consectetur. Pellentesque eget elit libero. Fusce convallis, magna et placerat congue, erat massa auctor dolor, non mollis risus arcu suscipit tortor. Aliquam erat volutpat. Mauris et nibh a leo tempus laoreet. Donec dapibus sed est at porta. Aenean eget eleifend libero. Quisque tempor dui erat, non luctus arcu porttitor in. Maecenas vitae dignissim libero. Donec auctor eros elit, in molestie neque venenatis non. Pellentesque massa odio, semper in lacus ac, porttitor auctor ligula.",
                ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQoNaLFFSdD4YhW8mqgDBSWY8nHnte6ANHQWz6Lsl37yA&s"
            };
            builder.Entity<Movie>().HasData(movie);

            base.OnModelCreating(builder);
        }
    }
}
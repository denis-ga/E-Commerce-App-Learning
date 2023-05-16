using Bookshop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bookshop.DataAccess.Data
{
    public class ApplicationDbContext: IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Чистая архитектура",
                    Author = "Роберт Мартин",
                    Description = "Идеальный программист\" и \"Чистый код\" - легендарные бестселлеры Роберта Мартина - рассказывают, как достичь высот профессионализма. \"Чистая архитектура\" продолжает эту тему, но не предлагает несколько вариантов в стиле \"решай сам\", а объясняет, что именно следует делать, по какой причине и почему именно такое решение станет принципиально важным для вашего успеха.",
                    ISBN = "9785446107728",
                    ListPrice = 15.69,
                    Price = 15,
                    Price50 = 13,
                    Price100 = 12,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Title = "Чистый код",
                    Author = "Роберт Мартин",
                    Description = "Даже плохой программный код может работать. Однако если код не является \"чистым\", это всегда будет мешать развитию проекта и компании-разработчика, отнимая значительные ресурсы на его поддержку и \"укрощение\".Эта книга посвящена хорошему программированию. Она полна реальных примеров кода.",
                    ISBN = "9785446109609",
                    ListPrice = 13.69,
                    Price = 13,
                    Price50 = 12,
                    Price100 = 10,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "Идеальный программист",
                    Author = "Роберт Мартин",
                    Description = "Всех программистов, которые добиваются успеха в мире разработки ПО, отличает один общий признак: они больше всего заботятся о качестве создаваемого программного обеспечения. Это — основа для них. Потому что они являются профессионалами своего дела. ",
                    ISBN = "9785446110674",
                    ListPrice = 11.59,
                    Price = 11,
                    Price50 = 10,
                    Price100 = 8,
                    CategoryId = 3,
                    ImageUrl = ""
                }
            );
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product>  Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}

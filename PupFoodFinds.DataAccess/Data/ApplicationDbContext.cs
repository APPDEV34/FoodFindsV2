using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PupFoodFinds.Models;
using System.ComponentModel.DataAnnotations;

namespace PupFoodFinds.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ApplicationUser>ApplicationUsers  { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Street Food", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Lutong Bahay", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Drinks", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    StallNumber = "1",
                    FirstName = "Ben",
                    LastName = "En",
                    MiddleInitial = "T",
                    StallName = "Mang Ben Eatery",
                    StreetAddress = "123 Ben St",
                    PhoneNumber = "0931321443"
                },
                new Company
                {
                    Id = 2,
                    StallNumber = "2",
                    FirstName = "Marie",
                    LastName = "Sol",
                    MiddleInitial = "T",
                    StallName = "Aling Marie Eatery",
                    StreetAddress = "123 Marie St",
                    PhoneNumber = "0943251443"
                },
                new Company
                {
                    Id = 3,
                    StallNumber = "3",
                    FirstName = "Ayaw",
                    LastName = "ol",
                    MiddleInitial = "K",
                    StallName = "Tindahan Store",
                    StreetAddress = "123 Tindahan St",
                    PhoneNumber = "0944222443"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    MenuItem = "Penoy",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 99,
                    Price = 90,
                    
                    CategoryId = 1,
                },
                new Product
                {
                    Id = 2,
                    MenuItem = "Kwek-Kwek",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 40,
                    Price = 30,
                    
                    CategoryId = 1,
                },
                new Product
                {
                    Id = 3,
                    MenuItem = "Fishball",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 55,
                    Price = 50,
                    
                    CategoryId = 1,
                },
                new Product
                {
                    Id = 4,
                    MenuItem = "Cotton Candy",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 70,
                    Price = 65,
                    
                    CategoryId = 2,
                },
                new Product
                {
                    Id = 5,
                    MenuItem = "Burger",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 30,
                    Price = 27,
                    
                    CategoryId = 3,
                },
                new Product
                {
                    Id = 6,
                    MenuItem = "Kikiam",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 25,
                    Price = 23,
                    
                    CategoryId = 1,
                }
                );
        }
    }
}

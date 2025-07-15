using Microsoft.EntityFrameworkCore;
using Offer_API.Models;

namespace Offer_API.Repository
{
    public class OfferDbContext : DbContext
    {
        public OfferDbContext(DbContextOptions<OfferDbContext> options) : base(options)
        {
        }

        public DbSet<Offer> Offers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { Id = 1, Name = "Делимобиль", CreatedDate = DateTime.Now.AddDays(-30) },
                new Supplier { Id = 2, Name = "Тачковоз", CreatedDate = DateTime.Now.AddDays(-25) },
                new Supplier { Id = 3, Name = "ООО Тмыв", CreatedDate = DateTime.Now.AddDays(-20) },
                new Supplier { Id = 4, Name = "Газпром", CreatedDate = DateTime.Now.AddDays(-15) },
                new Supplier { Id = 5, Name = "Моторчик", CreatedDate = DateTime.Now.AddDays(-10) }
            );

            modelBuilder.Entity<Offer>().HasData(
                new Offer { Id = 1, Brand = "Toyota", Model = "Camry", SupplierId = 1, RegistrationDate = DateTime.Now.AddDays(-5) },
                new Offer { Id = 2, Brand = "Honda", Model = "Civic", SupplierId = 1, RegistrationDate = DateTime.Now.AddDays(-4) },
                new Offer { Id = 3, Brand = "Ford", Model = "Focus", SupplierId = 1, RegistrationDate = DateTime.Now.AddDays(-3) },
                new Offer { Id = 4, Brand = "BMW", Model = "X5", SupplierId = 2, RegistrationDate = DateTime.Now.AddDays(-2) },
                new Offer { Id = 5, Brand = "Audi", Model = "A4", SupplierId = 2, RegistrationDate = DateTime.Now.AddDays(-1) },
                new Offer { Id = 6, Brand = "Mercedes", Model = "C-Class", SupplierId = 2, RegistrationDate = DateTime.Now },
                new Offer { Id = 7, Brand = "Daewoo", Model = "Matiz", SupplierId = 3, RegistrationDate = DateTime.Now.AddDays(-6) },
                new Offer { Id = 8, Brand = "Hyundai", Model = "Tucson", SupplierId = 3, RegistrationDate = DateTime.Now.AddDays(-5) },
                new Offer { Id = 9, Brand = "Kia", Model = "Sportage", SupplierId = 3, RegistrationDate = DateTime.Now.AddDays(-4) },
                new Offer { Id = 10, Brand = "Nissan", Model = "Juke", SupplierId = 4, RegistrationDate = DateTime.Now.AddDays(-3) },
                new Offer { Id = 11, Brand = "Chevrolet", Model = "Malibu", SupplierId = 4, RegistrationDate = DateTime.Now.AddDays(-2) },
                new Offer { Id = 12, Brand = "Tesla", Model = "Model 3", SupplierId = 4, RegistrationDate = DateTime.Now.AddDays(-1) },
                new Offer { Id = 13, Brand = "Subaru", Model = "Outback", SupplierId = 5, RegistrationDate = DateTime.Now },
                new Offer { Id = 14, Brand = "Mazda", Model = "Miata", SupplierId = 5, RegistrationDate = DateTime.Now.AddDays(-1) },
                new Offer { Id = 15, Brand = "Lada", Model = "Samara", SupplierId = 5, RegistrationDate = DateTime.Now.AddDays(-2) }
            );
        }
    }
}

using day01RazorBakery.Data.Configurations;
using day01RazorBakery.Models;
using Microsoft.EntityFrameworkCore;
namespace day01RazorBakery.Data

{
    public class Day01RazorBakeryContext:DbContext
    {
         public DbSet<Product> Products { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=day01RazorBakery.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //with the extension method Seed(), will generate preset dummy data which defined in ModelBuilderExtension.cs
            modelBuilder.ApplyConfiguration(new ProductConfiguration()).Seed();
        }
    }
}
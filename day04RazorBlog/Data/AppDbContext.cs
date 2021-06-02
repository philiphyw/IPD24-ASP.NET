using day04RazorBlog.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace day04RazorBlog.Data
{
    public class AppDbContext: IdentityDbContext
    {
        public DbSet<Article> Articles { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

              protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=day04razorblog.db");
        }

    
    }
}
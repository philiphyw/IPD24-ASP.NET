using Microsoft.EntityFrameworkCore;
using day02RazorMyFriends.Models;
using day02RazorMyFriends.Data.Configurations;

namespace day02RazorMyFriends.Data
{
    public class FriendsContext : DbContext
    {
        public DbSet<Friend> Friends { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=Friends.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FriendConfiguration());
        }
    }

}
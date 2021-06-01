using day02RazorMyFriends.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace day02RazorMyFriends.Data.Configurations
{
     public class FriendConfiguration : IEntityTypeConfiguration<Friend>
    {
        public void Configure(EntityTypeBuilder<Friend> builder)
        {
            // builder.Property(p => p.ImageName).HasColumnName("ImageFileName");
        }
    }
}
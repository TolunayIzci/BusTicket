using BusTicket.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusTicket.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Surname).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(50);
            builder.Property(x => x.UserTypeId).HasDefaultValue(1);
            builder.HasOne(x => x.UserType).WithMany(x => x.Users).IsRequired().HasForeignKey(x => x.UserTypeId);
            builder.HasMany(x => x.Tickets).WithOne(x => x.User).HasForeignKey(x => x.CreateUserId);
            builder.ToTable("User");
        }
    }
}

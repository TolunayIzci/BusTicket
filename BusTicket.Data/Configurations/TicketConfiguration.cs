using BusTicket.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusTicket.Data.Configurations
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.PassangerName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.PassangerSurname).IsRequired().HasMaxLength(50);
            builder.Property(x => x.SeatNumber).IsRequired();
            builder.Property(x => x.Price).HasColumnType("decimal (18,2)");
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.CreateUserId).IsRequired();
            builder.Property(x => x.CreateTime).IsRequired();
            builder.Property(x => x.UpdateUserId);
            builder.Property(x => x.UpdateTime);
            builder.Property(x => x.RouteId);
            builder.ToTable("Ticket");
        }
    }
}
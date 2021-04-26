using BusTicket.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Data.Configurations
{
    class RouteConfiguration : IEntityTypeConfiguration<Route>
    {
        public void Configure(EntityTypeBuilder<Route> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.OriginLocationId).IsRequired(false);
            builder.Property(x => x.DestinationLocationId).IsRequired(false); 
            builder.Property(x => x.SeatCount);
            builder.Property(x => x.SeatCapacity);
            builder.Property(x => x.Price);
            builder.Property(x => x.AdditionRate);
            builder.Property(x => x.ActivePrice);
            builder.Property(x => x.CreateUserId);
            builder.Property(x => x.CreateTime);
            builder.Property(x => x.UpdateUserId);
            builder.Property(x => x.UpdateTime);

            builder.HasMany(x => x.Tickets).WithOne(x => x.Route).HasForeignKey(x => x.RouteId);
            builder.HasOne(x => x.OriginLocation).WithMany(x => x.OriginRoutes).HasForeignKey(x => x.OriginLocationId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.DestinationLocation).WithMany(x => x.DestinationRoutes).HasForeignKey(x => x.DestinationLocationId).OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Route");

        }
    }
}

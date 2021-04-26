using BusTicket.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Data.Seeds
{
    class RouteSeed : IEntityTypeConfiguration<Route>
    {
        public void Configure(EntityTypeBuilder<Route> builder)
        {
            builder.HasData(
                new Route { Id = 1, OriginLocationId = 1, DestinationLocationId = 2, SeatCount = 1, SeatCapacity = 20, Price = 100, AdditionRate = 1, ActivePrice = 1, CreateUserId = 2, CreateTime = DateTime.Now },
                new Route { Id = 2, OriginLocationId = 2, DestinationLocationId = 1, SeatCount = 3, SeatCapacity = 20, Price = 33, AdditionRate = 2, ActivePrice = 12, CreateUserId = 1, CreateTime = DateTime.Now },
                new Route { Id = 3, OriginLocationId = 3, DestinationLocationId = 3, SeatCount = 5, SeatCapacity = 20, Price = 44, AdditionRate = 3, ActivePrice = 13, CreateUserId = 3, CreateTime = DateTime.Now });
        }


    }
}
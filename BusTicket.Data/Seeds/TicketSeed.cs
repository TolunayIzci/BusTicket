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
    class TicketSeed : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasData(
                new Ticket { Id = 1, PassangerName = "ali", PassangerSurname = "kalem", SeatNumber = 1, Price = 100, IsActive = true, CreateUserId = 1, CreateTime = DateTime.Now, RouteId = 1 },
                new Ticket { Id = 2, PassangerName = "mehmet", PassangerSurname = "patates", SeatNumber = 3, Price = 33, IsActive = true, CreateUserId = 2, CreateTime = DateTime.Now, RouteId = 2 },
                new Ticket { Id = 3, PassangerName = "ahmet", PassangerSurname = "kağıt", SeatNumber = 5, Price = 44, IsActive = true, CreateUserId = 3, CreateTime = DateTime.Now, RouteId = 3 });
        }


    }
}
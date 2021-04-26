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
    class UserTypeSeed : IEntityTypeConfiguration<UserType>
    {
        public void Configure(EntityTypeBuilder<UserType> builder)
        {
            builder.HasData(
                new UserType { Id = 1, Type = "User" },
                new UserType { Id = 2, Type = "Admin"},
                new UserType { Id = 3, Type = "Driver"});
        }


    }
}

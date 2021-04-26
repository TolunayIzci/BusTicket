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
    class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User { Id = 1, Name = "ali", Surname = "kalem", Email = "1@mail", Password = "123", UserTypeId = 1 },
                new User { Id = 2, Name = "mehmet", Surname = "patates", Email = "2@mail", Password = "123", UserTypeId = 1 },
                new User { Id = 3, Name = "ahmet", Surname = "kağıt", Email = "3@mail", Password = "123", UserTypeId = 2 });
        }

    }
}

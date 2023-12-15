using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using VirtualPet.Core.Models;

namespace VirtualPet.Repository.Seeds
{
    public class UserSeeds : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // User seed data
            builder.HasData(
                new User
                {
                    Id = 1,
                    Name = "John Doe",
                    Age = 30,
                    Gender = "Male",
                    RegistrationDate = new DateTime(2020, 1, 1),
                    UserName = "johndoe",
                    Password = "johndoe123",
                    PhoneNumber = "1234567890",
                    Email = "johndoe@example.com"
                },
                new User
                {
                    Id = 2,
                    Name = "Jane Doe",
                    Age = 28,
                    Gender = "Female",
                    RegistrationDate = new DateTime(2020, 2, 1),
                    UserName = "janedoe",
                    Password = "janedoe123",
                    PhoneNumber = "0987654321",
                    Email = "janedoe@example.com"
                },
                new User
                {
                    Id = 3,
                    Name = "Chris Smith",
                    Age = 35,
                    Gender = "Male",
                    RegistrationDate = new DateTime(2020, 3, 1),
                    UserName = "chrissmith",
                    Password = "chrissmith123",
                    PhoneNumber = "1122334455",
                    Email = "chrissmith@example.com"
                }
            );
        }
    }
}

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
    public class PetSeeds : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            // Pet seed data
            builder.HasData(
                new Pet
                {
                    Id = 1,
                    Name = "Max",
                    Age = 5,
                    Gender = "Erkek",
                    RegistrationDate = new DateTime(2021, 1, 1),
                    Species = "Köpek",
                    Breed = "Golden Retriever",
                    Weight = 30.0m,
                    UserId = 1
                },
                new Pet
                {
                    Id = 2,
                    Name = "Mia",
                    Age = 3,
                    Gender = "Dişi",
                    RegistrationDate = new DateTime(2021, 3, 15),
                    Species = "Kedi",
                    Breed = "Siamese",
                    Weight = 5.0m,
                    UserId = 1
                },
                new Pet
                {
                    Id = 3,
                    Name = "Charlie",
                    Age = 2,
                    Gender = "Erkek",
                    RegistrationDate = new DateTime(2021, 7, 22),
                    Species = "Köpek",
                    Breed = "Beagle",
                    Weight = 10.0m,
                    UserId = 2
                }
            );
        }
    }
}

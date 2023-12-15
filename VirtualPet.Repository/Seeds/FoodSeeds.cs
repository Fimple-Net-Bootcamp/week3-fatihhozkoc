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
    public class FoodsSeeds : IEntityTypeConfiguration<Foods>
    {
        public void Configure(EntityTypeBuilder<Foods> builder)
        {
            // Foods seed data
            builder.HasData(
                new Foods
                {
                    Id = 1,
                    Name = "Premium Kuru Mama",
                    Type = "kuru mama",
                    EnergyValue = 350,
                    NutritionalValues = "Yüksek protein, düşük yağ",
                    PortionSize = 100m,
                    ServingFrequency = "Günde iki kez",
                    Suitability = new Dictionary<string, string> { { "Köpek", "Yetişkin" } },
                    IsOrganic = true,
                    IsContainsGluten = false,
                    PetId = 1
                },
                new Foods
                {
                    Id = 2,
                    Name = "Organik Yaş Mama",
                    Type = "yaş mama",
                    EnergyValue = 200,
                    NutritionalValues = "Organik tavuk ve sebze",
                    PortionSize = 150m,
                    ServingFrequency = "Günde üç kez",
                    Suitability = new Dictionary<string, string> { { "Kedi", "Yetişkin" } },
                    IsOrganic = true,
                    IsContainsGluten = true,
                    PetId = 2
                },
                new Foods
                {
                    Id = 3,
                    Name = "Sağlıklı Ödül Maması",
                    Type = "ödül maması",
                    EnergyValue = 100,
                    NutritionalValues = "Doğal malzemeler, ilave şeker içermez",
                    PortionSize = 50m,
                    ServingFrequency = "Eğitim sırasında",
                    Suitability = new Dictionary<string, string> { { "Köpek", "Her yaştan" }, { "Kedi", "Her yaştan" } },
                    IsOrganic = false,
                    IsContainsGluten = false,
                    PetId = 3
                }
            );
        }
    }
}

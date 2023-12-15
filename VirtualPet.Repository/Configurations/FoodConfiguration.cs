using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPet.Core.Models;

namespace VirtualPet.Repository.Configrations
{
    public class FoodConfiguration : IEntityTypeConfiguration<Foods>
    {
        public void Configure(EntityTypeBuilder<Foods> builder)
        {
            // Primary Key
            builder.HasKey(f => f.Id);

            // Alanlar
            builder.Property(f => f.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(f => f.Type)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(f => f.EnergyValue);

            builder.Property(f => f.NutritionalValues)
                .HasMaxLength(500);

            builder.Property(f => f.PortionSize);

            builder.Property(f => f.ServingFrequency)
                .HasMaxLength(100);

            // Suitability için JSON dönüşümü
            builder.Property(f => f.Suitability)
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<Dictionary<string, string>>(v))
                .HasColumnType("text"); // JSON verisi olarak saklanır

            builder.Property(f => f.IsOrganic);

            builder.Property(f => f.IsContainsGluten);

            // İlişkiler
            builder.HasOne(f => f.Pet)
                .WithMany(p => p.Foods)
                .HasForeignKey(f => f.PetId);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPet.Core.Models;

namespace VirtualPet.Repository.Configrations
{
    public class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            // Primary Key
            builder.HasKey(p => p.Id);

            // Alanlar
            builder.Property(p => p.Species)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Breed)
                .HasMaxLength(50);

            builder.Property(p => p.Weight)
                .HasColumnType("decimal(5, 2)"); // 5 basamaklı ve 2 ondalıklı bir sayı olarak ağırlık

            // İlişkiler
            builder.HasOne(p => p.User)
                .WithMany(u => u.Pets)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade); // Eğer bir User silinirse, ona ait Pets de silinsin

            builder.HasMany(p => p.Status)
                .WithOne(s => s.Pet)
                .HasForeignKey(s => s.PetId);

            builder.HasMany(p => p.Activities)
                .WithOne(a => a.Pet)
                .HasForeignKey(a => a.PetId);

            builder.HasMany(p => p.Foods)
                .WithOne(f => f.Pet)
                .HasForeignKey(f => f.PetId);
        }
    }
}

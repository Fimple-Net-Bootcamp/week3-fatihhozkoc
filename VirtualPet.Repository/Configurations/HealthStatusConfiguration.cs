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
    public class HealthStatusConfiguration : IEntityTypeConfiguration<HealthStatus>
    {
        public void Configure(EntityTypeBuilder<HealthStatus> builder)
        {
            // Primary Key
            builder.HasKey(h => h.Id);

            // Alanlar
            builder.Property(h => h.Symptoms).HasMaxLength(500);
            builder.Property(h => h.ChronicConditions).HasMaxLength(500);
            builder.Property(h => h.BehaviorChanges).HasMaxLength(500);
            builder.Property(h => h.Diagnosis).HasMaxLength(500);
            builder.Property(h => h.TreatmentNotes).HasMaxLength(500);

            // Enum
            builder.Property(h => h.VaccinationStatus)
                .HasConversion<int>();

            // Koleksiyonlar
            builder.Property(h => h.VaccinationRecord)
                .HasConversion(v => string.Join(',', v),
                               v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList());

            builder.Property(h => h.Medications)
                .HasConversion(m => string.Join(',', m),
                               m => m.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList());

            builder.Property(h => h.Allergies).HasMaxLength(500);

            // İlişkiler
            builder.HasOne(h => h.Pet)
                .WithMany(p => p.Status)
                .HasForeignKey(h => h.PetId);
        }
    }
}

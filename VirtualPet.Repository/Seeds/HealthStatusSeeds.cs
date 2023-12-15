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
    public class HealthStatusSeeds : IEntityTypeConfiguration<HealthStatus>
    {
        public void Configure(EntityTypeBuilder<HealthStatus> builder)
        {
            // HealthStatus seed data
            builder.HasData(
                new HealthStatus
                {
                    Id = 1,
                    Symptoms = "Öksürük, halsizlik",
                    ChronicConditions = "Astım",
                    BehaviorChanges = "Daha az aktif",
                    Diagnosis = "Bronşit",
                    TreatmentNotes = "İlaç ve dinlenme",
                    VaccinationStatus = VaccinationStatus.FullyVaccinated,
                    VaccinationRecord = new List<string> { "Karma", "Kuduz" },
                    Medications = new List<string> { "Bronşit ilacı" },
                    Allergies = "Polen",
                    CheckupDate = new DateTime(2021, 6, 15),
                    PetId = 1
                },
                new HealthStatus
                {
                    Id = 2,
                    Symptoms = "İştahsızlık, kilo kaybı",
                    ChronicConditions = "Şeker hastalığı",
                    BehaviorChanges = "Daha az yeme",
                    Diagnosis = "Diyabet",
                    TreatmentNotes = "Diyet ve insülin",
                    VaccinationStatus = VaccinationStatus.PartiallyVaccinated,
                    VaccinationRecord = new List<string> { "Karma" },
                    Medications = new List<string> { "İnsülin" },
                    Allergies = "Yok",
                    CheckupDate = new DateTime(2021, 8, 20),
                    PetId = 2
                },
                new HealthStatus
                {
                    Id = 3,
                    Symptoms = "Kusma, ishal",
                    ChronicConditions = "Mide rahatsızlığı",
                    BehaviorChanges = "Huzursuzluk",
                    Diagnosis = "Gastrit",
                    TreatmentNotes = "Diyet ve mide koruyucu",
                    VaccinationStatus = VaccinationStatus.Unknown,
                    VaccinationRecord = new List<string>(),
                    Medications = new List<string> { "Mide koruyucu" },
                    Allergies = "Süt ürünleri",
                    CheckupDate = new DateTime(2021, 11, 10),
                    PetId = 3
                }
            );
        }
    }
}

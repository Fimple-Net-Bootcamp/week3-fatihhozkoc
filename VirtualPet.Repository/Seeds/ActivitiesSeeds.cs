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
    public class ActivitiesSeeds : IEntityTypeConfiguration<Activities>
    {
        public void Configure(EntityTypeBuilder<Activities> builder)
        {
            // Activities seed data
            builder.HasData(
                new Activities
                {
                    Id = 1,
                    ActivityType = ActivityType.Walking,
                    Status = ActivityStatus.Completed,
                    Effect = ActivityEffect.IncreaseEnergy,
                    Description = "Sabah yürüyüşü",
                    StartTime = new DateTime(2021, 10, 1, 8, 0, 0),
                    EndTime = new DateTime(2021, 10, 1, 9, 0, 0),
                    PetId = 1
                },
                new Activities
                {
                    Id = 2,
                    ActivityType = ActivityType.Playing,
                    Status = ActivityStatus.InProgress,
                    Effect = ActivityEffect.IncreaseHappiness,
                    Description = "Bahçede oyun oynama",
                    StartTime = new DateTime(2021, 10, 2, 15, 30, 0),
                    EndTime = new DateTime(2021, 10, 2, 16, 0, 0),
                    PetId = 2
                },
                new Activities
                {
                    Id = 3,
                    ActivityType = ActivityType.Training,
                    Status = ActivityStatus.Planned,
                    Effect = ActivityEffect.EnhanceTraining,
                    Description = "Temel itaat eğitimi",
                    StartTime = new DateTime(2021, 10, 5, 10, 0, 0),
                    EndTime = new DateTime(2021, 10, 5, 11, 0, 0),
                    PetId = 1
                }
            );
        }
    }
}

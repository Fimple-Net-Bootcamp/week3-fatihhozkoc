using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet.Core.Models
{
    // aşı durumu 
    public enum VaccinationStatus
    {
        NotVaccinated = 0,
        PartiallyVaccinated = 1,
        FullyVaccinated = 2,
        Unknown = 3
    }

    public class HealthStatus
    {
        public int Id { get; set; }
        public string Symptoms { get; set; } // semptomlar
        public string ChronicConditions { get; set; }
        public string BehaviorChanges { get; set; } // aşı geçmişi
        public string Diagnosis { get; set; }  // tanı 
        public string TreatmentNotes { get; set; } // tedavi notları 
        public VaccinationStatus VaccinationStatus { get; set; } // aşı durumu
        public List<String> VaccinationRecord { get; set; } // aşı geçmişi
        public List<String> Medications { get; set; } // kullandığı ilaçlar 
        public string Allergies { get; set; } // alerjiler
        public DateTime CheckupDate { get; set; } // sağlık konrol tarihi

        // Evcil hayvan ile bireçok ilişki
        public int PetId { get; set; }
        public virtual Pet Pet { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet.Core.Models
{
    public class Foods
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; } // kuru mama, yaş mama,ödül maması 
        public int EnergyValue { get; set; } // besinin enerji değeri 
        public string NutritionalValues { get; set; } // içerik
        public decimal PortionSize { get; set; } // porsiyon boyutu 
        public string ServingFrequency { get; set; } // servis sıklığı 
        public Dictionary<string, string> Suitability { get; set; } // hangi tür ve yaş aralığı hayvanlar için uygun olduğu 
        public bool IsOrganic { get; set; }
        public bool IsContainsGluten { get; set; }

        // Evcil hayvan ile bireçok ilişki
        public int PetId { get; set; }
        public virtual Pet Pet { get; set; }
    }
}
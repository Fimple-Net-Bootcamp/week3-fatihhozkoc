using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet.Core.Models
{
    public class Pet : BaseEntity
    {
        public string Species { get; set; }  // Kedi,köpek,kuş
        public string Breed { get; set; } // Irk
        public decimal Weight { get; set; }

        // User sınıfıyla bireçok ilişki
        public int UserId { get; set; }
        public virtual User User { get; set; }

        // Sağlık durumu sınıfı ile bire çok ilişki  -- bir evcil hayvanın birden fazla sağlık raporu olabilir.
        public ICollection<HealthStatus> Status { get; set; }

        // Aktiviteler sınıfı ile bire çok ilişki  -- bir evcil hayvanın birden fazla sağlık raporu olabilir.
        public ICollection<Activities> Activities { get; set; }

        // Yemekler sınıfı ile bire çok ilişki  -- bir evcil hayvanın birden fazla sağlık raporu olabilir.
        public ICollection<Foods> Foods { get; set; }
    }
}

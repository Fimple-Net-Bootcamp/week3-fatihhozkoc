using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet.Core.Models
{
    // Aktivite türü
    public enum ActivityType
    {
        Walking = 0,           // Yürüyüş
        Playing = 1,           // Oyun
        Training = 2,          // Eğitim
        Feeding = 3,           // Besleme
        Grooming = 4,          // Bakım
        Resting = 5,           // Dinlenme
        Exploring = 6,         // Keşif
        Swimming = 7,          // Yüzme
        AgilityTraining = 8,   // Çeviklik Eğitimi
        PuzzleGames = 9,       // Bulmaca Oyunları
        Socializing = 10,      // Sosyalleşme
        Fetching = 11,         // Top Getirme
        TugOfWar = 12,         // Halat Çekme
        HideAndSeek = 13,      // Saklambaç
        VirtualAdventure = 14  // Sanal Macera
    }

    // Aktivite durumu 
    public enum ActivityStatus
    {
        Planned = 0,    // Planlandı
        InProgress = 1, // Devam Ediyor
        Completed = 2,  // Tamamlandı
        Cancelled = 3,  // İptal Edildi
        Postponed = 4   // Ertelendi
    }

    // Aktivite etkisi
    public enum ActivityEffect
    {
        IncreaseEnergy = 0,    // Enerji Seviyesini Artırır
        IncreaseHappiness = 1, // Mutluluğu Artırır
        ImproveHealth = 2,     // Sağlığı İyileştirir
        EnhanceTraining = 3,   // Eğitimi Geliştirir
        IncreaseAppetite = 4,  // İştahı Artırır
        Calmness = 5,          // Sakinlik Sağlar
        IncreaseSocialSkills = 6, // Sosyal Becerileri Artırır
        MentalStimulation = 7,    // Zihinsel Uyarım Sağlar
        PhysicalStrength = 8,     // Fiziksel Gücü Artırır
        ImproveSleep = 9          // Uyku Kalitesini Artırır
    }

    public class Activities
    {
        public int Id { get; set; }
        public ActivityType ActivityType { get; set; }
        public ActivityStatus Status { get; set; }
        public ActivityEffect Effect { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // Evcil hayvan ile bireçok ilişki
        public int PetId { get; set; }
        public virtual Pet Pet { get; set; }
    }
}

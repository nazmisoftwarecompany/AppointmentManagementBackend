using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Subscription
{
    public class Subscription : BaseEntity
    {
        public string Name { get; set; }                    // Paket adı (Free, Premium, Enterprise)
        public string Description { get; set; }             // Paket açıklaması
        public decimal MonthlyPrice { get; set; }           // Aylık ücret
        public decimal YearlyPrice { get; set; }            // Yıllık ücret  
        public string Currency { get; set; } = "TRY";       // Para birimi
        public int MaxEmployees { get; set; }               // Maksimum çalışan sayısı
        public int MaxServices { get; set; }                // Maksimum hizmet sayısı
        public int MaxMonthlyAppointments { get; set; }     // Aylık maksimum randevu sayısı
        public bool HasAdvancedReporting { get; set; }      // Gelişmiş raporlama var mı
        public bool HasSMSNotifications { get; set; }       // SMS bildirimi var mı
        public bool HasAPIAccess { get; set; }              // API erişimi var mı
    }
}

using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Employee
{
    public class Employee : BaseEntity
    {
        public int CompanyId { get; set; }                          // Çalışanın bağlı olduğu şirketin ID'si
        public string FirstName { get; set; }                       // Çalışanın adı
        public string LastName { get; set; }                        // Çalışanın soyadı
        public string Email { get; set; }                           // Çalışanın e-posta adresi
        public string DialCode { get; set; }                        // Telefon ülke kodu (+90, +49 vb.)
        public string PhoneNumber { get; set; }                     // Çalışanın telefon numarası
        public string Position { get; set; }                        // Pozisyonu/görevi (Kuaför, Doktor, Avukat vb.)
        public string Department { get; set; }                      // Bağlı olduğu departman
        public DateTime? HireDate { get; set; }                     // İşe başlama tarihi
        public string ProfileImageUrl { get; set; }                 // Profil fotoğrafının URL'i
        public string Biography { get; set; }                       // Çalışan hakkında kısa biyografi/açıklama
        public string Specializations { get; set; }                 // Uzmanlık alanları (JSON array formatında)
        public bool CanAcceptOnlineBookings { get; set; } = true;   // Online randevu kabul edebilir mi
        public decimal HourlyRate { get; set; }                     // Saatlik ücreti
        public string Currency { get; set; } = "TRY";               // Ücretin para birimi
        public bool IsPartTime { get; set; } = false;               // Part-time çalışan mı
        public string WorkingDays { get; set; }                     // Çalıştığı günler (JSON array: [1,2,3,4,5] gibi)
    }
}
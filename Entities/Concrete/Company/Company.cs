using Entities.Abstract;
using System;

namespace Entities.Concrete.Company
{
    public class Company : BaseEntity
    {
        public int CompanyCategoryId { get; set; }                      // Şirketin hangi kategoride olduğu (kuaför, doktor, avukat vb.)
        public string CompanyName { get; set; }                         // Şirket adı
        public string Country { get; set; }                             // Şirketin bulunduğu ülke
        public string State { get; set; }                               // Eyalet/bölge bilgisi (opsiyonel)
        public string City { get; set; }                                // Şehir bilgisi
        public string District { get; set; }                            // İlçe/semt bilgisi
        public string Address { get; set; }                             // Detaylı adres bilgisi
        public string DialCode { get; set; } = "+90";                   // Ülke telefon kodu (+90, +49, +1 vb.)
        public string PhoneNumber { get; set; }                         // Şirket telefon numarası
        public string Email { get; set; }                               // Şirket e-posta adresi
        public string Website { get; set; }                             // Şirket web sitesi URL'i
        public int SubscriptionId { get; set; }                         // Abonelik paketi ID'si (Free, Premium, Enterprise vb.)
        public string LogoUrl { get; set; }                             // Şirket logosunun URL'i
        public string Timezone { get; set; } = "Europe/Istanbul";       // Şirketin bulunduğu saat dilimi
        public string Language { get; set; } = "tr";                    // Şirketin varsayılan dili (tr, en, de)
        public string Currency { get; set; } = "TRY";                   // Şirketin kullandığı para birimi
        public string Description { get; set; }                         // Şirket hakkında açıklama/tanıtım metni
        public string SocialMediaLinks { get; set; }                    // Sosyal medya hesapları (JSON formatında)
        public bool OnlineBookingEnabled { get; set; } = true;          // Online randevu alımına açık mı
        public int MaxAdvanceBookingDays { get; set; } = 30;            // Kaç gün öncesinden randevu alınabilir (maksimum)
        public int MinAdvanceBookingHours { get; set; } = 2;            // En az kaç saat öncesinden randevu alınabilir
        public int CancellationDeadlineHours { get; set; } = 24;        // Randevu iptal etme son tarihi (saat cinsinden)
        public string TaxNumber { get; set; }                   // Vergi numarası - EKSIK
        public string LicenseNumber { get; set; }               // İşyeri ruhsat numarası - EKSIK  
        public DateTime? FoundedDate { get; set; }              // Kuruluş tarihi - EKSIK
        public int? OwnerUserId { get; set; }                   // Şirket sahibi User ID - EKSIK
    }
}
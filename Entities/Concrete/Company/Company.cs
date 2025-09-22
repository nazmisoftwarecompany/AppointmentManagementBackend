using System;

namespace Entities.Concrete.Company
{
    public class Company
    {
        public int Id { get; set; } // Şirket ID
        public int CompanyCategoryId { get; set; } // Şirket kategorisi
        public string CompanyName { get; set; } // Şirket adı
        public string Country { get; set; } // Ülke
        public string State { get; set; } // Eyalet
        public string City { get; set; } // Şehir
        public string District { get; set; } // İlçe
        public string Address { get; set; } // Şirket adresi
        public DateTime CreatedAt { get; set; } // Oluşturulma tarihi
        public DateTime UpdatedAt { get; set; } // Son güncelleme tarihi
        public DateTime? DeletedAt { get; set; } // Mantıksal silme tarihi
        public string DialCode { get; set; } // Ülke kodu +90, +49
        public string PhoneNumber { get; set; } // Şirket telefon numarası
        public string Email { get; set; } // Şirket e-posta
        public string Website { get; set; } // Şirket web sitesi
        public bool IsActive { get; set; } // Aktif/Pasif durumu
        public bool IsDeleted { get; set; } // Mantıksal silme
        public int SubscriptionId { get; set; } // Abonelik türü
        public string LogoUrl { get; set; } // Şirket logosu
        public string Timezone { get; set; } // Europe/Berlin, Europe/Istanbul
        public string Language { get; set; } = "de"; // de, tr, en
        public string Currency { get; set; } = "EUR"; // EUR, USD, TRY
        public string Description { get; set; } // Şirket açıklaması
        public string SocialMediaLinks { get; set; } // JSON olarak
        public bool OnlineBookingEnabled { get; set; } = true; // Online randevu
        public int MaxAdvanceBookingDays { get; set; } = 30; // Kaç gün önceden randevu
        public int MinAdvanceBookingHours { get; set; } = 2; // En az kaç saat önceden
        public int CancellationDeadlineHours { get; set; } = 24; // İptal süresi
    }
}
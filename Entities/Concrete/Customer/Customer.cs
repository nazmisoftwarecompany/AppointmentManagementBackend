using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Customer
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }                       // Müşterinin adı
        public string LastName { get; set; }                        // Müşterinin soyadı
        public string Email { get; set; }                           // E-posta adresi (giriş için de kullanılabilir)
        public string DialCode { get; set; }                        // Telefon ülke kodu (+90, +49 vb.)
        public string PhoneNumber { get; set; }                     // Telefon numarası
        public DateTime? DateOfBirth { get; set; }                  // Doğum tarihi (yaş hesaplama, özel günler için)
        public string Gender { get; set; }                          // Cinsiyet (Male, Female, Other)
        public string Address { get; set; }                         // Ev/iş adresi
        public string City { get; set; }                            // Şehir bilgisi
        public string Country { get; set; }                         // Ülke bilgisi
        public string PreferredLanguage { get; set; } = "tr";       // Tercih edilen dil (tr, en, de)
        public string ProfileImageUrl { get; set; }                 // Profil fotoğrafının URL'i
        public bool EmailVerified { get; set; } = false;            // E-posta adresi doğrulandı mı
        public bool PhoneVerified { get; set; } = false;            // Telefon numarası doğrulandı mı
        public DateTime? LastLoginAt { get; set; }                  // Son giriş tarihi ve saati
        public string Notes { get; set; }                           // Müşteri hakkında özel notlar (alerjiler, tercihler vb.)
    }
}
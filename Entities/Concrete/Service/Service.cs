using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Service
{
    public class Service : BaseEntity
    {
        public int CompanyId { get; set; }                          // Bu hizmeti sunan şirketin ID'si
        public int ServiceCategoryId { get; set; }                  // Hizmetin ait olduğu kategori ID'si
        public string Name { get; set; }                            // Hizmetin adı (örn: "Saç Kesimi", "Diş Kontrolü")
        public string Description { get; set; }                     // Hizmet hakkında detaylı açıklama
        public int DurationMinutes { get; set; }                    // Hizmetin süresi (dakika cinsinden)
        public decimal Price { get; set; }                          // Hizmetin fiyatı
        public string Currency { get; set; } = "TRY";               // Fiyatın para birimi
        public string ImageUrl { get; set; }                        // Hizmeti temsil eden görsel URL'i
        public bool RequiresDeposit { get; set; } = false;          // Kapora gerektirir mi
        public decimal DepositPercentage { get; set; } = 0;         // Kapora yüzdesi (toplam fiyatın %'si)
        public bool IsOnlineBookingEnabled { get; set; } = true;    // Online randevu alınabilir mi
        public int MaxConcurrentBookings { get; set; } = 1;         // Aynı anda kaç kişiye bu hizmet verilebilir
        public int DisplayOrder { get; set; } = 0;                  // Listeleme sırasında görünme sırası
        public string PreparationInstructions { get; set; }         // Müşteriye randevu öncesi hazırlık talimatları
        public string CancellationPolicy { get; set; }              // Bu hizmete özel iptal politikası
    }
}
using Entities.Abstract;

namespace Entities.Concrete.Schedule
{
    public class SpecialDay : BaseEntity
    {
        public int CompanyId { get; set; }                      // Hangi şirkete ait özel gün
        public int? EmployeeId { get; set; }                    // Hangi çalışana özel (null ise tüm şirkete uygulanır)
        public string Name { get; set; }                        // Özel günün adı (örn: "Kurban Bayramı", "Dr. Ahmet İzin")
        public DateTime Date { get; set; }                      // Özel günün tarihi
        public SpecialDayType Type { get; set; }                // Özel günün türü (tatil, kapalı, izin, özel saat)
        public TimeSpan? SpecialStartTime { get; set; }         // Eğer özel saatlerde çalışılacaksa başlangıç saati
        public TimeSpan? SpecialEndTime { get; set; }           // Eğer özel saatlerde çalışılacaksa bitiş saati
        public bool IsClosed { get; set; } = false;             // O gün tamamen kapalı mı
        public string Description { get; set; }                 // Açıklama/detay bilgisi
        public bool IsRecurring { get; set; } = false;          // Her yıl tekrar eden mi (örn: resmi tatiller)
    }

    public enum SpecialDayType
    {
        Holiday = 1,        // Resmi tatil günü
        CompanyClosed = 2,  // Şirket özel nedenle kapalı
        EmployeeOff = 3,    // Çalışan izinli/hasta
        SpecialHours = 4    // Özel çalışma saatleri (normal saatlerden farklı)
    }
}
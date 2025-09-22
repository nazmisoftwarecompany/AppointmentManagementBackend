using Entities.Abstract;

namespace Entities.Concrete.Schedule
{
    public class EmployeeSchedule : BaseEntity
    {
        public int EmployeeId { get; set; }                     // Bu programın ait olduğu çalışanın ID'si
        public DayOfWeek DayOfWeek { get; set; }                // Haftanın hangi günü (Pazartesi=1, Salı=2, vb.)
        public TimeSpan? StartTime { get; set; }                // Çalışanın o gün işe başlama saati
        public TimeSpan? EndTime { get; set; }                  // Çalışanın o gün işten çıkma saati
        public bool IsAvailable { get; set; } = true;           // O gün çalışıyor mu, randevu alabilir mi
        public TimeSpan? LunchBreakStart { get; set; }          // Öğle molası başlangıç saati
        public TimeSpan? LunchBreakEnd { get; set; }            // Öğle molası bitiş saati
        public string Notes { get; set; }                       // O güne özel notlar (örn: "Sadece acil vakalar")
    }
}
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Company
{
    public class CompanyBusinessHour : BaseEntity
    {
        public int CompanyId { get; set; }                      // Bu çalışma saatlerinin ait olduğu şirketin ID'si
        public DayOfWeek DayOfWeek { get; set; }                // Haftanın hangi günü (Pazartesi=1, Salı=2, vb.)
        public TimeSpan? OpenTime { get; set; }                 // İşyeri açılış saati (null ise kapalı)
        public TimeSpan? CloseTime { get; set; }                // İşyeri kapanış saati (null ise kapalı)
        public bool IsClosed { get; set; } = false;             // Bu gün tamamen kapalı mı (tatil günü)
        public TimeSpan? LunchBreakStart { get; set; }          // Öğle arası başlangıç saati (opsiyonel)
        public TimeSpan? LunchBreakEnd { get; set; }            // Öğle arası bitiş saati (opsiyonel)
        public string Notes { get; set; }                       // O güne özel notlar (örn: "Sadece acil durumlar")
    }
}
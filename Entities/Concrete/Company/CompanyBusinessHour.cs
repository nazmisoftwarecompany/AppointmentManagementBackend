using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Company
{
    public class CompanyBusinessHour
    {
        public int CompanyId { get; set; } // Hangi şirkete ait
        public DayOfWeek DayOfWeek { get; set; } // Haftanın günü
        public TimeSpan? OpenTime { get; set; } // Açılış saati
        public TimeSpan? CloseTime { get; set; } // Kapanış saati
        public bool IsClosed { get; set; } // O gün kapalı mı
    }
}

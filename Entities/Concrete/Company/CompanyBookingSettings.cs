using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Company
{
   public class CompanyBookingSettings
    {       
        public int CompanyId { get; set; } // Hangi şirkete ait
        public int DefaultSlotDurationMinutes { get; set; } // Varsayılan hizmet süresi
        public int BufferTimeBetweenAppointments { get; set; } // Randevular arası boşluk
        public bool AllowDoubleBooking { get; set; } // Aynı anda birden fazla randevu
        
    }
}

using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Company
{
    public class CompanyBookingSettings : BaseEntity
    {
        public int CompanyId { get; set; }                                  // Bu ayarların ait olduğu şirketin ID'si
        public int DefaultSlotDurationMinutes { get; set; } = 30;           // Varsayılan randevu süresi (dakika cinsinden)
        public int BufferTimeBetweenAppointments { get; set; } = 5;         // Randevular arası boşluk süresi (temizlik, hazırlık için)
        public bool AllowDoubleBooking { get; set; } = false;               // Aynı saatte birden fazla randevu alınabilir mi
        public int MaxConcurrentAppointments { get; set; } = 1;             // Aynı anda maksimum kaç randevu alınabilir
        public bool RequireCustomerConfirmation { get; set; } = true;       // Müşteri randevuyu onaylamak zorunda mı
        public bool SendReminderEmail { get; set; } = true;                 // Hatırlatma e-postası gönderilsin mi
        public int ReminderHoursBeforeAppointment { get; set; } = 24;       // Randevudan kaç saat önce hatırlatma gönderilecek
        public bool AllowRescheduling { get; set; } = true;                 // Randevu ertelenebilir mi
        public int ReschedulingDeadlineHours { get; set; } = 2;             // Randevudan kaç saat önceye kadar erteleme yapılabilir
    }
}
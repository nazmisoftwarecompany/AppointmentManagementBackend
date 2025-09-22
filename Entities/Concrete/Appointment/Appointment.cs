using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Appointment
{
    public enum AppointmentStatus
    {
        Pending = 1,      // Randevu beklemede, henüz onaylanmadı
        Confirmed = 2,    // Randevu onaylandı
        InProgress = 3,   // Randevu devam ediyor, hizmet verilmeye başlandı
        Completed = 4,    // Randevu tamamlandı, hizmet verildi
        Cancelled = 5,    // Randevu iptal edildi
        NoShow = 6,       // Müşteri gelmedi, randevuya katılmadı
        Rescheduled = 7   // Randevu yeniden planlandı, başka tarihe ertelendi
    }

    public class Appointment : BaseEntity
    {
        public int CompanyId { get; set; }                          // Hangi şirkete ait randevu
        public int CustomerId { get; set; }                         // Randevuyu alan müşteri/kullanıcı ID
        public int ServiceId { get; set; }                          // Alınan hizmetin ID'si
        public int EmployeeId { get; set; }                         // Hizmeti verecek çalışan ID'si
        public DateTime AppointmentDate { get; set; }               // Randevu tarihi (sadece tarih kısmı)
        public TimeSpan StartTime { get; set; }                     // Randevunun başlangıç saati
        public TimeSpan EndTime { get; set; }                       // Randevunun bitiş saati
        public AppointmentStatus Status { get; set; } = AppointmentStatus.Pending;  // Randevunun mevcut durumu
        public decimal TotalPrice { get; set; }                     // Toplam ücret
        public string Currency { get; set; } = "TRY";               // Para birimi (TRY, EUR, USD)
        public decimal DepositPaid { get; set; } = 0;               // Ödenen kapora miktarı
        public bool IsDepositPaid { get; set; } = false;            // Kapora ödenip ödenmediği
        public string CustomerNotes { get; set; }                   // Müşterinin randevu ile ilgili notları
        public string EmployeeNotes { get; set; }                   // Çalışanın randevu ile ilgili notları
        public string CancellationReason { get; set; }              // İptal nedeni (eğer iptal edildiyse)
        public DateTime? CancelledAt { get; set; }                  // İptal edilme tarihi ve saati
        public DateTime? ConfirmedAt { get; set; }                  // Onaylanma tarihi ve saati
        public DateTime? CompletedAt { get; set; }                  // Tamamlanma tarihi ve saati
        public bool ReminderSent { get; set; } = false;             // Hatırlatma maili/SMS'i gönderildi mi
        public DateTime? ReminderSentAt { get; set; }               // Hatırlatmanın gönderilme tarihi
        public int? RescheduledFromAppointmentId { get; set; }      // Eğer bu randevu başka bir randevudan ertelenmiş ise, eski randevunun ID'si
        public string BookingSource { get; set; } = "Online";       // Randevunun nasıl alındığı (Online, Phone, Walk-in)
        public string BookingReference { get; set; }                // Randevu referans numarası (benzersiz takip kodu)
    }
}
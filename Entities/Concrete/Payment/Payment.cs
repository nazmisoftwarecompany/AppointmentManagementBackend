using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Payment
{
    public enum PaymentStatus
    {
        Pending = 1, Completed = 2, Failed = 3, Refunded = 4, Cancelled = 5
    }

    public enum PaymentType
    {
        FullPayment = 1, Deposit = 2, RemainingBalance = 3
    }

    public class Payment : BaseEntity
    {
        public int AppointmentId { get; set; }              // Hangi randevu için ödeme
        public int CustomerId { get; set; }                 // Ödemeyi yapan müşteri
        public decimal Amount { get; set; }                 // Ödeme tutarı
        public string Currency { get; set; } = "TRY";       // Para birimi
        public PaymentType PaymentType { get; set; }        // Ödeme türü (tam, kapora, kalan)
        public PaymentStatus Status { get; set; }           // Ödeme durumu
        public string PaymentMethod { get; set; }           // Ödeme yöntemi (Cash, Card, Online)
        public string TransactionId { get; set; }           // İşlem ID (banka/ödeme sağlayıcısından)
        public DateTime? PaidAt { get; set; }               // Ödenme tarihi
        public string Notes { get; set; }                   // Ödeme ile ilgili notlar
    }
}

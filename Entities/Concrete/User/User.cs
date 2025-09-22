using Entities.Abstract;

namespace Entities.Concrete.User
{
    public class User : BaseEntity
    {
        public string Username { get; set; }                    // Kullanıcı adı (sisteme giriş için)
        public string Email { get; set; }                       // E-posta adresi
        public string PasswordHash { get; set; }                // Şifrelenmiş parola
        public UserRole Role { get; set; }                      // Kullanıcı rolü
        public int? CompanyId { get; set; }                     // Bağlı olduğu şirket (varsa)
        public int? EmployeeId { get; set; }                    // Bağlı olduğu çalışan kaydı (varsa)
        public int? CustomerId { get; set; }                    // Bağlı olduğu müşteri kaydı (varsa) - EKSIK
        public bool IsEmailVerified { get; set; }               // E-posta doğrulandı mı
        public DateTime? LastLoginAt { get; set; }              // Son giriş tarihi
        public bool IsLocked { get; set; }                      // Hesap kilitli mi
        public int FailedLoginAttempts { get; set; }            // Başarısız giriş denemesi sayısı
        public DateTime? LockoutEndTime { get; set; }           // Kilit süresi bitişi - EKSIK
        public string RefreshToken { get; set; }                // JWT refresh token - EKSIK
        public DateTime? RefreshTokenExpiryTime { get; set; }   // Refresh token süresi - EKSIK
    }

    public enum UserRole
    {
        SuperAdmin = 1,    // Sistem yöneticisi
        CompanyAdmin = 2,  // Şirket yöneticisi
        Employee = 3,      // Çalışan
    }
}

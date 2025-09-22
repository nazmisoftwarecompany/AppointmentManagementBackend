using Entities.Abstract;

namespace Entities.Concrete.User
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public UserRole Role { get; set; }
        public int? CompanyId { get; set; }  // Eğer şirket çalışanıysa
        public int? EmployeeId { get; set; } // Eğer employee ise
        public bool IsEmailVerified { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public bool IsLocked { get; set; }
        public int FailedLoginAttempts { get; set; }
      
    }

    public enum UserRole
    {
        SuperAdmin = 1,    // Sistem yöneticisi
        CompanyAdmin = 2,  // Şirket yöneticisi
        Employee = 3,      // Çalışan
    }
}

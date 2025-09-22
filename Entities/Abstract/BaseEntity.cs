using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }                             // Birincil anahtar
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;  // Oluşturulma tarihi
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;  // Son güncelleme tarihi  
        public DateTime? DeletedAt { get; set; }                // Silinme tarihi (soft delete)
        public bool IsDeleted { get; set; } = false;            // Silinmiş mi
        public bool IsActive { get; set; } = true;              // Aktif mi
        public int? CreatedBy { get; set; }                     // Kim oluşturdu (User ID) - EKSIK
        public int? UpdatedBy { get; set; }                     // Kim güncelledi (User ID) - EKSIK
    }
}

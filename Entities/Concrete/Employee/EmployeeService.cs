using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Employee
{
    public class EmployeeService : BaseEntity
    {
        public int EmployeeId { get; set; }                 // Hangi çalışan
        public int ServiceId { get; set; }                  // Hangi hizmet verebilir
        public decimal? CustomPrice { get; set; }           // Bu çalışan için özel fiyat (varsa)
        public int? CustomDurationMinutes { get; set; }     // Bu çalışan için özel süre (varsa)
    }
}

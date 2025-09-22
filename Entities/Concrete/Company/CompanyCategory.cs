using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Company
{
    public class CompanyCategory
    {
        public int CompanyCategoryId { get; set; } // Kategori ID
        public string Name { get; set; } // Kategori adı
        public string Description { get; set; } // Kategori açıklaması
    }
}

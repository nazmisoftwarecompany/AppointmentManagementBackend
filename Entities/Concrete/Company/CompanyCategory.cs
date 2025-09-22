using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Company
{
    public class CompanyCategory : BaseEntity
    {
        public string Name { get; set; }                        // Kategori adı (Kuaför, Doktor, Avukat, vb.)
        public string Description { get; set; }                 // Kategori açıklaması
        public string IconUrl { get; set; }                     // Kategori ikonu URL'i
        public int DisplayOrder { get; set; } = 0;              // Listeleme sırası
    }
}

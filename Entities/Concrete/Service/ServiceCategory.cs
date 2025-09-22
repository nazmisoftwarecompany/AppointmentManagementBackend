using Entities.Abstract;

namespace Entities.Concrete.Service
{
    public class ServiceCategory : BaseEntity
    {
        public int CompanyId { get; set; }                         // Bu kategoriye ait şirketin ID'si
        public string Name { get; set; }                           // Kategori adı (örn: "Saç Hizmetleri", "Diş Hizmetleri")
        public string Description { get; set; }                     // Kategori hakkında detaylı açıklama
        public string IconUrl { get; set; }                        // Kategoriyi temsil eden ikon/görsel URL'i
        public int DisplayOrder { get; set; } = 0;                 // Listeleme sırasında görünme sırası
    }
}

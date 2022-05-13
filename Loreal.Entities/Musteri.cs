using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loreal.Entities
{
    public class Musteri : BaseEntity, IEntity
    {
        public string MusteriKodu { get; set; }
        public string ÖusteriAdi { get; set; }
        public string IletisimNo { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public string VergiNo { get; set; }
        public string VergiDairesi { get; set; }
        public IList<KontakKisi> KontakKisiler { get; set; }
    }
}

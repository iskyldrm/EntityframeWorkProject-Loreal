using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loreal.Entities
{
    public class Kategori:BaseEntity,IEntity
    {
        public string KategoriAdi { get; set; }
        public string Acıklama { get; set; }
        public IList<Urun> Urunler { get; set; }

    }
}

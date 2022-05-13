using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loreal.Entities
{
    public class SiparisMaster:BaseEntity,IEntity
    {
        public int MusteriId { get; set; }
        public Musteri Musteri { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public DateTime? TeslimTarihi { get; set; }
        public int PersonelId { get; set; }
        public Personel Personel { get; set; }
        public decimal ToplamaTutar { get; set; }
        public decimal ToplamKdv { get; set; }
        public Doviz Doviz { get; set; }


    }
}

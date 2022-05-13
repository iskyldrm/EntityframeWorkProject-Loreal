using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loreal.Entities
{
    public  class SiparisDetay:BaseEntity,IEntity
    {
        public int SiparisMasterId { get; set; }
        public SiparisMaster SiparisMaster { get; set; }
        public int UrunId { get; set; }
        public Urun Urun { get; set; }
        public decimal UrunFiyat { get; set; }
        public decimal Decimal { get; set; }
        public float IndirimOranı { get; set; }
        public float KdvOrani { get; set; }

    }
}

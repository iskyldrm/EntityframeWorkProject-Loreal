using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loreal.Entities
{
    public abstract class Kisi:BaseEntity,IEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }
        public string Telefon { get; set; }
        public string OzelKod { get; set; }
        public string OzelKod2 { get; set; }
        public string Adres { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool Cinsiyet { get; set; }

    }
}

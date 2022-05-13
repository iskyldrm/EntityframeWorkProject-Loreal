namespace Loreal.Entities
{
    public class Urun:BaseEntity,IEntity
    {
        public string UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        public string Acıklama { get; set; }
        public Birim Birim { get; set; }
        public string Barkod { get; set; }
        public IList<Kategori> Kategoriler { get; set; }
        public IList<UrunFiyat> Fiyat { get; set; }
        public int KdvId { get; set; }
        public Kdv Kdv { get; set; }
        public decimal MinStokSeviyesi { get; set; }
        public decimal StokMiktarı { get; set; }
        public IList<UrunFoto> Fotoğraflar { get; set; }
        public Marka Marka { get; set; }
        public DateTime SKT { get; set; }
        public DateTime UUT { get; set; }
        public IList<Tedarikci> Tedarikciler { get; set; }

    }
}
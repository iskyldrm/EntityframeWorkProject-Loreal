namespace Loreal.Entities
{
    public class Firma:BaseEntity,IEntity
    {
        public AnaFirma Anafirma { get; set; }
        public string FirmaKodu { get; set; }
        public string FirmaAdi { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string Adres { get; set; }
        public string OzelKod1 { get; set; }
        public string OzelKod2 { get; set; }
        public string IletisimNo { get; set; }
        public string Email { get; set; }
        public IList<KontakKisi> KontakKisiler { get; set; }
        public int PersonelId { get; set; }
        public Personel Personel { get; set; }
        public decimal RiskLimiti { get; set; }
        public string OzelNot { get; set; }
        public bool IstihbaratOnay { get; set; }
        public string IstihbaratNot { get; set; }

    }
}
namespace Loreal.Entities
{
    public class UrunFiyat:BaseEntity,IEntity
    {
        public Urun Urun { get; set; }
        public decimal Fiyat1 { get; set; }
        public decimal Fiyat2 { get; set; }
        public decimal Fiyat3 { get; set; }
        public decimal Fiyat4 { get; set; }
        public decimal Fiyat5 { get; set; }

    }
}
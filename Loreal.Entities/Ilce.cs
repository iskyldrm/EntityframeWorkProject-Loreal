namespace Loreal.Entities
{
    public class Ilce:BaseEntity,IEntity
    {
        public string IlceAdi { get; set; }
        public Sehir Sehir { get; set; }
        public int SehirId { get; set; }

    }
}
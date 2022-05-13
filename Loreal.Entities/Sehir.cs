namespace Loreal.Entities
{
    public class Sehir:BaseEntity,IEntity
    {
        public string SehirAdi { get; set; }
        public IList<Ilce> IlceAdi { get; set; }
    }
}
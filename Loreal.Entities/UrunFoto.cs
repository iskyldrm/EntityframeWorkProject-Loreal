namespace Loreal.Entities
{
    public class UrunFoto:BaseEntity,IEntity
    {
        public Urun Urun { get; set; }
        public string Path { get; set; }
        public string Url { get; set; }

    }
}
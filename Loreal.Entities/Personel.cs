namespace Loreal.Entities
{
    public class Personel:Kisi
    {
        public string PersonelKodu { get; set; }
        public int DepartmanId { get; set; }
        public Departman Departman { get; set; }
        public decimal Maas { get; set; }
        public Sehir DogumYeri { get; set; }

    }
}
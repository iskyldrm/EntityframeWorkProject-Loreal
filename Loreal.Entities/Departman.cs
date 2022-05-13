namespace Loreal.Entities
{
    public class Departman:BaseEntity
    {
        public string DepartmanKodu { get; set; }
        public string DepartmanAdi { get; set; }
        public int? UstDepartmanId { get; set; }
        public Departman UstDepartman { get; set; }
        public IList<Personel> Personel { get; set; }

    }
}
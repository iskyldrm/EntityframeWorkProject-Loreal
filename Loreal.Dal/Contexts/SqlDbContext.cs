using Loreal.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Loreal.Dal.Contexts
{
    public class SqlDbContext:DbContext
    {
        public DbSet<AnaFirma> AnaFirmalar { get; set; }
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<Birim> Birimler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<KontakKisi> KontakKisiler { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Tedarikci> Tedarikciler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<UrunFoto> UrunFotolar { get; set; }
        public DbSet<UrunFiyat> UrunFiyatlar { get; set; }

        public SqlDbContext()
        {

        }
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}

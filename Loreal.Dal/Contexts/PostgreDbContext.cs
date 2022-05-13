
using Loreal.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Loreal.DAL.Contexts
{
    public class PostgreDbContext : DbContext
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
        public DbSet<UrunFiyat> UrunFiyatlari { get; set; }

        public PostgreDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string constr = @"server=127.0.0.1;database=lorael;UserId=postgres;Password=isakisak1234";
            optionsBuilder.UseNpgsql(constr);
        }
        public PostgreDbContext(DbContextOptions<PostgreDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //2. Yol
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
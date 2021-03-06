// <auto-generated />
using System;
using Loreal.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Loreal.Dal.Migrations.PostgreDb
{
    [DbContext(typeof(PostgreDbContext))]
    [Migration("20220513133120_InitKdvDal")]
    partial class InitKdvDal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("KategoriUrun", b =>
                {
                    b.Property<int>("KategorilerId")
                        .HasColumnType("integer");

                    b.Property<int>("UrunlerId")
                        .HasColumnType("integer");

                    b.HasKey("KategorilerId", "UrunlerId");

                    b.HasIndex("UrunlerId");

                    b.ToTable("KategoriUrun");
                });

            modelBuilder.Entity("Loreal.Entities.AnaFirma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirmaAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirmaKodu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("AnaFirmalar");
                });

            modelBuilder.Entity("Loreal.Entities.Birim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Acıklama")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("BirimKod")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Birimler");
                });

            modelBuilder.Entity("Loreal.Entities.Departman", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DepartmanAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DepartmanKodu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("UstDepartmanId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UstDepartmanId");

                    b.ToTable("Departman");
                });

            modelBuilder.Entity("Loreal.Entities.Firma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("AnafirmaId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirmaAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirmaKodu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IletisimNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IstihbaratNot")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IstihbaratOnay")
                        .HasColumnType("boolean");

                    b.Property<string>("OzelKod1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OzelKod2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OzelNot")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PersonelId")
                        .HasColumnType("integer");

                    b.Property<decimal>("RiskLimiti")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("VergiDairesi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("VergiNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AnafirmaId");

                    b.HasIndex("PersonelId");

                    b.ToTable("Firmalar");
                });

            modelBuilder.Entity("Loreal.Entities.Ilce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("IlceAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SehirId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("SehirId");

                    b.ToTable("Ilce");
                });

            modelBuilder.Entity("Loreal.Entities.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Acıklama")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("Loreal.Entities.Kdv", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("KdvAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("KdvOrani")
                        .HasColumnType("real");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Kdv");
                });

            modelBuilder.Entity("Loreal.Entities.KontakKisi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Cinsiyet")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Departman")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("FirmaId")
                        .HasColumnType("integer");

                    b.Property<string>("Gsm")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OzelKod")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OzelKod2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TcNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("TedarikciId")
                        .HasColumnType("integer");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("FirmaId");

                    b.HasIndex("TedarikciId");

                    b.ToTable("KontakKisiler");
                });

            modelBuilder.Entity("Loreal.Entities.Marka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("MarkaAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Markalar");
                });

            modelBuilder.Entity("Loreal.Entities.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Cinsiyet")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DepartmanId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DogumYeriId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Gsm")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Maas")
                        .HasColumnType("numeric");

                    b.Property<string>("OzelKod")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OzelKod2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PersonelKodu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TcNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("DepartmanId");

                    b.HasIndex("DogumYeriId");

                    b.ToTable("Personeller");
                });

            modelBuilder.Entity("Loreal.Entities.Sehir", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SehirAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Sehir");
                });

            modelBuilder.Entity("Loreal.Entities.Tedarikci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IletisimTelefonNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TedarikciKodu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TedarikçiAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("UrunId")
                        .HasColumnType("integer");

                    b.Property<string>("VergiDairesi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("VergiNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UrunId");

                    b.ToTable("Tedarikciler");
                });

            modelBuilder.Entity("Loreal.Entities.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Acıklama")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Barkod")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("BirimId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("KdvId")
                        .HasColumnType("integer");

                    b.Property<int>("MarkaId")
                        .HasColumnType("integer");

                    b.Property<decimal>("MinStokSeviyesi")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("SKT")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("StokMiktarı")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("UUT")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UrunKodu")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BirimId");

                    b.HasIndex("KdvId");

                    b.HasIndex("MarkaId");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("Loreal.Entities.UrunFiyat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("Fiyat1")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Fiyat2")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Fiyat3")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Fiyat4")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Fiyat5")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UrunId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UrunId");

                    b.ToTable("UrunFiyatlari");
                });

            modelBuilder.Entity("Loreal.Entities.UrunFoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UrunId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UrunId");

                    b.ToTable("UrunFotolar");
                });

            modelBuilder.Entity("KategoriUrun", b =>
                {
                    b.HasOne("Loreal.Entities.Kategori", null)
                        .WithMany()
                        .HasForeignKey("KategorilerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Loreal.Entities.Urun", null)
                        .WithMany()
                        .HasForeignKey("UrunlerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Loreal.Entities.Departman", b =>
                {
                    b.HasOne("Loreal.Entities.Departman", "UstDepartman")
                        .WithMany()
                        .HasForeignKey("UstDepartmanId");

                    b.Navigation("UstDepartman");
                });

            modelBuilder.Entity("Loreal.Entities.Firma", b =>
                {
                    b.HasOne("Loreal.Entities.AnaFirma", "Anafirma")
                        .WithMany("Firmalar")
                        .HasForeignKey("AnafirmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Loreal.Entities.Personel", "Personel")
                        .WithMany()
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Anafirma");

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("Loreal.Entities.Ilce", b =>
                {
                    b.HasOne("Loreal.Entities.Sehir", "Sehir")
                        .WithMany("IlceAdi")
                        .HasForeignKey("SehirId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sehir");
                });

            modelBuilder.Entity("Loreal.Entities.KontakKisi", b =>
                {
                    b.HasOne("Loreal.Entities.Firma", "Firma")
                        .WithMany("KontakKisiler")
                        .HasForeignKey("FirmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Loreal.Entities.Tedarikci", null)
                        .WithMany("kontakKisiler")
                        .HasForeignKey("TedarikciId");

                    b.Navigation("Firma");
                });

            modelBuilder.Entity("Loreal.Entities.Personel", b =>
                {
                    b.HasOne("Loreal.Entities.Departman", "Departman")
                        .WithMany("Personel")
                        .HasForeignKey("DepartmanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Loreal.Entities.Sehir", "DogumYeri")
                        .WithMany()
                        .HasForeignKey("DogumYeriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departman");

                    b.Navigation("DogumYeri");
                });

            modelBuilder.Entity("Loreal.Entities.Tedarikci", b =>
                {
                    b.HasOne("Loreal.Entities.Urun", null)
                        .WithMany("Tedarikciler")
                        .HasForeignKey("UrunId");
                });

            modelBuilder.Entity("Loreal.Entities.Urun", b =>
                {
                    b.HasOne("Loreal.Entities.Birim", "Birim")
                        .WithMany()
                        .HasForeignKey("BirimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Loreal.Entities.Kdv", "Kdv")
                        .WithMany()
                        .HasForeignKey("KdvId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Loreal.Entities.Marka", "Marka")
                        .WithMany()
                        .HasForeignKey("MarkaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Birim");

                    b.Navigation("Kdv");

                    b.Navigation("Marka");
                });

            modelBuilder.Entity("Loreal.Entities.UrunFiyat", b =>
                {
                    b.HasOne("Loreal.Entities.Urun", "Urun")
                        .WithMany("Fiyat")
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("Loreal.Entities.UrunFoto", b =>
                {
                    b.HasOne("Loreal.Entities.Urun", "Urun")
                        .WithMany("Fotoğraflar")
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("Loreal.Entities.AnaFirma", b =>
                {
                    b.Navigation("Firmalar");
                });

            modelBuilder.Entity("Loreal.Entities.Departman", b =>
                {
                    b.Navigation("Personel");
                });

            modelBuilder.Entity("Loreal.Entities.Firma", b =>
                {
                    b.Navigation("KontakKisiler");
                });

            modelBuilder.Entity("Loreal.Entities.Sehir", b =>
                {
                    b.Navigation("IlceAdi");
                });

            modelBuilder.Entity("Loreal.Entities.Tedarikci", b =>
                {
                    b.Navigation("kontakKisiler");
                });

            modelBuilder.Entity("Loreal.Entities.Urun", b =>
                {
                    b.Navigation("Fiyat");

                    b.Navigation("Fotoğraflar");

                    b.Navigation("Tedarikciler");
                });
#pragma warning restore 612, 618
        }
    }
}

namespace kitaptakas.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AdminContext : DbContext
    {
        public AdminContext()
            : base("name=AdminContext")
        {
        }

        public virtual DbSet<Galeri> Galeri { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<Kitaplar> Kitaplar { get; set; }
        public virtual DbSet<Kullanicilar> Kullanicilar { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<YayinEvi> YayinEvi { get; set; }
        public virtual DbSet<Yazar> Yazar { get; set; }
        public virtual DbSet<Yetki> Yetki { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Galeri>()
                .Property(e => e.galeriResimYolu)
                .IsUnicode(false);

            modelBuilder.Entity<Kategori>()
                .Property(e => e.kategoriAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Kitaplar>()
                .Property(e => e.kitapAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Kitaplar>()
                .Property(e => e.kitapResimYolu)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanicilar>()
                .Property(e => e.kullaniciAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanicilar>()
                .Property(e => e.kullaniciSoyadi)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanicilar>()
                .Property(e => e.eMail)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanicilar>()
                .Property(e => e.sifre)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanicilar>()
                .Property(e => e.adres)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanicilar>()
                .Property(e => e.telefon)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanicilar>()
                .Property(e => e.kullaniciResimYolu)
                .IsUnicode(false);

            modelBuilder.Entity<YayinEvi>()
                .Property(e => e.yayinEviAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Yazar>()
                .Property(e => e.yazarAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Yetki>()
                .Property(e => e.yetkiAdi)
                .IsUnicode(false);

        }
    }
}

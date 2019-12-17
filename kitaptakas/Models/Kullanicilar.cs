namespace kitaptakas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanicilar")]
    public partial class Kullanicilar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanicilar()
        {
            Kitaplar = new HashSet<Kitaplar>();
        }

        [Key]
        public int kullaniciID { get; set; }

        [StringLength(100)]
        public string kullaniciAdi { get; set; }

        [StringLength(100)]
        public string kullaniciSoyadi { get; set; }

        [StringLength(100)]
        public string eMail { get; set; }

        [StringLength(100)]
        public string sifre { get; set; }

        public byte? cinsiyet { get; set; }

        [StringLength(1000)]
        public string adres { get; set; }

        [StringLength(10)]
        public string telefon { get; set; }

        public int? yetkiID { get; set; }

        [StringLength(5000)]
        public string kullaniciResimYolu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kitaplar> Kitaplar { get; set; }

        public virtual Yetki Yetki { get; set; }
    }
}

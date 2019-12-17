namespace kitaptakas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kitaplar")]
    public partial class Kitaplar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kitapID { get; set; }

        [Column(TypeName = "text")]
        public string kitapAdi { get; set; }

        public int? yazarID { get; set; }

        public int? yayinEviID { get; set; }

        public int? kategoriID { get; set; }

        public int? basimYili { get; set; }

        [Column(TypeName = "text")]
        public string kitapResimYolu { get; set; }

        public int? kullaniciID { get; set; }

        public byte? takasta { get; set; }

        public virtual Kategori Kategori { get; set; }

        public virtual Kullanicilar Kullanicilar { get; set; }

        public virtual YayinEvi YayinEvi { get; set; }

        public virtual Yazar Yazar { get; set; }
    }
}

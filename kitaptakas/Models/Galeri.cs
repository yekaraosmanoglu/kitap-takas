namespace kitaptakas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Galeri")]
    public partial class Galeri
    {
        [Key]
        public int resimID { get; set; }

        [Column(TypeName = "text")]
        public string galeriResimYolu { get; set; }
    }
}

namespace kitaptakas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("YayinEvi")]
    public partial class YayinEvi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public YayinEvi()
        {
            Kitaplar = new HashSet<Kitaplar>();
        }

        public int yayinEviID { get; set; }

        [Column(TypeName = "text")]
        public string yayinEviAdi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kitaplar> Kitaplar { get; set; }
    }
}

namespace WpfApp2879789797898798798798797897.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderComposition = new HashSet<OrderComposition>();
            Placement = new HashSet<Placement>();
            Placement1 = new HashSet<Placement>();
        }

        [Key]
        [StringLength(10)]
        public string article_number { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [StringLength(10)]
        public string unit { get; set; }

        public float? stroimost { get; set; }

        public float? max_discount { get; set; }

        public int? manufacturer2 { get; set; }

        public int? provider2 { get; set; }

        public int? category_number { get; set; }

        public float? discount { get; set; }

        public int? quantity_in_stock { get; set; }

        public string description { get; set; }

        [StringLength(50)]
        public string photo { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderComposition> OrderComposition { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Placement> Placement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Placement> Placement1 { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }

        public virtual Provider Provider { get; set; }
    }
}

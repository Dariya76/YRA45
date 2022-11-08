namespace WpfApp2879789797898798798798797897.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Placement")]
    public partial class Placement
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int entry_number { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string article_number { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_warehouse { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int number_of_products { get; set; }

        public virtual Product Product { get; set; }

        public virtual Product Product1 { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}

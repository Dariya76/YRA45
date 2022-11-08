namespace WpfApp2879789797898798798798797897.BD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int order_numder { get; set; }

        [Column(TypeName = "date")]
        public DateTime order_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime delivery_date { get; set; }

        public int? ID_item { get; set; }

        public int? ID_client { get; set; }

        public int code_to_get { get; set; }

        [StringLength(50)]
        public string status { get; set; }

        public virtual Point Point { get; set; }

        public virtual Users Users { get; set; }

        public virtual OrderComposition OrderComposition { get; set; }
    }
}

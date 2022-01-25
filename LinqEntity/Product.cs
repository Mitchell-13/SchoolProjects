namespace MOLinqEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [StringLength(5)]
        public string Product_Number { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public int Units_On_Hand { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [StringLength(30)]
        public string Category { get; set; }
    }
}

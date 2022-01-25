using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOJellybeanApp
{
    // The table will be called JellyBellyTable
    [Table("JellyBellyTable")]
    public class JellyBelly
    {
        // Primary key called JellyBellyId
        [Key]
        public int JellyBellyId { get; set; }

        // New column for the flavor called jellyBellyFlavor
        [StringLength(50)]
        public string jellyBellyFlavor { get; set; }

        // New column for category called... category
        [StringLength(50)]
        public string category { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo_Tranning_WPF.Models
{
    public partial class Stock
    {
        [Key]
        [StringLength(50)]
        public string StockID { get; set; }
        [Required]
        [StringLength(50)]
        public string StockCode { get; set; }
        [Required]
        [StringLength(50)]
        public string StockName { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [StringLength(50)]
        public string ModifiedBy { get; set; }
    }
}

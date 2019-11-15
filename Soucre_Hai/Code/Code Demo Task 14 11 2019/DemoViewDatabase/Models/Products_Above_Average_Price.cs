using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoViewDatabase.Models
{
    public partial class Products_Above_Average_Price
    {
        [StringLength(50)]
        public string ProductName { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Price { get; set; }
    }
}

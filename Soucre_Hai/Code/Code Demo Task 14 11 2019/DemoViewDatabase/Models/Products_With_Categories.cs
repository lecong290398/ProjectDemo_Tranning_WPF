using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoViewDatabase.Models
{
    public partial class Products_With_Categories
    {
        public int ProductID { get; set; }
        [StringLength(50)]
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Price { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
    }
}

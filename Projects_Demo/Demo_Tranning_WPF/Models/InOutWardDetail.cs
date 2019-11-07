using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo_Tranning_WPF.Models
{
    public partial class InOutWardDetail
    {
        [Key]
        [StringLength(50)]
        public string Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FK_InOutWard { get; set; }
        [Required]
        [StringLength(50)]
        public string FK_InvntoryItem { get; set; }
        public int Quantity { get; set; }
        public int PlanQuantity { get; set; }
    }
}

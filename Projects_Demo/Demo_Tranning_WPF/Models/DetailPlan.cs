using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo_Tranning_WPF.Models
{
    public partial class DetailPlan
    {
        [Key]
        [StringLength(50)]
        public string Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FK_Plan { get; set; }
        [Required]
        [StringLength(50)]
        public string FK_InventoryItem { get; set; }
        public int Quantity { get; set; }

        [ForeignKey(nameof(FK_Plan))]
        [InverseProperty(nameof(Plan.DetailPlan))]
        public virtual Plan FK_PlanNavigation { get; set; }
    }
}

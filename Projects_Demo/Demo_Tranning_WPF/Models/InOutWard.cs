using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo_Tranning_WPF.Models
{
    public partial class InOutWard
    {
        public InOutWard()
        {
            InventoryItemLedger = new HashSet<InventoryItemLedger>();
        }

        [Key]
        [StringLength(50)]
        public string Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Fk_InventoryItem { get; set; }
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        public bool IsInWard { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCreate { get; set; }
        [Required]
        [StringLength(50)]
        public string FK_CreateObject { get; set; }
        [StringLength(50)]
        public string FK_ModifyObject { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateModify { get; set; }
        [Required]
        [StringLength(50)]
        public string FK_PlanId { get; set; }
        public int Status { get; set; }
        public bool IsDelete { get; set; }

        [ForeignKey(nameof(FK_PlanId))]
        [InverseProperty(nameof(Plan.InOutWard))]
        public virtual Plan FK_Plan { get; set; }
        [InverseProperty("FK_InOutWardNavigation")]
        public virtual ICollection<InventoryItemLedger> InventoryItemLedger { get; set; }
    }
}

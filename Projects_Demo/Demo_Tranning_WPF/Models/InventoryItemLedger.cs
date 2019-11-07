using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo_Tranning_WPF.Models
{
    public partial class InventoryItemLedger
    {
        [Key]
        [StringLength(50)]
        public string Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FK_DetailStock { get; set; }
        [Required]
        [StringLength(50)]
        public string FK_InOutWard { get; set; }
        [Required]
        [StringLength(50)]
        public string FK_FromObject { get; set; }
        [Required]
        [StringLength(50)]
        public string FK_ToObject { get; set; }
        public bool IsInWard { get; set; }

        [ForeignKey(nameof(FK_InOutWard))]
        [InverseProperty(nameof(InOutWard.InventoryItemLedger))]
        public virtual InOutWard FK_InOutWardNavigation { get; set; }
    }
}

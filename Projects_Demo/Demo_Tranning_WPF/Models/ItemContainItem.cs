using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo_Tranning_WPF.Models
{
    public partial class ItemContainItem
    {
        [Key]
        [StringLength(50)]
        public string Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FK_ParrentItem { get; set; }
        [Required]
        [StringLength(50)]
        public string FK_ChildItem { get; set; }
        public int NumberOfChild { get; set; }

        [ForeignKey(nameof(FK_ChildItem))]
        [InverseProperty(nameof(InventoryItem.ItemContainItemFK_ChildItemNavigation))]
        public virtual InventoryItem FK_ChildItemNavigation { get; set; }
        [ForeignKey(nameof(FK_ParrentItem))]
        [InverseProperty(nameof(InventoryItem.ItemContainItemFK_ParrentItemNavigation))]
        public virtual InventoryItem FK_ParrentItemNavigation { get; set; }
    }
}

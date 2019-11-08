using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo_Tranning_WPF.Models
{
    public partial class InventoryItem
    {
        public InventoryItem()
        {
            ItemContainItemFK_ChildItemNavigation = new HashSet<ItemContainItem>();
            ItemContainItemFK_ParrentItemNavigation = new HashSet<ItemContainItem>();
        }

        [Key]
        [StringLength(50)]
        public string Id { get; set; }
        [Required]
        [StringLength(100)]
        public string ItemName { get; set; }
        [Required]
        [StringLength(50)]
        public string FK_ItemType { get; set; }
        [StringLength(50)]
        public string FK_UnitId { get; set; }
        [Required]
        [StringLength(450)]
        public string FK_CreateObject { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCreate { get; set; }
        [StringLength(50)]
        public string FK_ModifyObject { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateModify { get; set; }
        public bool IsDelete { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        [Required]
        [StringLength(50)]
        public string TableCode { get; set; }
        [Column(TypeName = "decimal(10, 0)")]
        public decimal CurrentValue { get; set; }

        [ForeignKey(nameof(FK_ItemType))]
        [InverseProperty(nameof(ItemType.InventoryItem))]
        public virtual ItemType FK_ItemTypeNavigation { get; set; }
        [InverseProperty(nameof(ItemContainItem.FK_ChildItemNavigation))]
        public virtual ICollection<ItemContainItem> ItemContainItemFK_ChildItemNavigation { get; set; }
        [InverseProperty(nameof(ItemContainItem.FK_ParrentItemNavigation))]
        public virtual ICollection<ItemContainItem> ItemContainItemFK_ParrentItemNavigation { get; set; }
    }
}

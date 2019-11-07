using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo_Tranning_WPF.Models
{
    public partial class ItemType
    {
        public ItemType()
        {
            InventoryItem = new HashSet<InventoryItem>();
        }

        [Key]
        [StringLength(50)]
        public string Id { get; set; }
        [Required]
        [StringLength(100)]
        public string TypeName { get; set; }

        [InverseProperty("FK_ItemTypeNavigation")]
        public virtual ICollection<InventoryItem> InventoryItem { get; set; }
    }
}

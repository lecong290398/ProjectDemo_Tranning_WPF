using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo_Tranning_WPF.Models
{
    public partial class FileAttachment
    {
        [Key]
        [StringLength(50)]
        public string AttachmentID { get; set; }
        [Required]
        [StringLength(50)]
        public string Fk_Ref { get; set; }
        [Required]
        [StringLength(50)]
        public string FileName { get; set; }
        public int? FileSize { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Required]
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [StringLength(50)]
        public string ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
    }
}

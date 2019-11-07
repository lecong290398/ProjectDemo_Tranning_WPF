using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo_Tranning_WPF.Models
{
    public partial class Plan
    {
        public Plan()
        {
            DetailPlan = new HashSet<DetailPlan>();
            InOutWard = new HashSet<InOutWard>();
        }

        [Key]
        [StringLength(50)]
        public string Id { get; set; }
        [Required]
        [StringLength(50)]
        public string PlanNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PlanDate { get; set; }
        public int Status { get; set; }
        public int PlanType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCreate { get; set; }
        [Required]
        [StringLength(450)]
        public string FK_CreateObject { get; set; }
        [StringLength(50)]
        public string FK_ApproveObject { get; set; }
        [StringLength(50)]
        public string FK_StockObject { get; set; }
        [StringLength(10)]
        public string FK_ModifyObject { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateModify { get; set; }
        public string Description { get; set; }

        [InverseProperty("FK_PlanNavigation")]
        public virtual ICollection<DetailPlan> DetailPlan { get; set; }
        [InverseProperty("FK_Plan")]
        public virtual ICollection<InOutWard> InOutWard { get; set; }
    }
}

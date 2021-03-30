using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("CfgPrevision")]
    public partial class CfgPrevision
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public int? Quantity { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? StkHierarchyId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AchievementAmount { get; set; }
        public int? TurnoverQuantity { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TurnoverAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Turnover { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }

        [ForeignKey(nameof(StkHierarchyId))]
        [InverseProperty(nameof(CfgTranche.CfgPrevisions))]
        public virtual CfgTranche StkHierarchy { get; set; }
    }
}

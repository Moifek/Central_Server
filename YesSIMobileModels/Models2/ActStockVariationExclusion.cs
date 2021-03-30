using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ActStockVariationExclusion")]
    public partial class ActStockVariationExclusion
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? CfgProjectId { get; set; }
        public Guid? CfgTrancheId { get; set; }
        public Guid? StlCategoryId { get; set; }
        public bool? IsBiggerOrEqual { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExclusionDate { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("ActStockVariationExclusions")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgProjectId))]
        [InverseProperty("ActStockVariationExclusions")]
        public virtual CfgProject CfgProject { get; set; }
        [ForeignKey(nameof(CfgTrancheId))]
        [InverseProperty("ActStockVariationExclusions")]
        public virtual CfgTranche CfgTranche { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("ActStockVariationExclusions")]
        public virtual StlCategory StlCategory { get; set; }
    }
}

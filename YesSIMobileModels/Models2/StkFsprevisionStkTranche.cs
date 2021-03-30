using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkFSPrevisionStkTranche")]
    public partial class StkFsprevisionStkTranche
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Ratio { get; set; }
        public Guid? FeasibilityStudyId { get; set; }
        public Guid? StlCategoryId { get; set; }
        public Guid? StkTrancheId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column("AmountHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        public bool? Undivided { get; set; }

        [ForeignKey(nameof(StkTrancheId))]
        [InverseProperty(nameof(StkFeasibilityStudyCfgTranche.StkFsprevisionStkTranches))]
        public virtual StkFeasibilityStudyCfgTranche StkTranche { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("StkFsprevisionStkTranches")]
        public virtual StlCategory StlCategory { get; set; }
    }
}

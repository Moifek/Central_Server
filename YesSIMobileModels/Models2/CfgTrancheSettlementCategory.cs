using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("CfgTrancheSettlementCategory")]
    public partial class CfgTrancheSettlementCategory
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        public Guid? ComSettlementCategoryId { get; set; }
        public Guid? CfgtrancheId { get; set; }
        [Column("AmountHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [Column("AmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? AmountTtc { get; set; }
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
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PercentOf { get; set; }

        [ForeignKey(nameof(CfgtrancheId))]
        [InverseProperty(nameof(CfgTranche.CfgTrancheSettlementCategories))]
        public virtual CfgTranche Cfgtranche { get; set; }
        [ForeignKey(nameof(ComSettlementCategoryId))]
        [InverseProperty("CfgTrancheSettlementCategories")]
        public virtual ComSettlementCategory ComSettlementCategory { get; set; }
    }
}

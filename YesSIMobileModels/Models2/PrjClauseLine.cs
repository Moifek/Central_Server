using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjClauseLine")]
    public partial class PrjClauseLine
    {
        [Key]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(255)]
        public string Unity { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Quantity { get; set; }
        [Column("UnitPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [Column("UnitPriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceTtc { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? PrjClauseId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? StlCategoryId { get; set; }
        public Guid? PrjMarketLineId { get; set; }
        [Column("FODECRatio", TypeName = "decimal(26, 16)")]
        public decimal? Fodecratio { get; set; }
        public Guid? BuyConsultationLineId { get; set; }

        [ForeignKey(nameof(PrjClauseId))]
        [InverseProperty("PrjClauseLines")]
        public virtual PrjClause PrjClause { get; set; }
        [ForeignKey(nameof(PrjMarketLineId))]
        [InverseProperty("PrjClauseLines")]
        public virtual PrjMarketLine PrjMarketLine { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("PrjClauseLines")]
        public virtual StlCategory StlCategory { get; set; }
    }
}

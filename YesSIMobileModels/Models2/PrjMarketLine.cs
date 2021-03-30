using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketLine")]
    [Index(nameof(PrjMarketId), Name = "_dta_index_PrjMarketLine_10_100195407__K10_7_19_20_30")]
    [Index(nameof(PrjMarketId), nameof(Pkey), Name = "_dta_index_PrjMarketLine_10_100195407__K10_K1_7_19_20_30")]
    public partial class PrjMarketLine
    {
        public PrjMarketLine()
        {
            PrjClauseLines = new HashSet<PrjClauseLine>();
            PrjMarketViewLines = new HashSet<PrjMarketViewLine>();
            PrjWorkingOutLineExtras = new HashSet<PrjWorkingOutLineExtra>();
            PrjWorkingOutLines = new HashSet<PrjWorkingOutLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(2000)]
        public string Description { get; set; }
        [Column("EstimatedUnitPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? EstimatedUnitPriceHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [Column("EstimatedUnitPriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? EstimatedUnitPriceTtc { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? PrjMarketId { get; set; }
        public int? Sorting { get; set; }
        [StringLength(50)]
        public string Unity { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Quantity { get; set; }
        [Column("UnitPriceHT", TypeName = "decimal(26, 16)")]
        public decimal? UnitPriceHt { get; set; }
        [Column("UnitPriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceTtc { get; set; }
        public Guid? BuyItemId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WeightingRatio { get; set; }
        public Guid? PrjMarketLineGroupingId { get; set; }
        public bool? IsStock { get; set; }
        public Guid? Groupping1Id { get; set; }
        public Guid? Groupping2Id { get; set; }
        public Guid? Groupping3Id { get; set; }
        public Guid? StlCategoryId { get; set; }
        [Column("FODECRatio", TypeName = "decimal(26, 16)")]
        public decimal? Fodecratio { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? BuyConsultationLineId { get; set; }

        [ForeignKey(nameof(BuyItemId))]
        [InverseProperty("PrjMarketLines")]
        public virtual BuyItem BuyItem { get; set; }
        [ForeignKey(nameof(PrjMarketId))]
        [InverseProperty("PrjMarketLines")]
        public virtual PrjMarket PrjMarket { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("PrjMarketLines")]
        public virtual StlCategory StlCategory { get; set; }
        [InverseProperty(nameof(PrjClauseLine.PrjMarketLine))]
        public virtual ICollection<PrjClauseLine> PrjClauseLines { get; set; }
        [InverseProperty(nameof(PrjMarketViewLine.PrjMarketLine))]
        public virtual ICollection<PrjMarketViewLine> PrjMarketViewLines { get; set; }
        [InverseProperty(nameof(PrjWorkingOutLineExtra.PrjMarketLine))]
        public virtual ICollection<PrjWorkingOutLineExtra> PrjWorkingOutLineExtras { get; set; }
        [InverseProperty(nameof(PrjWorkingOutLine.PrjMarketLine))]
        public virtual ICollection<PrjWorkingOutLine> PrjWorkingOutLines { get; set; }
    }
}

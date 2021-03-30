using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjWorkingOutLine")]
    [Index(nameof(PrjWorkingOutId), nameof(PrjMarketLineId), Name = "_dta_index_PrjWorkingOutLine_10_1021246693__K17_K18_8_10_11_21")]
    [Index(nameof(PrjWorkingOutId), nameof(PrjMarketLineId), Name = "_dta_index_PrjWorkingOutLine_10_1021246693__K17_K18_8_10_21")]
    [Index(nameof(PrjMarketLineId), nameof(PrjWorkingOutId), Name = "_dta_index_PrjWorkingOutLine_10_1021246693__K18_K17_8_10_11_21")]
    public partial class PrjWorkingOutLine
    {
        public PrjWorkingOutLine()
        {
            PrjWorkingOutLineSubLines = new HashSet<PrjWorkingOutLineSubLine>();
        }

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
        public decimal? QuantityOrigin { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Coefficient { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? QuantityOld { get; set; }
        [Column("UnitPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [Column("UnitPriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceTtc { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? PrjWorkingOutId { get; set; }
        public Guid? PrjMarketLineId { get; set; }
        public Guid? BuyItemId { get; set; }
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
        [InverseProperty("PrjWorkingOutLines")]
        public virtual BuyItem BuyItem { get; set; }
        [ForeignKey(nameof(PrjMarketLineId))]
        [InverseProperty("PrjWorkingOutLines")]
        public virtual PrjMarketLine PrjMarketLine { get; set; }
        [ForeignKey(nameof(PrjWorkingOutId))]
        [InverseProperty("PrjWorkingOutLines")]
        public virtual PrjWorkingOut PrjWorkingOut { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("PrjWorkingOutLines")]
        public virtual StlCategory StlCategory { get; set; }
        [InverseProperty(nameof(PrjWorkingOutLineSubLine.PrjWorkingOutLine))]
        public virtual ICollection<PrjWorkingOutLineSubLine> PrjWorkingOutLineSubLines { get; set; }
    }
}

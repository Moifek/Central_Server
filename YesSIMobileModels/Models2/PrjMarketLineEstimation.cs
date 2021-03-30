using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketLineEstimation")]
    [Index(nameof(PrjMarketId), Name = "_dta_index_PrjMarketLineEstimation_10_2095346529__K8")]
    [Index(nameof(PrjMarketId), Name = "_dta_index_PrjMarketLineEstimation_10_2095346529__K8_4_5_11_22")]
    public partial class PrjMarketLineEstimation
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(2000)]
        public string Description { get; set; }
        [Column("UnitPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [Column("UnitPriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceTtc { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? PrjMarketId { get; set; }
        public int? Sorting { get; set; }
        [StringLength(50)]
        public string Unity { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Quantity { get; set; }
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
        [InverseProperty("PrjMarketLineEstimations")]
        public virtual BuyItem BuyItem { get; set; }
        [ForeignKey(nameof(PrjMarketId))]
        [InverseProperty("PrjMarketLineEstimations")]
        public virtual PrjMarket PrjMarket { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("PrjMarketLineEstimations")]
        public virtual StlCategory StlCategory { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class PrjWorkingOutLineView
    {
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
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? QuantityOld { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? QuantityAccumulated { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Quantity { get; set; }
        [Column("UnitPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceHt { get; set; }
        [Column("FODECRatio", TypeName = "decimal(26, 16)")]
        public decimal? Fodecratio { get; set; }
        [Column("UnitPriceHTNet", TypeName = "decimal(38, 6)")]
        public decimal? UnitPriceHtnet { get; set; }
        [Column("TotalHTOld", TypeName = "decimal(38, 6)")]
        public decimal? TotalHtold { get; set; }
        [Column("TotalHT", TypeName = "decimal(38, 6)")]
        public decimal? TotalHt { get; set; }
        [Column("CumulHT", TypeName = "decimal(38, 6)")]
        public decimal? CumulHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [Column("TotalVAT", TypeName = "decimal(38, 6)")]
        public decimal? TotalVat { get; set; }
        [Column("UnitPriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceTtc { get; set; }
        [Column("TotalTTCOld", TypeName = "decimal(38, 6)")]
        public decimal? TotalTtcold { get; set; }
        [Column("TotalTTC", TypeName = "decimal(38, 6)")]
        public decimal? TotalTtc { get; set; }
        [Column("CumulTTC", TypeName = "decimal(38, 6)")]
        public decimal? CumulTtc { get; set; }
        [Column("BaseTotalHTOld", TypeName = "decimal(38, 6)")]
        public decimal? BaseTotalHtold { get; set; }
        [Column("BaseTotalHT", TypeName = "decimal(38, 6)")]
        public decimal? BaseTotalHt { get; set; }
        [Column("CumulOverHTOld", TypeName = "decimal(38, 6)")]
        public decimal? CumulOverHtold { get; set; }
        [Column("CumulOverHT", TypeName = "decimal(38, 6)")]
        public decimal? CumulOverHt { get; set; }
        [Column("OverHT", TypeName = "decimal(38, 6)")]
        public decimal? OverHt { get; set; }
        [Column("CumulOverTTCOld", TypeName = "decimal(38, 6)")]
        public decimal? CumulOverTtcold { get; set; }
        [Column("CumulOverTTC", TypeName = "decimal(38, 6)")]
        public decimal? CumulOverTtc { get; set; }
        [Column("OverTTC", TypeName = "decimal(38, 6)")]
        public decimal? OverTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? Achievement { get; set; }
        public Guid? PrjMarketLineId { get; set; }
        [StringLength(255)]
        public string PrjMarketLineCode { get; set; }
        [StringLength(2000)]
        public string PrjMarketLineDescription { get; set; }
        public int? PrjMarketLineSorting { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal QuantityTotal { get; set; }
        [Column("PrjMarketLineBaseTotalHT", TypeName = "decimal(38, 7)")]
        public decimal? PrjMarketLineBaseTotalHt { get; set; }
        [Column("PrjMarketLineTotalHT", TypeName = "decimal(38, 6)")]
        public decimal? PrjMarketLineTotalHt { get; set; }
        [Column("PrjMarketLineTotalTTC", TypeName = "decimal(38, 6)")]
        public decimal? PrjMarketLineTotalTtc { get; set; }
        public Guid? PrjWorkingOutId { get; set; }
        [StringLength(255)]
        public string PrjWorkingOutCode { get; set; }
        [StringLength(255)]
        public string PrjWorkingOutDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PrjWorkingOutDocDate { get; set; }
        public int? PrjWorkingOutSorting { get; set; }
        public Guid? PrjMarketId { get; set; }
        [StringLength(255)]
        public string PrjMarketCode { get; set; }
        [StringLength(255)]
        public string PrjMarketDescription { get; set; }
        public Guid? BuyDocumentId { get; set; }
        public Guid? StlCategoryId { get; set; }
        [StringLength(255)]
        public string StlCategoryCode { get; set; }
        [StringLength(255)]
        public string StlCategoryDescription { get; set; }
        public Guid? ParentId { get; set; }
        [StringLength(255)]
        public string ParentCode { get; set; }
        [StringLength(255)]
        public string ParentDescription { get; set; }
        public int? ParentSorting { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
    }
}

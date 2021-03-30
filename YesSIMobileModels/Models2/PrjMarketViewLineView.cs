using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class PrjMarketViewLineView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid PrjMarketViewId { get; set; }
        public Guid PrjMarketLineId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Percentage { get; set; }
        [StringLength(255)]
        public string PrjMarketLineCode { get; set; }
        [StringLength(500)]
        public string PrjMarketLineDescription { get; set; }
        public int? PrjMarketLineSorting { get; set; }
        [StringLength(50)]
        public string PrjMarketLineUnity { get; set; }
        [Column("PrjMarketLineFODECRatio", TypeName = "decimal(26, 16)")]
        public decimal? PrjMarketLineFodecratio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PrjMarketLineVatRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PrjMarketLineQuantity { get; set; }
        [Column("PrjMarketLineUnitPriceHT", TypeName = "decimal(26, 16)")]
        public decimal? PrjMarketLineUnitPriceHt { get; set; }
        [Column("PrjMarketLineAmountHT", TypeName = "decimal(38, 16)")]
        public decimal? PrjMarketLineAmountHt { get; set; }
        [Column("PrjMarketLineUnitPriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? PrjMarketLineUnitPriceTtc { get; set; }
        public Guid? PrjMarketLineBuyItemId { get; set; }
        public Guid? PrjMarketLineStlCategoryId { get; set; }
        [StringLength(1000)]
        public string PrjMarketLineNotes { get; set; }
    }
}

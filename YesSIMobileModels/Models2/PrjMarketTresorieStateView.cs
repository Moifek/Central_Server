using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class PrjMarketTresorieStateView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjMarketTypeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjMarketTypeDescription { get; set; }
        public Guid? StlCategoryId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlCategoryCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlCategoryDescription { get; set; }
        [Column("EstimatedPriceTTCManual", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedPriceTtcmanual { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? EstimatedAmountToPayManual { get; set; }
        [Column("OfferedPriceTTC", TypeName = "decimal(38, 6)")]
        public decimal? OfferedPriceTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OfferedAmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? DueAmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? DueAmountToPayEstimatedAmountToPayEcart { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? EstimationAmountRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? InvoiceTotalRetainedLineAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ExtraAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ClausesAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ExtraAmountRatio { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? RefundsAmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? WarrantyAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? WarrantyAmountSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? WarrantyAmountRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutRetainedLineAmount { get; set; }
        public Guid? PrjProjectId { get; set; }
        [StringLength(255)]
        public string PrjProjectCode { get; set; }
        [StringLength(255)]
        public string PrjProjectDescription { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTrancheCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTrancheDescription { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal CoveredFloorArea { get; set; }
        [Column("EstimatedPriceTTCManualByUnitCoveredFloorArea", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedPriceTtcmanualByUnitCoveredFloorArea { get; set; }
        [Column("OfferedPriceTTCByUnitCoveredFloorArea", TypeName = "decimal(38, 6)")]
        public decimal? OfferedPriceTtcbyUnitCoveredFloorArea { get; set; }
    }
}

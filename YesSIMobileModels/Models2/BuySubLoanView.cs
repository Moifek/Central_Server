using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class BuySubLoanView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? AmortizationDeferredDelay { get; set; }
        public int? TotalDeferredDelay { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AnnualRate { get; set; }
        public int? GracePeriod { get; set; }
        public bool? IsActoriel { get; set; }
        public bool? IsMensualRate { get; set; }
        public int? MonthsCount { get; set; }
        public int? MonthsStep { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PaymentDate { get; set; }
        public int? ScheduleCount { get; set; }
        public Guid? BuyLoanId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BuyLoanDocDate { get; set; }
        [StringLength(255)]
        public string BuyLoanCode { get; set; }
        [StringLength(255)]
        public string BuyLoanDescription { get; set; }
        [StringLength(1000)]
        public string BuyLoanNotes { get; set; }
        public Guid? CfgTierId { get; set; }
        [StringLength(255)]
        public string CfgTierCode { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? PrjProjectId { get; set; }
        [StringLength(255)]
        public string PrjProjectCode { get; set; }
        [StringLength(255)]
        public string PrjProjectDescription { get; set; }
        public Guid? StkItemId { get; set; }
        [StringLength(255)]
        public string StkItemCode { get; set; }
        [StringLength(255)]
        public string StkItemDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? BuyLoanTypeId { get; set; }
        [StringLength(255)]
        public string BuyLoanTypeCode { get; set; }
        [StringLength(255)]
        public string BuyLoanTypeDescription { get; set; }
        public Guid? BaseStlCategoryId { get; set; }
        public Guid? InterestStlCategoryId { get; set; }
        public Guid? CommissionStlCategoryId { get; set; }
        public bool? IsSupplierFinancing { get; set; }
        public bool? IsLeasing { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountDebloced { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountDeblocedRest { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseVatRatio { get; set; }
        [Column("EstimatedAmountBaseHT", TypeName = "decimal(38, 6)")]
        public decimal EstimatedAmountBaseHt { get; set; }
        [Column("EstimatedAmountBaseVAT", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedAmountBaseVat { get; set; }
        [Column("EstimatedAmountBaseTTC", TypeName = "decimal(38, 6)")]
        public decimal EstimatedAmountBaseTtc { get; set; }
        [Column("RealAmountBaseHT", TypeName = "decimal(38, 6)")]
        public decimal RealAmountBaseHt { get; set; }
        [Column("ReaAmountBaseVAT", TypeName = "decimal(38, 6)")]
        public decimal? ReaAmountBaseVat { get; set; }
        [Column("RealAmountBaseTTC", TypeName = "decimal(38, 6)")]
        public decimal RealAmountBaseTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal EstimatedAmountBase { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? InterestRate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? InterestVatRatio { get; set; }
        [Column("EstimatedInterestHT", TypeName = "decimal(38, 6)")]
        public decimal EstimatedInterestHt { get; set; }
        [Column("EstimatedInterestVAT", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedInterestVat { get; set; }
        [Column("EstimatedInterestTTC", TypeName = "decimal(38, 6)")]
        public decimal EstimatedInterestTtc { get; set; }
        [Column("RealInterestHT", TypeName = "decimal(38, 6)")]
        public decimal RealInterestHt { get; set; }
        [Column("RealInterestVAT", TypeName = "decimal(38, 6)")]
        public decimal? RealInterestVat { get; set; }
        [Column("RealInterestTTC", TypeName = "decimal(38, 6)")]
        public decimal RealInterestTtc { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CommisionVatRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DefaultCommisionAmount { get; set; }
        [Column("EstimatedCommissionHT", TypeName = "decimal(38, 6)")]
        public decimal EstimatedCommissionHt { get; set; }
        [Column("EstimatedCommisionVAT", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedCommisionVat { get; set; }
        [Column("EstimatedCommissionTTC", TypeName = "decimal(38, 6)")]
        public decimal EstimatedCommissionTtc { get; set; }
        [Column("RealCommissionHT", TypeName = "decimal(38, 6)")]
        public decimal RealCommissionHt { get; set; }
        [Column("RealCommisionVAT", TypeName = "decimal(38, 6)")]
        public decimal? RealCommisionVat { get; set; }
        [Column("RealCommissionTTC", TypeName = "decimal(38, 6)")]
        public decimal RealCommissionTtc { get; set; }
        [Column("EstimatedAmountHT", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedAmountHt { get; set; }
        [Column("EstimatedAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedAmountVat { get; set; }
        [Column("EstimatedAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedAmountTtc { get; set; }
        [Column("RealAmountHT", TypeName = "decimal(38, 6)")]
        public decimal? RealAmountHt { get; set; }
        [Column("RealAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? RealAmountVat { get; set; }
        [Column("RealAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal? RealAmountTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal AmountToPaySettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountToPayRest { get; set; }
    }
}

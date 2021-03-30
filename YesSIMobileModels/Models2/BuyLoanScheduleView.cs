using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class BuyLoanScheduleView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PrevisionPaymentDate { get; set; }
        public int? PrevisionPaymentYear { get; set; }
        public int? PrevisionPaymentMonth { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RealPaymentDate { get; set; }
        public int? RealPaymentYear { get; set; }
        public int? RealPaymentMonth { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PaymentDate { get; set; }
        public int? PaymentYear { get; set; }
        public int? PaymentMonth { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal EstimatedAmountBaseVatRatio { get; set; }
        [Column("EstimatedAmountBaseHT", TypeName = "decimal(26, 6)")]
        public decimal EstimatedAmountBaseHt { get; set; }
        [Column("EstimatedAmountBaseVAT", TypeName = "decimal(27, 6)")]
        public decimal? EstimatedAmountBaseVat { get; set; }
        [Column("EstimatedAmountBaseTTC", TypeName = "decimal(26, 6)")]
        public decimal EstimatedAmountBaseTtc { get; set; }
        [Column("RealAmountBaseHT", TypeName = "decimal(38, 6)")]
        public decimal RealAmountBaseHt { get; set; }
        [Column("RealAmountBaseVAT", TypeName = "decimal(38, 6)")]
        public decimal? RealAmountBaseVat { get; set; }
        [Column("RealAmountBaseTTC", TypeName = "decimal(38, 6)")]
        public decimal RealAmountBaseTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal RealAmountBaseToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal RealAmountBaseSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? RealAmountBaseRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal BaseAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal BaseSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? BaseRest { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EstimatedInterestRate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EstimatedInterestVatRatio { get; set; }
        [Column("EstimatedInterestHT", TypeName = "decimal(26, 6)")]
        public decimal? EstimatedInterestHt { get; set; }
        [Column("EstimatedInterestVAT", TypeName = "decimal(27, 6)")]
        public decimal? EstimatedInterestVat { get; set; }
        [Column("EstimatedInterestTTC", TypeName = "decimal(26, 6)")]
        public decimal? EstimatedInterestTtc { get; set; }
        [Column("RealInterestHT", TypeName = "decimal(38, 6)")]
        public decimal RealInterestHt { get; set; }
        [Column("RealInterestVAT", TypeName = "decimal(38, 6)")]
        public decimal? RealInterestVat { get; set; }
        [Column("RealInterestTTC", TypeName = "decimal(38, 6)")]
        public decimal RealInterestTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal RealInterestToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal RealInterestSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? RealInterestRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? InterestAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal InterestSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? InterestRest { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EstimatedCommissionVatRatio { get; set; }
        [Column("EstimatedCommissionHT", TypeName = "decimal(26, 6)")]
        public decimal? EstimatedCommissionHt { get; set; }
        [Column("EstimatedCommisionVAT", TypeName = "decimal(27, 6)")]
        public decimal? EstimatedCommisionVat { get; set; }
        [Column("EstimatedCommissionTTC", TypeName = "decimal(26, 6)")]
        public decimal? EstimatedCommissionTtc { get; set; }
        [Column("RealCommissionHT", TypeName = "decimal(38, 6)")]
        public decimal RealCommissionHt { get; set; }
        [Column("RealCommisionVAT", TypeName = "decimal(38, 6)")]
        public decimal? RealCommisionVat { get; set; }
        [Column("RealCommissionTTC", TypeName = "decimal(38, 6)")]
        public decimal RealCommissionTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal RealCommissionToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal RealCommissionSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? RealCommissionRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CommissionAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal CommissionSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CommissionRest { get; set; }
        [Column("EstimatedAmountToPayHT", TypeName = "decimal(28, 6)")]
        public decimal? EstimatedAmountToPayHt { get; set; }
        [Column("EstimatedAmountToPayVAT", TypeName = "decimal(29, 6)")]
        public decimal? EstimatedAmountToPayVat { get; set; }
        [Column("EstimatedAmountToPayTTC", TypeName = "decimal(28, 6)")]
        public decimal? EstimatedAmountToPayTtc { get; set; }
        [Column("RealAmountToPayHT", TypeName = "decimal(26, 6)")]
        public decimal RealAmountToPayHt { get; set; }
        [Column("RealAmountToPayVAT", TypeName = "decimal(26, 6)")]
        public decimal RealAmountToPayVat { get; set; }
        [Column("RealAmountToPayTTC", TypeName = "decimal(26, 6)")]
        public decimal RealAmountToPayTtc { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal AmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal AmountToPaySettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountToPayRest { get; set; }
        [Column(TypeName = "decimal(28, 6)")]
        public decimal? TotalAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal TotalSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalRest { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? BuyLoanId { get; set; }
        [StringLength(255)]
        public string BuyLoanCode { get; set; }
        [StringLength(255)]
        public string BuyLoanDescription { get; set; }
        public bool? BuyLoanIsClosed { get; set; }
        public Guid? PrjProjectId { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjProjectCode { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjProjectDescription { get; set; }
        public Guid? StkItemId { get; set; }
        [Required]
        [StringLength(255)]
        public string StkItemCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StkItemDescription { get; set; }
        public Guid? BuySubLoanId { get; set; }
        [StringLength(1000)]
        public string BuySubLoanNotes { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BuySubLoanPaymentDate { get; set; }
        public Guid? CfgTierId { get; set; }
        [StringLength(255)]
        public string CfgTierCode { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
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
        public Guid? BuyDocumentId { get; set; }
        public int? BuyDocumentCount { get; set; }
        [Required]
        [StringLength(255)]
        public string BuyDocumentCode { get; set; }
        [Required]
        [StringLength(255)]
        public string BuyDocumentDescription { get; set; }
    }
}

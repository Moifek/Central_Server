using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class PrjMarketReport
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? PrjProjectId { get; set; }
        [StringLength(255)]
        public string PrjProjectDescription { get; set; }
        public Guid? StlCategoryId { get; set; }
        [StringLength(255)]
        public string StlCategoryDescription { get; set; }
        public Guid? PrjMarketTypeId { get; set; }
        [StringLength(255)]
        public string PrjMarketTypeDescription { get; set; }
        public Guid? PrjMarketStatusId { get; set; }
        [StringLength(255)]
        public string PrjMarketStatusDescription { get; set; }
        public Guid? StlSettlementTypeId { get; set; }
        [StringLength(255)]
        public string StlSettlementTypeDescription { get; set; }
        public int? PaymentDelay { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal Achievement { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        public int? Delay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        public Guid? CfgSupplierId { get; set; }
        [StringLength(255)]
        public string CfgSupplierDescription { get; set; }
        public bool? IsMultiSupplier { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DefaultVat { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvanceRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WarrantyRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProportionRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StockPileRatio { get; set; }
        [Column("InsuranceDECRatio", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceDecratio { get; set; }
        [Column("InsuranceDECAmount", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceDecamount { get; set; }
        [Column("InsuranceTRCRatio", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceTrcratio { get; set; }
        [Column("InsuranceTRCAmount", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceTrcamount { get; set; }
        [Column("EstimatedPriceHTManual", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedPriceHtmanual { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? EstimatedVatAmountManual { get; set; }
        [Column("EstimatedPriceTTCManual", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedPriceTtcmanual { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? EstimatedAdvanceAmountManual { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? EstimatedWarrantyAmountManual { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? EstimatedProportionAmountManual { get; set; }
        [Column("EstimatedInsuranceDECAmountManual", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedInsuranceDecamountManual { get; set; }
        [Column("EstimatedInsuranceTRCAmountManual", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedInsuranceTrcamountManual { get; set; }
        [Column("EstimatedPriceHT", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedPriceHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? EstimatedVatAmount { get; set; }
        [Column("EstimatedPriceTTC", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedPriceTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? EstimatedAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? EstimatedWarrantyAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? EstimatedProportionAmount { get; set; }
        [Column("EstimatedInsuranceDECAmount", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedInsuranceDecamount { get; set; }
        [Column("EstimatedInsuranceTRCAmount", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedInsuranceTrcamount { get; set; }
        [Column("OfferedPriceHT", TypeName = "decimal(38, 6)")]
        public decimal? OfferedPriceHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OfferedVatAmount { get; set; }
        [Column("OfferedPriceTTC", TypeName = "decimal(38, 6)")]
        public decimal? OfferedPriceTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OfferedAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OfferedWarrantyAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OfferedProportionAmount { get; set; }
        [Column("OfferedInsuranceDECAmount", TypeName = "decimal(38, 6)")]
        public decimal? OfferedInsuranceDecamount { get; set; }
        [Column("OfferedInsuranceTRCAmount", TypeName = "decimal(38, 6)")]
        public decimal? OfferedInsuranceTrcamount { get; set; }
        [Column("CountedPriceHT", TypeName = "decimal(38, 6)")]
        public decimal CountedPriceHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal CountedVatAmount { get; set; }
        [Column("CountedPriceTTC", TypeName = "decimal(38, 6)")]
        public decimal CountedPriceTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal CountedAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal CountedWarrantyAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal CountedProportionAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal CountedProrataRefundAmount { get; set; }
        [Column("CountedInsuranceDECAmount", TypeName = "decimal(38, 6)")]
        public decimal CountedInsuranceDecamount { get; set; }
        [Column("CountedInsuranceTRCAmount", TypeName = "decimal(38, 6)")]
        public decimal CountedInsuranceTrcamount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal CountedForfetairAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal CountedExtraAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal CountedStockAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal CountedWorkingOutAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal CountedAmountToPay { get; set; }
        [Column("InvoicesTotalHT", TypeName = "decimal(38, 6)")]
        public decimal InvoicesTotalHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal InvoicesTotalVatAmount { get; set; }
        [Column("InvoicesTotalTTC", TypeName = "decimal(38, 6)")]
        public decimal InvoicesTotalTtc { get; set; }
        [Column("EstimatedRNRManual", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedRnrmanual { get; set; }
        [Column("EstimatedRREManual", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedRremanual { get; set; }
        [Column("EstimatedRNR", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedRnr { get; set; }
        [Column("EstimatedRRE", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedRre { get; set; }
        [Column("OfferedRNR", TypeName = "decimal(38, 6)")]
        public decimal? OfferedRnr { get; set; }
        [Column("OfferedRRE", TypeName = "decimal(38, 6)")]
        public decimal? OfferedRre { get; set; }
        [Column("CountedRNR", TypeName = "decimal(38, 6)")]
        public decimal? CountedRnr { get; set; }
        [Column("CountedRRE", TypeName = "decimal(38, 6)")]
        public decimal? CountedRre { get; set; }
        [Column("CostHT", TypeName = "decimal(38, 6)")]
        public decimal CostHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal CostVatAmount { get; set; }
        [Column("CostTTC", TypeName = "decimal(38, 6)")]
        public decimal CostTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? EstimatedTotRetManual { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? EstimatedTotRet { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OfferedTotRet { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CountedTotalRetain { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CountedTotalExtra { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? EstimatedNetToPayManual { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? EstimatedNetToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OfferedNetToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CountedNetToPay { get; set; }
    }
}

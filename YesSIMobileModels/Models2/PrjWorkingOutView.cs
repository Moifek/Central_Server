using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class PrjWorkingOutView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(255)]
        public string DocRef { get; set; }
        [StringLength(255)]
        public string SupplierDescription { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(1000)]
        public string ParentDocuments { get; set; }
        public int? LinesCount { get; set; }
        [Column("isTheLastWorkingOut")]
        public bool? IsTheLastWorkingOut { get; set; }
        public bool? FinalWorkingOut { get; set; }
        public Guid? CfgTierId { get; set; }
        public Guid? SupplierId { get; set; }
        [StringLength(255)]
        public string CfgTierCode { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? PrjMarketId { get; set; }
        [StringLength(255)]
        public string PrjMarketCode { get; set; }
        [StringLength(255)]
        public string PrjMarketDescription { get; set; }
        public bool? PrjMarketWithMarketView { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Vat { get; set; }
        public Guid? PrjProjectId { get; set; }
        [StringLength(255)]
        public string PrjProjectDescription { get; set; }
        public Guid? BuyDocumentId { get; set; }
        [StringLength(255)]
        public string BuyDocumentCode { get; set; }
        [Column("buyDocumentDescription")]
        [StringLength(255)]
        public string BuyDocumentDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        [Column("LastCumulHT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulHt { get; set; }
        [Column("LastCumulVAT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulVat { get; set; }
        [Column("LastCumulTTC", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulTtc { get; set; }
        [Column("AmountHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountHt { get; set; }
        [Column(TypeName = "decimal(27, 6)")]
        public decimal? AmountVat { get; set; }
        [Column("AmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? AmountTtc { get; set; }
        [Column("CumulHT", TypeName = "decimal(38, 6)")]
        public decimal? CumulHt { get; set; }
        [Column("CumulVAT", TypeName = "decimal(38, 6)")]
        public decimal? CumulVat { get; set; }
        [Column("CumulTTC", TypeName = "decimal(38, 6)")]
        public decimal? CumulTtc { get; set; }
        [Column("LastCumulLinesHT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulLinesHt { get; set; }
        [Column("LastCumulLinesVAT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulLinesVat { get; set; }
        [Column("LastCumulLinesTTC", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulLinesTtc { get; set; }
        [Column("LinesHT", TypeName = "decimal(38, 6)")]
        public decimal? LinesHt { get; set; }
        [Column("LinesVAT", TypeName = "decimal(38, 6)")]
        public decimal? LinesVat { get; set; }
        [Column("LinesTTC", TypeName = "decimal(38, 6)")]
        public decimal? LinesTtc { get; set; }
        [Column("CumulLinesHT", TypeName = "decimal(38, 6)")]
        public decimal? CumulLinesHt { get; set; }
        [Column("CumulLinesVAT", TypeName = "decimal(38, 6)")]
        public decimal? CumulLinesVat { get; set; }
        [Column("CumulLinesTTC", TypeName = "decimal(38, 6)")]
        public decimal? CumulLinesTtc { get; set; }
        [Column("LastCumulOverHT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulOverHt { get; set; }
        [Column("LastCumulOverVAT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulOverVat { get; set; }
        [Column("LastCumulOverTTC", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulOverTtc { get; set; }
        [Column("OverHT", TypeName = "decimal(38, 6)")]
        public decimal? OverHt { get; set; }
        [Column("OverVAT", TypeName = "decimal(38, 6)")]
        public decimal? OverVat { get; set; }
        [Column("OverTTC", TypeName = "decimal(38, 6)")]
        public decimal? OverTtc { get; set; }
        [Column("CumulOverHT", TypeName = "decimal(38, 6)")]
        public decimal? CumulOverHt { get; set; }
        [Column("CumulOverVAT", TypeName = "decimal(38, 6)")]
        public decimal? CumulOverVat { get; set; }
        [Column("CumulOverTTC", TypeName = "decimal(38, 6)")]
        public decimal? CumulOverTtc { get; set; }
        [Column("LastCumulExtraLineHT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulExtraLineHt { get; set; }
        [Column("LastCumulExtraLineVAT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulExtraLineVat { get; set; }
        [Column("LastCumulExtraLineTTC", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulExtraLineTtc { get; set; }
        [Column("ExtraLineHT", TypeName = "decimal(38, 6)")]
        public decimal? ExtraLineHt { get; set; }
        [Column("ExtraLineVAT", TypeName = "decimal(38, 6)")]
        public decimal? ExtraLineVat { get; set; }
        [Column("ExtraLineTTC", TypeName = "decimal(38, 6)")]
        public decimal? ExtraLineTtc { get; set; }
        [Column("CumulExtraLineHT", TypeName = "decimal(38, 6)")]
        public decimal? CumulExtraLineHt { get; set; }
        [Column("CumulExtraLineVAT", TypeName = "decimal(38, 6)")]
        public decimal? CumulExtraLineVat { get; set; }
        [Column("CumulExtraLineTTC", TypeName = "decimal(38, 6)")]
        public decimal? CumulExtraLineTtc { get; set; }
        [Column("TotalExtraLineHTAcumulated", TypeName = "decimal(38, 6)")]
        public decimal? TotalExtraLineHtacumulated { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalExtraLineVatAcumulated { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StockPileRatio { get; set; }
        [Column("StockAmountOldHT", TypeName = "decimal(26, 6)")]
        public decimal? StockAmountOldHt { get; set; }
        [Column("StockAmountOldVAT", TypeName = "decimal(27, 6)")]
        public decimal? StockAmountOldVat { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StockAmountOld { get; set; }
        [Column("StockAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? StockAmountHt { get; set; }
        [Column("StockAmountVAT", TypeName = "decimal(27, 6)")]
        public decimal? StockAmountVat { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StockAmount { get; set; }
        [Column("LastCumulStockAmountToPayHT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulStockAmountToPayHt { get; set; }
        [Column("LastCumulStockAmountToPayVAT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulStockAmountToPayVat { get; set; }
        [Column("LastCumulStockAmountToPayTTC", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulStockAmountToPayTtc { get; set; }
        [Column("StockAmountToPayHT", TypeName = "decimal(26, 6)")]
        public decimal? StockAmountToPayHt { get; set; }
        [Column("StockAmountToPayVAT", TypeName = "decimal(27, 6)")]
        public decimal? StockAmountToPayVat { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StockAmountToPay { get; set; }
        [Column("CumulStockAmountToPayHT", TypeName = "decimal(38, 6)")]
        public decimal? CumulStockAmountToPayHt { get; set; }
        [Column("CumulStockAmountToPayVAT", TypeName = "decimal(38, 6)")]
        public decimal? CumulStockAmountToPayVat { get; set; }
        [Column("CumulStockAmountToPayTTC", TypeName = "decimal(38, 6)")]
        public decimal? CumulStockAmountToPayTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalStockAmountOldAcumulated { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalStockAmountAcumulated { get; set; }
        [Column("LastStockLineHT", TypeName = "decimal(38, 6)")]
        public decimal? LastStockLineHt { get; set; }
        [Column("LastStockLineVAT", TypeName = "decimal(38, 6)")]
        public decimal? LastStockLineVat { get; set; }
        [Column("LastStockLineTTC", TypeName = "decimal(38, 6)")]
        public decimal? LastStockLineTtc { get; set; }
        [Column("StockLineHT", TypeName = "decimal(38, 6)")]
        public decimal? StockLineHt { get; set; }
        [Column("StockLineVAT", TypeName = "decimal(38, 6)")]
        public decimal? StockLineVat { get; set; }
        [Column("StockLineTTC", TypeName = "decimal(38, 6)")]
        public decimal? StockLineTtc { get; set; }
        [Column("StockRefendHT", TypeName = "decimal(26, 6)")]
        public decimal? StockRefendHt { get; set; }
        [Column("StockRefendVAT", TypeName = "decimal(27, 6)")]
        public decimal? StockRefendVat { get; set; }
        [Column("FluctuationsOldHT", TypeName = "decimal(26, 6)")]
        public decimal? FluctuationsOldHt { get; set; }
        [Column("FluctuationsOldVAT", TypeName = "decimal(27, 6)")]
        public decimal? FluctuationsOldVat { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FluctuationsOld { get; set; }
        [Column("FluctuationsHT", TypeName = "decimal(26, 6)")]
        public decimal? FluctuationsHt { get; set; }
        [Column("FluctuationsVAT", TypeName = "decimal(27, 6)")]
        public decimal? FluctuationsVat { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Fluctuations { get; set; }
        [Column("LastCumulFluctuationsToPayHT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulFluctuationsToPayHt { get; set; }
        [Column("LastCumulFluctuationsToPayVAT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulFluctuationsToPayVat { get; set; }
        [Column("LastCumulFluctuationsToPayTTC", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulFluctuationsToPayTtc { get; set; }
        [Column("FluctuationsToPayHT", TypeName = "decimal(26, 6)")]
        public decimal? FluctuationsToPayHt { get; set; }
        [Column("FluctuationsToPayVAT", TypeName = "decimal(27, 6)")]
        public decimal? FluctuationsToPayVat { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FluctuationsToPay { get; set; }
        [Column("CumulFluctuationsToPayHT", TypeName = "decimal(38, 6)")]
        public decimal? CumulFluctuationsToPayHt { get; set; }
        [Column("CumulFluctuationsToPayVAT", TypeName = "decimal(38, 6)")]
        public decimal? CumulFluctuationsToPayVat { get; set; }
        [Column("CumulFluctuationsToPayTTC", TypeName = "decimal(38, 6)")]
        public decimal? CumulFluctuationsToPayTtc { get; set; }
        [Column("LastCumulTotalHT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulTotalHt { get; set; }
        [Column("LastCumulTotalVAT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulTotalVat { get; set; }
        [Column("LastCumulTotalTTC", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulTotalTtc { get; set; }
        [Column("TotalHT", TypeName = "decimal(38, 6)")]
        public decimal? TotalHt { get; set; }
        [Column("TotalVAT", TypeName = "decimal(38, 6)")]
        public decimal? TotalVat { get; set; }
        [Column("TotalTTC", TypeName = "decimal(38, 6)")]
        public decimal? TotalTtc { get; set; }
        [Column("CumulTotalHT", TypeName = "decimal(38, 6)")]
        public decimal? CumulTotalHt { get; set; }
        [Column("CumulTotalVAT", TypeName = "decimal(38, 6)")]
        public decimal? CumulTotalVat { get; set; }
        [Column("CumulTotalTTC", TypeName = "decimal(38, 6)")]
        public decimal? CumulTotalTtc { get; set; }
        public bool? AdvanceBasedOnAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvanceRatio { get; set; }
        [Column("LastCumulAdvanceHT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulAdvanceHt { get; set; }
        [Column("LastCumulAdvanceVAT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulAdvanceVat { get; set; }
        [Column("LastCumulAdvanceTTC", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulAdvanceTtc { get; set; }
        [Column("AdvanceAmountHT", TypeName = "decimal(38, 12)")]
        public decimal? AdvanceAmountHt { get; set; }
        [Column("AdvanceAmountVAT", TypeName = "decimal(38, 12)")]
        public decimal? AdvanceAmountVat { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvanceAmount { get; set; }
        [Column("CumulAdvanceHT", TypeName = "decimal(38, 6)")]
        public decimal? CumulAdvanceHt { get; set; }
        [Column("CumulAdvanceVAT", TypeName = "decimal(38, 6)")]
        public decimal? CumulAdvanceVat { get; set; }
        [Column("CumulAdvanceTTC", TypeName = "decimal(38, 6)")]
        public decimal? CumulAdvanceTtc { get; set; }
        [Column("advanceRest", TypeName = "decimal(26, 6)")]
        public decimal? AdvanceRest { get; set; }
        [Column("TotalAdvanceAccumultedHT", TypeName = "decimal(38, 6)")]
        public decimal? TotalAdvanceAccumultedHt { get; set; }
        [Column("TotalAdvanceAccumultedVAT", TypeName = "decimal(38, 6)")]
        public decimal? TotalAdvanceAccumultedVat { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WorkingOutAdvanceAmountRestAtCreation { get; set; }
        [Column("LastCumulWorkingOutAdvanceTTC", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulWorkingOutAdvanceTtc { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WorkingOutAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CumulWorkingOutAdvanceAmount { get; set; }
        [Column("CumulWorkingOutAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal? CumulWorkingOutAmountTtc { get; set; }
        [Column("LastCumulWorkingOutAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulWorkingOutAmountTtc { get; set; }
        [Column("TotalWorkingOutAmountTTCAcumulated", TypeName = "decimal(38, 6)")]
        public decimal? TotalWorkingOutAmountTtcacumulated { get; set; }
        public bool? WarrantyBasedOnAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WarrantyRatio { get; set; }
        [Column("LastCumulWarrantyHT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulWarrantyHt { get; set; }
        [Column("LastCumulWarrantyVAT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulWarrantyVat { get; set; }
        [Column("LastCumulWarrantyTTC", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulWarrantyTtc { get; set; }
        [Column("WarrantyAmountHT", TypeName = "decimal(38, 12)")]
        public decimal? WarrantyAmountHt { get; set; }
        [Column("WarrantyAmountVAT", TypeName = "decimal(38, 12)")]
        public decimal? WarrantyAmountVat { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WarrantyAmount { get; set; }
        [Column("CumulWarrantyHT", TypeName = "decimal(38, 6)")]
        public decimal? CumulWarrantyHt { get; set; }
        [Column("CumulWarrantyVAT", TypeName = "decimal(38, 6)")]
        public decimal? CumulWarrantyVat { get; set; }
        [Column("CumulWarrantyTTC", TypeName = "decimal(38, 6)")]
        public decimal? CumulWarrantyTtc { get; set; }
        [Column("TotalWarrantyAccumultedHT", TypeName = "decimal(38, 6)")]
        public decimal? TotalWarrantyAccumultedHt { get; set; }
        [Column("TotalWarrantyAccumultedVAT", TypeName = "decimal(38, 6)")]
        public decimal? TotalWarrantyAccumultedVat { get; set; }
        public bool? ProrataBasedOnAmount { get; set; }
        [Column("proportionRatio", TypeName = "decimal(26, 6)")]
        public decimal? ProportionRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProportionAmount { get; set; }
        [Column("LastCumulProportionHT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulProportionHt { get; set; }
        [Column("LastCumulProportionVAT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulProportionVat { get; set; }
        [Column("LastCumulProportionTTC", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulProportionTtc { get; set; }
        [Column("ProportionAmountHT", TypeName = "decimal(38, 12)")]
        public decimal? ProportionAmountHt { get; set; }
        [Column("ProportionAmountVAT", TypeName = "decimal(38, 12)")]
        public decimal? ProportionAmountVat { get; set; }
        [Column("ProportionAmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? ProportionAmountTtc { get; set; }
        [Column("CumulProportionHT", TypeName = "decimal(38, 6)")]
        public decimal? CumulProportionHt { get; set; }
        [Column("CumulProportionVAT", TypeName = "decimal(38, 6)")]
        public decimal? CumulProportionVat { get; set; }
        [Column("CumulProportionTTC", TypeName = "decimal(38, 6)")]
        public decimal? CumulProportionTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalProportionAccumulted { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalProrataRefundAmountAcumulated { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? LastCumulProrataRefundAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProrataRefundAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CumulProrataRefundAmount { get; set; }
        [Column("DECBasedOnAmount")]
        public bool? DecbasedOnAmount { get; set; }
        [Column("insuranceDECRatio", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceDecratio { get; set; }
        [Column("insuranceDECRest", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceDecrest { get; set; }
        [Column("InsuranceDECAmountMax", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceDecamountMax { get; set; }
        [Column("InsuranceDECAmount", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceDecamount { get; set; }
        [Column("LastCumulInsuranceDECHT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulInsuranceDecht { get; set; }
        [Column("LastCumulInsuranceDECVAT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulInsuranceDecvat { get; set; }
        [Column("LastCumulInsuranceDECTTC", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulInsuranceDecttc { get; set; }
        [Column("InsuranceDECAmountHT", TypeName = "decimal(38, 12)")]
        public decimal? InsuranceDecamountHt { get; set; }
        [Column("InsuranceDECAmountVAT", TypeName = "decimal(38, 12)")]
        public decimal? InsuranceDecamountVat { get; set; }
        [Column("InsuranceDECAmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceDecamountTtc { get; set; }
        [Column("CumulInsuranceDECHT", TypeName = "decimal(38, 6)")]
        public decimal? CumulInsuranceDecht { get; set; }
        [Column("CumulInsuranceDECVAT", TypeName = "decimal(38, 6)")]
        public decimal? CumulInsuranceDecvat { get; set; }
        [Column("CumulInsuranceDECTTC", TypeName = "decimal(38, 6)")]
        public decimal? CumulInsuranceDecttc { get; set; }
        [Column("TotalInsuranceDECAccumulted", TypeName = "decimal(38, 6)")]
        public decimal? TotalInsuranceDecaccumulted { get; set; }
        [Column("TRCBasedOnAmount")]
        public bool? TrcbasedOnAmount { get; set; }
        [Column("insuranceTRCRatio", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceTrcratio { get; set; }
        [Column("insuranceTRCRest", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceTrcrest { get; set; }
        [Column("InsuranceTRCAmountMax", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceTrcamountMax { get; set; }
        [Column("InsuranceTRCAmount", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceTrcamount { get; set; }
        [Column("LastCumulInsuranceTRCHT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulInsuranceTrcht { get; set; }
        [Column("LastCumulInsuranceTRCVAT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulInsuranceTrcvat { get; set; }
        [Column("LastCumulInsuranceTRCTTC", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulInsuranceTrcttc { get; set; }
        [Column("InsuranceTRCAmountHT", TypeName = "decimal(38, 12)")]
        public decimal? InsuranceTrcamountHt { get; set; }
        [Column("InsuranceTRCAmountVAT", TypeName = "decimal(38, 12)")]
        public decimal? InsuranceTrcamountVat { get; set; }
        [Column("InsuranceTRCAmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceTrcamountTtc { get; set; }
        [Column("CumulInsuranceTRCHT", TypeName = "decimal(38, 6)")]
        public decimal? CumulInsuranceTrcht { get; set; }
        [Column("CumulInsuranceTRCVAT", TypeName = "decimal(38, 6)")]
        public decimal? CumulInsuranceTrcvat { get; set; }
        [Column("CumulInsuranceTRCTTC", TypeName = "decimal(38, 6)")]
        public decimal? CumulInsuranceTrcttc { get; set; }
        [Column("TotalInsuranceTRCAccumulted", TypeName = "decimal(38, 6)")]
        public decimal? TotalInsuranceTrcaccumulted { get; set; }
        [Column("LastCumulRetainedLinesHT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulRetainedLinesHt { get; set; }
        [Column("LastCumulRetainedLinesVAT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulRetainedLinesVat { get; set; }
        [Column("LastCumulRetainedLinesTTC", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulRetainedLinesTtc { get; set; }
        [Column("RetainedLinesHT", TypeName = "decimal(38, 6)")]
        public decimal? RetainedLinesHt { get; set; }
        [Column("RetainedLinesVAT", TypeName = "decimal(38, 6)")]
        public decimal? RetainedLinesVat { get; set; }
        [Column("RetainedLinesTTC", TypeName = "decimal(38, 6)")]
        public decimal? RetainedLinesTtc { get; set; }
        [Column("CumulRetainedLinesHT", TypeName = "decimal(38, 6)")]
        public decimal? CumulRetainedLinesHt { get; set; }
        [Column("CumulRetainedLinesVAT", TypeName = "decimal(38, 6)")]
        public decimal? CumulRetainedLinesVat { get; set; }
        [Column("CumulRetainedLinesTTC", TypeName = "decimal(38, 6)")]
        public decimal? CumulRetainedLinesTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CumulRetainedLines { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? RetainedAmount { get; set; }
        [Column("TotalRetainedLinesTTCAcumulated", TypeName = "decimal(38, 6)")]
        public decimal? TotalRetainedLinesTtcacumulated { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AchievementBaseAmount { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? LastAchievement { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? Achievement { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? LastCumulTotalToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CumulTotalToPay { get; set; }
        [Column("LastCumulAfterRetainsHT", TypeName = "decimal(38, 12)")]
        public decimal? LastCumulAfterRetainsHt { get; set; }
        [Column("LastCumulAfterRetainsVAT", TypeName = "decimal(38, 12)")]
        public decimal? LastCumulAfterRetainsVat { get; set; }
        [Column("LastCumulAfterRetainsTTC", TypeName = "decimal(26, 6)")]
        public decimal? LastCumulAfterRetainsTtc { get; set; }
        [Column("AmountTTCAfterDeductions", TypeName = "decimal(26, 6)")]
        public decimal? AmountTtcafterDeductions { get; set; }
        [Column("CumulAfterRetainsHT", TypeName = "decimal(38, 12)")]
        public decimal? CumulAfterRetainsHt { get; set; }
        [Column("CumulAfterRetainsVAT", TypeName = "decimal(38, 12)")]
        public decimal? CumulAfterRetainsVat { get; set; }
        [Column("CumulAfterRetainsTTC", TypeName = "decimal(26, 6)")]
        public decimal? CumulAfterRetainsTtc { get; set; }
        [Column("TotalNRRAmount", TypeName = "decimal(38, 6)")]
        public decimal? TotalNrramount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountRegul { get; set; }
        [Column("nonRefundableRetainer", TypeName = "decimal(26, 6)")]
        public decimal? NonRefundableRetainer { get; set; }
        [Column("amountToBePaid", TypeName = "decimal(26, 6)")]
        public decimal? AmountToBePaid { get; set; }
        [Column("refundableRetainer", TypeName = "decimal(26, 6)")]
        public decimal? RefundableRetainer { get; set; }
        [Column("WorkingOutAmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? WorkingOutAmountTtc { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal BuyDocumentAmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? BuyDocumentAmountToBePayedSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? BuyDocumentAmountToBePayedRest { get; set; }
        [Column("CumulRefendableRetainsHT", TypeName = "decimal(38, 6)")]
        public decimal? CumulRefendableRetainsHt { get; set; }
        [Column("CumulRefendableRetainsVAT", TypeName = "decimal(38, 6)")]
        public decimal? CumulRefendableRetainsVat { get; set; }
        [Column("CumulRefendableRetainsTTC", TypeName = "decimal(38, 6)")]
        public decimal? CumulRefendableRetainsTtc { get; set; }
        [Column("CumulNonRefendableRetainsHT", TypeName = "decimal(38, 6)")]
        public decimal? CumulNonRefendableRetainsHt { get; set; }
        [Column("CumulNonRefendableRetainsVAT", TypeName = "decimal(38, 6)")]
        public decimal? CumulNonRefendableRetainsVat { get; set; }
        [Column("CumulNonRefendableRetainsTTC", TypeName = "decimal(38, 6)")]
        public decimal? CumulNonRefendableRetainsTtc { get; set; }
        [Column("CumulRetainsHT", TypeName = "decimal(38, 6)")]
        public decimal? CumulRetainsHt { get; set; }
        [Column("CumulRetainsVAT", TypeName = "decimal(38, 6)")]
        public decimal? CumulRetainsVat { get; set; }
        [Column("CumulRetainsTTC", TypeName = "decimal(38, 6)")]
        public decimal? CumulRetainsTtc { get; set; }
        [Column("LastCumulNonRefendableRetainsHT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulNonRefendableRetainsHt { get; set; }
        [Column("LastCumulNonRefendableRetainsVAT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulNonRefendableRetainsVat { get; set; }
        [Column("LastCumulNonRefendableRetainsTTC", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulNonRefendableRetainsTtc { get; set; }
        [Column("LastCumulRefendableRetainsHT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulRefendableRetainsHt { get; set; }
        [Column("LastCumulRefendableRetainsVAT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulRefendableRetainsVat { get; set; }
        [Column("LastCumulRefendableRetainsTTC", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulRefendableRetainsTtc { get; set; }
        [Column("LastCumulRetainsHT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulRetainsHt { get; set; }
        [Column("LastCumulRetainsVAT", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulRetainsVat { get; set; }
        [Column("LastCumulRetainsTTC", TypeName = "decimal(38, 6)")]
        public decimal? LastCumulRetainsTtc { get; set; }
        [Column("MonthWorkHT", TypeName = "decimal(38, 12)")]
        public decimal? MonthWorkHt { get; set; }
        [Column("MonthWorkVAT", TypeName = "decimal(38, 12)")]
        public decimal? MonthWorkVat { get; set; }
        [Column("MonthWorkTTC", TypeName = "decimal(26, 6)")]
        public decimal? MonthWorkTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ExtraAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountToPay { get; set; }
        [Column("TotalHTAccumulted", TypeName = "decimal(38, 6)")]
        public decimal? TotalHtaccumulted { get; set; }
        [Column("TotalVATAccumulted", TypeName = "decimal(38, 6)")]
        public decimal? TotalVataccumulted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
    }
}

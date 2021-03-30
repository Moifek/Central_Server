using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class PrjMarketMonitoringView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public bool? IsMultiSupplier { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? PrjProjectId { get; set; }
        [StringLength(255)]
        public string PrjProjectCode { get; set; }
        [StringLength(255)]
        public string PrjProjectDescription { get; set; }
        public Guid? ProjectId { get; set; }
        [StringLength(255)]
        public string ProjectCode { get; set; }
        [StringLength(255)]
        public string ProjectDescription { get; set; }
        public Guid? StlCategoryId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlCategoryCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlCategoryDescription { get; set; }
        [StringLength(255)]
        public string CodeConsultation { get; set; }
        [Required]
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [Required]
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? PrjMarketTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjMarketTypeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjMarketTypeDescription { get; set; }
        public Guid? PrjMarketStatusId { get; set; }
        public int? PrjMarketStatusSorting { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjMarketStatusCode { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjMarketStatusDescription { get; set; }
        [Column(TypeName = "image")]
        public byte[] StatusImg { get; set; }
        public bool? IsCancellation { get; set; }
        public bool? IsClosed { get; set; }
        public bool? IsResiliation { get; set; }
        public int? IsTerminated { get; set; }
        [Required]
        [StringLength(255)]
        public string Status { get; set; }
        public bool? PrjMarketStatusWithMarketAdvance { get; set; }
        public bool? PrjMarketStatusWithWorkingOutAdvance { get; set; }
        public Guid? StlSettlementTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlSettlementTypeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlSettlementTypeDescription { get; set; }
        public int? PaymentDelay { get; set; }
        public Guid? CfgSupplierId { get; set; }
        [Required]
        public string SupplierCode { get; set; }
        [Required]
        public string SupplierDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDateManual { get; set; }
        public int? DelayManual { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDateManual { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        public int? Delay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WarrantyInMonths { get; set; }
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
        [Column("EstimatedNRRAmountManual", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedNrramountManual { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? EstimatedProportionRefundManual { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? EstimatedAmountToPayManual { get; set; }
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
        [Column("EstimatedNRRAmount", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedNrramount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? EstimatedProportionRefund { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? EstimatedAmountToPay { get; set; }
        [Column("OriginalOfferedPriceHT", TypeName = "decimal(38, 6)")]
        public decimal? OriginalOfferedPriceHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OriginalOfferedVatAmount { get; set; }
        [Column("OriginalOfferedPriceTTC", TypeName = "decimal(38, 6)")]
        public decimal? OriginalOfferedPriceTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OriginalOfferedAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OriginalOfferedWarrantyAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OriginalOfferedProportionAmount { get; set; }
        [Column("OriginalOfferedInsuranceDECAmount", TypeName = "decimal(38, 6)")]
        public decimal? OriginalOfferedInsuranceDecamount { get; set; }
        [Column("OriginalOfferedInsuranceTRCAmount", TypeName = "decimal(38, 6)")]
        public decimal? OriginalOfferedInsuranceTrcamount { get; set; }
        [Column("OriginalOfferedNRRAmount", TypeName = "decimal(38, 6)")]
        public decimal? OriginalOfferedNrramount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OriginalOfferedAmountToPay { get; set; }
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
        [Column("OfferedNRRAmount", TypeName = "decimal(38, 6)")]
        public decimal? OfferedNrramount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OffredProportionRefund { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OfferedAmountToPay { get; set; }
        [Column("PrevisionHT", TypeName = "decimal(38, 6)")]
        public decimal? PrevisionHt { get; set; }
        [Column("PrevisionVAT", TypeName = "decimal(38, 6)")]
        public decimal? PrevisionVat { get; set; }
        [Column("PrevisionTTC", TypeName = "decimal(38, 6)")]
        public decimal? PrevisionTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PrevisionAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PrevisionWarrantyAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PrevisionProportionAmount { get; set; }
        [Column("PrevisionInsuranceDECAmount", TypeName = "decimal(38, 6)")]
        public decimal? PrevisionInsuranceDecamount { get; set; }
        [Column("PrevisionInsuranceTRCAmount", TypeName = "decimal(38, 6)")]
        public decimal? PrevisionInsuranceTrcamount { get; set; }
        [Column("PrevisionNRRAmount", TypeName = "decimal(38, 6)")]
        public decimal? PrevisionNrramount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PrevisionProportionRefund { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PrevisionAmountToPay { get; set; }
        [Column("PrjWorkingOutTotalAmountHT", TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutTotalAmountHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutTotalAmountVat { get; set; }
        [Column("PrjWorkingOutTotalAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutTotalAmountTtc { get; set; }
        [Column("PrjWorkingOutTotalLinesHT", TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutTotalLinesHt { get; set; }
        [Column("PrjWorkingOutTotalLinesVAT", TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutTotalLinesVat { get; set; }
        [Column("PrjWorkingOutTotalLinesTTC", TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutTotalLinesTtc { get; set; }
        [Column("PrjWorkingOutTotalStockToPayAmountHT", TypeName = "decimal(38, 6)")]
        public decimal PrjWorkingOutTotalStockToPayAmountHt { get; set; }
        [Column("PrjWorkingOutTotalStockToPayAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutTotalStockToPayAmountVat { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal PrjWorkingOutTotalStockToPayAmount { get; set; }
        [Column("OverAmountHT", TypeName = "decimal(38, 6)")]
        public decimal OverAmountHt { get; set; }
        [Column("OverAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? OverAmountVat { get; set; }
        [Column("OverAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal OverAmountTtc { get; set; }
        [Column("ExtraAmountHT", TypeName = "decimal(38, 6)")]
        public decimal? ExtraAmountHt { get; set; }
        [Column("ExtraAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? ExtraAmountVat { get; set; }
        [Column("ExtraAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal? ExtraAmountTtc { get; set; }
        [Column("PrjWorkingOutTotalFluctuationsToPayAmountHT", TypeName = "decimal(38, 6)")]
        public decimal PrjWorkingOutTotalFluctuationsToPayAmountHt { get; set; }
        [Column("PrjWorkingOutTotalFluctuationsToPayAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutTotalFluctuationsToPayAmountVat { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal PrjWorkingOutTotalFluctuationsToPayAmount { get; set; }
        [Column("PrjWorkingOutTotalHT", TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutTotalHt { get; set; }
        [Column("PrjWorkingOutTotalVAT", TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutTotalVat { get; set; }
        [Column("PrjWorkingOutTotalTTC", TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutTotalTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal PrjWorkingOutTotalAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal PrjWorkingOutTotalWorkingOutAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal PrjWorkingOutTotalWarrantyAmount { get; set; }
        [Column("PrjWorkingOutTotalRRAmount", TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutTotalRramount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal PrjWorkingOutTotalProportionAmount { get; set; }
        [Column("PrjWorkingOutTotalInsuranceDECAmount", TypeName = "decimal(38, 6)")]
        public decimal PrjWorkingOutTotalInsuranceDecamount { get; set; }
        [Column("PrjWorkingOutTotalInsuranceTRCAmount", TypeName = "decimal(38, 6)")]
        public decimal PrjWorkingOutTotalInsuranceTrcamount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal PrjWorkingOutRetainedLineAmount { get; set; }
        [Column("PrjWorkingOutTotalNRRAmount", TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutTotalNrramount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal PrjWorkingOutTotalProrataRefundAmount { get; set; }
        [Column("PrjWorkingOutTotalREFAmount", TypeName = "decimal(38, 6)")]
        public decimal PrjWorkingOutTotalRefamount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutTotalAmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutTotalAmountSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutTotalAmountRest { get; set; }
        [Column("ClausesAmountHT", TypeName = "decimal(38, 6)")]
        public decimal ClausesAmountHt { get; set; }
        [Column("ClausesAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? ClausesAmountVat { get; set; }
        [Column("ClausesAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal ClausesAmountTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal ClausesWarrantyAmount { get; set; }
        [Column("ClausesRRAmount", TypeName = "decimal(38, 6)")]
        public decimal ClausesRramount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal ClausesProportionAmount { get; set; }
        [Column("ClausesInsuranceDECAmount", TypeName = "decimal(38, 6)")]
        public decimal ClausesInsuranceDecamount { get; set; }
        [Column("ClausesInsuranceTRCAmount", TypeName = "decimal(38, 6)")]
        public decimal ClausesInsuranceTrcamount { get; set; }
        [Column("ClausesNRRAmount", TypeName = "decimal(38, 6)")]
        public decimal? ClausesNrramount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal ClausesAmountToPay { get; set; }
        [Column("PrjWorkingOutCostHT", TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutCostHt { get; set; }
        [Column("PrjWorkingOutCostVAT", TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutCostVat { get; set; }
        [Column("PrjWorkingOutCostTTC", TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutCostTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal PrjWorkingOutCostAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal PrjWorkingOutCostWorkingOutAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutCostWarrantyAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutCostProportionAmount { get; set; }
        [Column("PrjWorkingOutCostInsuranceDECAmount", TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutCostInsuranceDecamount { get; set; }
        [Column("PrjWorkingOutCostInsuranceTRCAmount", TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutCostInsuranceTrcamount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal PrjWorkingOutCostRetainedLineAmount { get; set; }
        [Column("PrjWorkingOutCostNRRAmount", TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutCostNrramount { get; set; }
        [Column("PrjWorkingOutCostREFAmount", TypeName = "decimal(38, 6)")]
        public decimal PrjWorkingOutCostRefamount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutCostAmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutCostAmountSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutCostAmountRest { get; set; }
        [Column("InvoiceAmountHT", TypeName = "decimal(38, 6)")]
        public decimal InvoiceAmountHt { get; set; }
        [Column("InvoiceAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceAmountVat { get; set; }
        [Column("InvoiceAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal InvoiceAmountTtc { get; set; }
        [Column("InvoiceTotalLinesHT", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceTotalLinesHt { get; set; }
        [Column("InvoiceTotalLinesVAT", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceTotalLinesVat { get; set; }
        [Column("InvoiceTotalLinesTTC", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceTotalLinesTtc { get; set; }
        [Column("InvoiceTotalStockToPayAmountHT", TypeName = "decimal(38, 6)")]
        public decimal InvoiceTotalStockToPayAmountHt { get; set; }
        [Column("InvoiceTotalStockToPayAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceTotalStockToPayAmountVat { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal InvoiceTotalStockToPayAmount { get; set; }
        [Column("OverInvoiceAmountHT", TypeName = "decimal(38, 6)")]
        public decimal OverInvoiceAmountHt { get; set; }
        [Column("OverInvoiceAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? OverInvoiceAmountVat { get; set; }
        [Column("OverInvoiceAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal OverInvoiceAmountTtc { get; set; }
        [Column("InvoiceExtraAmountHT", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceExtraAmountHt { get; set; }
        [Column("InvoiceExtraAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceExtraAmountVat { get; set; }
        [Column("InvoiceExtraAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceExtraAmountTtc { get; set; }
        [Column("InvoiceTotalFluctuationsToPayAmountHT", TypeName = "decimal(38, 6)")]
        public decimal InvoiceTotalFluctuationsToPayAmountHt { get; set; }
        [Column("InvoiceTotalFluctuationsToPayAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceTotalFluctuationsToPayAmountVat { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal InvoiceTotalFluctuationsToPayAmount { get; set; }
        [Column("InvoiceTotalHT", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceTotalHt { get; set; }
        [Column("InvoiceTotalVAT", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceTotalVat { get; set; }
        [Column("InvoiceTotalTTC", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceTotalTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal InvoiceTotalAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal InvoiceTotalWorkingOutAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal InvoiceTotalWarrantyAmount { get; set; }
        [Column("InvoiceRRAmount", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceRramount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal InvoiceTotalProportionAmount { get; set; }
        [Column("InvoiceTotalInsuranceDECAmount", TypeName = "decimal(38, 6)")]
        public decimal InvoiceTotalInsuranceDecamount { get; set; }
        [Column("InvoiceTotalInsuranceTRCAmount", TypeName = "decimal(38, 6)")]
        public decimal InvoiceTotalInsuranceTrcamount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal InvoiceTotalRetainedLineAmount { get; set; }
        [Column("InvoiceNRRAmount", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceNrramount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal InvoiceTotalProrataRefundAmount { get; set; }
        [Column("InvoiceREFAmount", TypeName = "decimal(38, 6)")]
        public decimal InvoiceRefamount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal InvoiceTotalAmountRegul { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal InvoiceTotalFiscalStampAmount { get; set; }
        [Column("InvoiceREGAmount", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceRegamount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? InvoiceAmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? InvoiceAmountSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? InvoiceAmountRest { get; set; }
        [Column("ClausesInvoicedAmountHT", TypeName = "decimal(38, 6)")]
        public decimal ClausesInvoicedAmountHt { get; set; }
        [Column("ClausesInvoicedAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? ClausesInvoicedAmountVat { get; set; }
        [Column("ClausesInvoicedAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal ClausesInvoicedAmountTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal ClausesInvoicedWarrantyAmount { get; set; }
        [Column("ClausesInvoicedRRAmount", TypeName = "decimal(38, 6)")]
        public decimal ClausesInvoicedRramount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal ClausesInvoicedProportionAmount { get; set; }
        [Column("ClausesInvoicedInsuranceDECAmount", TypeName = "decimal(38, 6)")]
        public decimal ClausesInvoicedInsuranceDecamount { get; set; }
        [Column("ClausesInvoicedInsuranceTRCAmount", TypeName = "decimal(38, 6)")]
        public decimal ClausesInvoicedInsuranceTrcamount { get; set; }
        [Column("ClausesInvoicedNRRAmount", TypeName = "decimal(38, 6)")]
        public decimal? ClausesInvoicedNrramount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal ClausesInvoicedAmountRegul { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal ClausesInvoicedFiscalStampAmount { get; set; }
        [Column("ClausesInvoicedREGAmount", TypeName = "decimal(38, 6)")]
        public decimal? ClausesInvoicedRegamount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal ClausesInvoicedAmountToPay { get; set; }
        [Column("InvoiceCostHT", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceCostHt { get; set; }
        [Column("InvoiceCostVAT", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceCostVat { get; set; }
        [Column("InvoiceCostTTC", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceCostTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal InvoiceCostAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal InvoiceCostWorkingOutAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? InvoiceCostWarrantyAmount { get; set; }
        [Column("InvoiceCostRRAmount", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceCostRramount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? InvoiceCostProportionAmount { get; set; }
        [Column("InvoiceCostInsuranceDECAmount", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceCostInsuranceDecamount { get; set; }
        [Column("InvoiceCostInsuranceTRCAmount", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceCostInsuranceTrcamount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal InvoiceCostRetainedLineAmount { get; set; }
        [Column("InvoiceCostNRRAmount", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceCostNrramount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal InvoiceCostProrataRefundAmount { get; set; }
        [Column("InvoiceCostREFAmount", TypeName = "decimal(38, 6)")]
        public decimal InvoiceCostRefamount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? InvoiceCostAmountRegul { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? InvoiceCostFiscalStampAmount { get; set; }
        [Column("InvoiceCostREGAmount", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceCostRegamount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? InvoiceCostAmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? InvoiceCostAmountSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? InvoiceCostAmountRest { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Gap { get; set; }
        [Column("RefundsAmountHT", TypeName = "decimal(38, 6)")]
        public decimal RefundsAmountHt { get; set; }
        [Column("RefundsAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? RefundsAmountVat { get; set; }
        [Column("RefundsAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal RefundsAmountTtc { get; set; }
        [Column("RefundsLinesHT", TypeName = "decimal(38, 6)")]
        public decimal RefundsLinesHt { get; set; }
        [Column("RefundsLinesVAT", TypeName = "decimal(38, 6)")]
        public decimal? RefundsLinesVat { get; set; }
        [Column("RefundsLinesTTC", TypeName = "decimal(38, 6)")]
        public decimal RefundsLinesTtc { get; set; }
        [Column("RefundsTotalStockToPayAmountHT", TypeName = "decimal(38, 6)")]
        public decimal RefundsTotalStockToPayAmountHt { get; set; }
        [Column("RefundsTotalStockToPayAmountVAT", TypeName = "decimal(26, 6)")]
        public decimal? RefundsTotalStockToPayAmountVat { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal RefundsTotalStockToPayAmount { get; set; }
        [Column("RefundsTotalFluctuationsToPayAmountHT", TypeName = "decimal(38, 6)")]
        public decimal RefundsTotalFluctuationsToPayAmountHt { get; set; }
        [Column("RefundsTotalFluctuationsToPayAmountVAT", TypeName = "decimal(26, 6)")]
        public decimal? RefundsTotalFluctuationsToPayAmountVat { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal RefundsTotalFluctuationsToPayAmount { get; set; }
        [Column("RefundsTotalHT", TypeName = "decimal(38, 6)")]
        public decimal? RefundsTotalHt { get; set; }
        [Column("RefundsTotalVAT", TypeName = "decimal(38, 6)")]
        public decimal? RefundsTotalVat { get; set; }
        [Column("RefundsTotalTTC", TypeName = "decimal(38, 6)")]
        public decimal? RefundsTotalTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal RefundsTotalAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal RefundsTotalWorkingOutAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal RefundsTotalWarrantyAmount { get; set; }
        [Column("RefundsRRAmount", TypeName = "decimal(38, 6)")]
        public decimal? RefundsRramount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal RefundsTotalProportionAmount { get; set; }
        [Column("RefundsTotalInsuranceDECAmount", TypeName = "decimal(38, 6)")]
        public decimal RefundsTotalInsuranceDecamount { get; set; }
        [Column("RefundsTotalInsuranceTRCAmount", TypeName = "decimal(38, 6)")]
        public decimal RefundsTotalInsuranceTrcamount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal RefundsTotalRetainedLineAmount { get; set; }
        [Column("RefundsNRRAmount", TypeName = "decimal(38, 6)")]
        public decimal? RefundsNrramount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal RefundsTotalProrataRefundAmount { get; set; }
        [Column("RefundsREFAmount", TypeName = "decimal(38, 6)")]
        public decimal RefundsRefamount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal RefundsTotalAmountRegul { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal RefundsTotalFiscalStampAmount { get; set; }
        [Column("RefundsREGAmount", TypeName = "decimal(38, 6)")]
        public decimal? RefundsRegamount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? RefundsAmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? RefundsAmountToPaySettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? RefundsAmountToPayRest { get; set; }
        [Column("CostLinesHT", TypeName = "decimal(38, 6)")]
        public decimal? CostLinesHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CostLinesVat { get; set; }
        [Column("CostLinesTTC", TypeName = "decimal(38, 6)")]
        public decimal? CostLinesTtc { get; set; }
        [Column("CostStockHT", TypeName = "decimal(38, 6)")]
        public decimal CostStockHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CostStockVat { get; set; }
        [Column("CostStockTTC", TypeName = "decimal(38, 6)")]
        public decimal CostStockTtc { get; set; }
        [Column("CostOverHT", TypeName = "decimal(38, 6)")]
        public decimal CostOverHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CostOverVat { get; set; }
        [Column("CostOverTTC", TypeName = "decimal(38, 6)")]
        public decimal CostOverTtc { get; set; }
        [Column("CostExtraHT", TypeName = "decimal(38, 6)")]
        public decimal? CostExtraHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CostExtraVat { get; set; }
        [Column("CostExtraTTC", TypeName = "decimal(38, 6)")]
        public decimal? CostExtraTtc { get; set; }
        [Column("CostFluctuationHT", TypeName = "decimal(38, 6)")]
        public decimal CostFluctuationHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CostFluctuationVat { get; set; }
        [Column("CostFluctuationTTC", TypeName = "decimal(38, 6)")]
        public decimal CostFluctuationTtc { get; set; }
        [Column("CostTotalHT", TypeName = "decimal(38, 6)")]
        public decimal? CostTotalHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CostTotalVat { get; set; }
        [Column("CostTotalTTC", TypeName = "decimal(38, 6)")]
        public decimal? CostTotalTtc { get; set; }
        [Column("CostClauseHT", TypeName = "decimal(38, 6)")]
        public decimal CostClauseHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CostClauseVat { get; set; }
        [Column("CostClauseTTC", TypeName = "decimal(38, 6)")]
        public decimal CostClauseTtc { get; set; }
        [Column("CostHT", TypeName = "decimal(38, 6)")]
        public decimal? CostHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CostVat { get; set; }
        [Column("CostTTC", TypeName = "decimal(38, 6)")]
        public decimal? CostTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CostAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal CostWorkingOutAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CostWarrantyAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CostProportionAmount { get; set; }
        [Column("CostInsuranceDECAmount", TypeName = "decimal(38, 6)")]
        public decimal? CostInsuranceDecamount { get; set; }
        [Column("CostInsuranceTRCAmount", TypeName = "decimal(38, 6)")]
        public decimal? CostInsuranceTrcamount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal CostRetainedAmount { get; set; }
        [Column("CostNRRAmount", TypeName = "decimal(38, 6)")]
        public decimal? CostNrramount { get; set; }
        [Column("CostREFAmount", TypeName = "decimal(38, 6)")]
        public decimal? CostRefamount { get; set; }
        [Column("CostREGAmount", TypeName = "decimal(38, 6)")]
        public decimal? CostRegamount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CostToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CostToPaySettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CostToPayRest { get; set; }
        [Column("PositionHT", TypeName = "decimal(38, 6)")]
        public decimal? PositionHt { get; set; }
        [Column("PositionVAT", TypeName = "decimal(38, 6)")]
        public decimal? PositionVat { get; set; }
        [Column("PositionTTC", TypeName = "decimal(38, 6)")]
        public decimal? PositionTtc { get; set; }
        [Column("PositionLinesHT", TypeName = "decimal(38, 6)")]
        public decimal? PositionLinesHt { get; set; }
        [Column("PositionLinesVAT", TypeName = "decimal(38, 6)")]
        public decimal? PositionLinesVat { get; set; }
        [Column("PositionLinesTTC", TypeName = "decimal(38, 6)")]
        public decimal? PositionLinesTtc { get; set; }
        [Column("PositionStockToPayAmountHT", TypeName = "decimal(38, 6)")]
        public decimal? PositionStockToPayAmountHt { get; set; }
        [Column("PositionStockToPayAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? PositionStockToPayAmountVat { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PositionStockToPayAmount { get; set; }
        [Column("PositionOverHT", TypeName = "decimal(38, 6)")]
        public decimal PositionOverHt { get; set; }
        [Column("PositionOverVAT", TypeName = "decimal(38, 6)")]
        public decimal? PositionOverVat { get; set; }
        [Column("PositionOverTTC", TypeName = "decimal(38, 6)")]
        public decimal PositionOverTtc { get; set; }
        [Column("PositionExtraHT", TypeName = "decimal(38, 6)")]
        public decimal? PositionExtraHt { get; set; }
        [Column("PositionExtraVAT", TypeName = "decimal(38, 6)")]
        public decimal? PositionExtraVat { get; set; }
        [Column("PositionExtraTTC", TypeName = "decimal(38, 6)")]
        public decimal? PositionExtraTtc { get; set; }
        [Column("PositionFluctuationsHT", TypeName = "decimal(38, 6)")]
        public decimal? PositionFluctuationsHt { get; set; }
        [Column("PositionFluctuationsVAT", TypeName = "decimal(38, 6)")]
        public decimal? PositionFluctuationsVat { get; set; }
        [Column("PositionFluctuationsTTC", TypeName = "decimal(38, 6)")]
        public decimal? PositionFluctuationsTtc { get; set; }
        [Column("PositionClauseHT", TypeName = "decimal(38, 6)")]
        public decimal PositionClauseHt { get; set; }
        [Column("PositionClauseVAT", TypeName = "decimal(38, 6)")]
        public decimal? PositionClauseVat { get; set; }
        [Column("PositionClauseTTC", TypeName = "decimal(38, 6)")]
        public decimal PositionClauseTtc { get; set; }
        [Column("PositionTotalHT", TypeName = "decimal(38, 6)")]
        public decimal? PositionTotalHt { get; set; }
        [Column("PositionTotalVAT", TypeName = "decimal(38, 6)")]
        public decimal? PositionTotalVat { get; set; }
        [Column("PositionTotalTTC", TypeName = "decimal(38, 6)")]
        public decimal? PositionTotalTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PositionProportionAmount { get; set; }
        [Column("PositionInsuranceDECAmount", TypeName = "decimal(38, 6)")]
        public decimal? PositionInsuranceDecamount { get; set; }
        [Column("PositionInsuranceTRCAmount", TypeName = "decimal(38, 6)")]
        public decimal? PositionInsuranceTrcamount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PositionRetainedLineAmount { get; set; }
        [Column("PositionNRRAmount", TypeName = "decimal(38, 6)")]
        public decimal? PositionNrramount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PositionProrataRefundAmount { get; set; }
        [Column("PositionREFAmount", TypeName = "decimal(38, 6)")]
        public decimal? PositionRefamount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PositionAmountRegul { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PositionFiscalStampAmount { get; set; }
        [Column("PositionREGAmount", TypeName = "decimal(38, 6)")]
        public decimal? PositionRegamount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PositionAmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PositionAmountSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PositionAmountRest { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProportionRatio { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ProportionAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal ProportionAmountReal { get; set; }
        public bool? ManageProrata { get; set; }
        public Guid PrjProjectManageProrataId { get; set; }
        [Column("InvoiceProrataChargedAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceProrataChargedAmountTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal ProportionAmountToRefund { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? InvoicedProportionRefund { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OverWarrantyAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OverProportionAmount { get; set; }
        [Column("OverInsuranceDECAmount", TypeName = "decimal(38, 6)")]
        public decimal? OverInsuranceDecamount { get; set; }
        [Column("OverInsuranceTRCAmount", TypeName = "decimal(38, 6)")]
        public decimal? OverInsuranceTrcamount { get; set; }
        [Column("OverNRRAmount", TypeName = "decimal(38, 6)")]
        public decimal? OverNrramount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OverAmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OverInvoiceWarrantyAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OverInvoiceProportionAmount { get; set; }
        [Column("OverInvoiceInsuranceDECAmount", TypeName = "decimal(38, 6)")]
        public decimal? OverInvoiceInsuranceDecamount { get; set; }
        [Column("OverInvoiceInsuranceTRCAmount", TypeName = "decimal(38, 6)")]
        public decimal? OverInvoiceInsuranceTrcamount { get; set; }
        [Column("OverInvoiceNRRAmount", TypeName = "decimal(38, 6)")]
        public decimal? OverInvoiceNrramount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OverInvoiceAmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ExtraWarrantyAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ExtraProportionAmount { get; set; }
        [Column("ExtraInsuranceDECAmount", TypeName = "decimal(38, 6)")]
        public decimal? ExtraInsuranceDecamount { get; set; }
        [Column("ExtraInsuranceTRCAmount", TypeName = "decimal(38, 6)")]
        public decimal? ExtraInsuranceTrcamount { get; set; }
        [Column("ExtraNRRAmount", TypeName = "decimal(38, 6)")]
        public decimal? ExtraNrramount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? ExtraAmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutExtraLineInvoicedWarrantyAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutExtraLineInvoicedProportionAmount { get; set; }
        [Column("PrjWorkingOutExtraLineInvoicedInsuranceDECAmount", TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutExtraLineInvoicedInsuranceDecamount { get; set; }
        [Column("PrjWorkingOutExtraLineInvoicedInsuranceTRCAmount", TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutExtraLineInvoicedInsuranceTrcamount { get; set; }
        [Column("PrjWorkingOutExtraLineInvoicedNRRAmount", TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutExtraLineInvoicedNrramount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutExtraLineInvoicedAmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal AchivementBaseAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AchivementAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? Achievement { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AchivementAmountPrev { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AchievementPrev { get; set; }
        [Column("Gap_EstimatedPriceHT_EstimatedPriceHTManual", TypeName = "decimal(38, 6)")]
        public decimal? GapEstimatedPriceHtEstimatedPriceHtmanual { get; set; }
        [Column("Gap_EstimatedPriceTTC_EstimatedPriceTTCManual", TypeName = "decimal(38, 6)")]
        public decimal? GapEstimatedPriceTtcEstimatedPriceTtcmanual { get; set; }
        [Column("Gap_OriginalOfferedPriceHT_EstimatedPriceHTManual", TypeName = "decimal(38, 6)")]
        public decimal? GapOriginalOfferedPriceHtEstimatedPriceHtmanual { get; set; }
        [Column("Gap_OriginalOfferedPriceTTC_EstimatedPriceTTCManual", TypeName = "decimal(38, 6)")]
        public decimal? GapOriginalOfferedPriceTtcEstimatedPriceTtcmanual { get; set; }
        [Column("Gap_OriginalOfferedPriceTTC_EstimatedPriceHT", TypeName = "decimal(38, 6)")]
        public decimal? GapOriginalOfferedPriceTtcEstimatedPriceHt { get; set; }
        [Column("Gap_OriginalOfferedPriceTTC_EstimatedPriceTTC", TypeName = "decimal(38, 6)")]
        public decimal? GapOriginalOfferedPriceTtcEstimatedPriceTtc { get; set; }
        [Column("Gap_OfferedPriceHT_EstimatedPriceHTManual", TypeName = "decimal(38, 6)")]
        public decimal? GapOfferedPriceHtEstimatedPriceHtmanual { get; set; }
        [Column("Gap_OfferedPriceTTC_EstimatedPriceTTCManual", TypeName = "decimal(38, 6)")]
        public decimal? GapOfferedPriceTtcEstimatedPriceTtcmanual { get; set; }
        [Column("Gap_OfferedPriceHT_EstimatedPriceHT", TypeName = "decimal(38, 6)")]
        public decimal? GapOfferedPriceHtEstimatedPriceHt { get; set; }
        [Column("Gap_OfferedPriceTTC_EstimatedPriceTTC", TypeName = "decimal(38, 6)")]
        public decimal? GapOfferedPriceTtcEstimatedPriceTtc { get; set; }
        [Column("Gap_OfferedPriceHT_OriginalOfferedPriceHT", TypeName = "decimal(38, 6)")]
        public decimal? GapOfferedPriceHtOriginalOfferedPriceHt { get; set; }
        [Column("Gap_OfferedPriceTTC_OriginalOfferedPriceTTC", TypeName = "decimal(38, 6)")]
        public decimal? GapOfferedPriceTtcOriginalOfferedPriceTtc { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvanceRatio { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AdvanceAmount { get; set; }
        public int? AdvanceCountValidated { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AdvanceAmountValidated { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AdvanceAmountValidatedRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AdvanceSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AdvanceRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal AdvanceAmortized { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AdvanceAmortizedRest { get; set; }
        public int? WorkingOutAdvanceCount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? WorkingOutAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? WorkingOutAdvanceAmountSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? WorkingOutAdvanceAmountRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal WorkingOutAdvanceAmountAmortized { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? WorkingOutAdvanceAmountAmortizedRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutAdvancePenality { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? InvoiceAdvancePenality { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WarrantyRatio { get; set; }
        public int? WarrantyCountValidated { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? WarrantyAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? WarrantyRetained { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? WarrantyAmountPenality { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal WarrantyAmountValidated { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? WarrantyAmountValidatedRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? WarrantyRestitued { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? WarrantyRestituedRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PrjWorkingOutBlokRestitutionPenality { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? InvoiceBlokRestitutionPenality { get; set; }
        [Column("InsuranceDECRatio", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceDecratio { get; set; }
        [Column("InsuranceDECAmount", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceDecamount { get; set; }
        [Column("InsuranceDECAmountEstimated", TypeName = "decimal(38, 6)")]
        public decimal? InsuranceDecamountEstimated { get; set; }
        [Column("InsuranceDECAmountReal", TypeName = "decimal(38, 6)")]
        public decimal InsuranceDecamountReal { get; set; }
        [Column("InsuranceTRCRatio", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceTrcratio { get; set; }
        [Column("InsuranceTRCAmount", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceTrcamount { get; set; }
        [Column("InsuranceTRCAmountEstimated", TypeName = "decimal(38, 6)")]
        public decimal? InsuranceTrcamountEstimated { get; set; }
        [Column("InsuranceTRCAmountReal", TypeName = "decimal(38, 6)")]
        public decimal InsuranceTrcamountReal { get; set; }
        [Column("OrderAmountHT", TypeName = "decimal(38, 6)")]
        public decimal OrderAmountHt { get; set; }
        [Column("OrderAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? OrderAmountVat { get; set; }
        [Column("OrderAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal OrderAmountTtc { get; set; }
        [Column("DeliveryAmountHT", TypeName = "decimal(38, 6)")]
        public decimal DeliveryAmountHt { get; set; }
        [Column("DeliveryAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? DeliveryAmountVat { get; set; }
        [Column("DeliveryAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal DeliveryAmountTtc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LaunchOfTenderDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WithdrawalTenderDocumentsDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TenderMaturityDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TendersresortDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BidOpeningDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TendersreportDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TenderDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ContractSignatureDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ServiceOrderDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkLaunchDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkCompletionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReattachmentDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FinalReceiptDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RealMaxDate { get; set; }
        public int EstimationsLinesCount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? MassChangeRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StockPileRatio { get; set; }
        public int? TotalPoints { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DefaultVat { get; set; }
        public bool? WithMarketView { get; set; }
        public bool? ApplyDiscountOnAdditionalWork { get; set; }
        public bool? ApplyWithholdingTaxOnAdditionalWork { get; set; }
        public bool WarrantyBlokRestitution { get; set; }
        public bool? ExecutedQuantityBasedInsert { get; set; }
        public bool? CanEditWorkingOutLineByAchivement { get; set; }
        public bool? AchievmentBasedOnQuantity { get; set; }
        public bool? DuplicateInsertAutorised { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CancellationDate { get; set; }
        [StringLength(500)]
        public string CancellationCause { get; set; }
        [StringLength(500)]
        public string DescriptionLong { get; set; }
        public bool? IncludedInPaymentPrevision { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [Column("MarketLinesTotalHT", TypeName = "decimal(38, 6)")]
        public decimal MarketLinesTotalHt { get; set; }
        [Column("MarketLinesTotalVAT", TypeName = "decimal(38, 6)")]
        public decimal? MarketLinesTotalVat { get; set; }
        [Column("MarketLinesTotalTTC", TypeName = "decimal(38, 6)")]
        public decimal MarketLinesTotalTtc { get; set; }
        [Column("ModificationsHT", TypeName = "decimal(38, 6)")]
        public decimal? ModificationsHt { get; set; }
        [Column("ModificationsVAT", TypeName = "decimal(38, 6)")]
        public decimal? ModificationsVat { get; set; }
        [Column("ModificationsTTC", TypeName = "decimal(38, 6)")]
        public decimal? ModificationsTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal AmountRegul { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? DueAmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? DueAmountRest { get; set; }
        [Required]
        [StringLength(64)]
        public string PrevisionAlert { get; set; }
        public Guid? StrEntityId { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public string CfgTranches { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CancelRatio { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? PercentComplete { get; set; }
        public Guid? StkLevelingLineId { get; set; }
        [Column("WorkingOutBilledAmountHT", TypeName = "decimal(38, 6)")]
        public decimal WorkingOutBilledAmountHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? WorkingOutBilledVatAmount { get; set; }
        [Column("WorkingOutBilledAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal WorkingOutBilledAmountTtc { get; set; }
    }
}

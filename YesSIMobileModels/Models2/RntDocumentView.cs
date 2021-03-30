using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class RntDocumentView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PaymentDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(255)]
        public string PeriodDescription { get; set; }
        [StringLength(255)]
        public string DocType { get; set; }
        public int? DayNumber { get; set; }
        public int? VatExonorationNumber { get; set; }
        public Guid? RntPeriodicityId { get; set; }
        [StringLength(255)]
        public string RntPeriodicityCode { get; set; }
        [StringLength(255)]
        public string RntPeriodicityDescription { get; set; }
        public int? RntPeriodicityMonthNumber { get; set; }
        public int? RntPeriodicitySorting { get; set; }
        [StringLength(255)]
        public string RntPeriodicityUnity { get; set; }
        [Column("RentAgreementAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? RentAgreementAmountHt { get; set; }
        [Column("RentAdjustmentAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? RentAdjustmentAmountHt { get; set; }
        [Column("RentAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? RentAmountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? RentVatRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? RentAmountVat { get; set; }
        [Column("RentAmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? RentAmountTtc { get; set; }
        [Column("SyndicAgreementAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? SyndicAgreementAmountHt { get; set; }
        [Column("SyndicAdjustmentAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? SyndicAdjustmentAmountHt { get; set; }
        [Column("SyndicAmountHT", TypeName = "decimal(26, 6)")]
        public decimal? SyndicAmountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SyndicVatRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SyndicAmountVat { get; set; }
        [Column("SyndicAmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? SyndicAmountTtc { get; set; }
        [Column("AmountHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountVat { get; set; }
        [Column("AmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? AmountTtc { get; set; }
        [Column("AmountRefundedHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountRefundedHt { get; set; }
        [Column(TypeName = "decimal(27, 6)")]
        public decimal? AmountRefundedVat { get; set; }
        [Column("AmountRefundedTTC", TypeName = "decimal(26, 6)")]
        public decimal? AmountRefundedTtc { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FiscalStamp { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountToPay { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountDocumentSettled { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountInvoiceSettled { get; set; }
        [Column(TypeName = "decimal(27, 6)")]
        public decimal? AmountSettled { get; set; }
        [Column(TypeName = "decimal(28, 6)")]
        public decimal? AmountRest { get; set; }
        public string StlDocumentCode { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountInvoiced { get; set; }
        [Column(TypeName = "decimal(27, 6)")]
        public decimal? AmountInvoicedRest { get; set; }
        [Column("AmountInvoicedRestTTC", TypeName = "decimal(26, 6)")]
        public decimal? AmountInvoicedRestTtc { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? RentAmountInvoicedRest { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SyndicAmountInvoicedRest { get; set; }
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
        public Guid? RntSettlementCategoryId { get; set; }
        [StringLength(255)]
        public string RntSettlementCategoryCode { get; set; }
        [StringLength(255)]
        public string RntSettlementCategoryDescription { get; set; }
        [StringLength(500)]
        public string RntSettlementCategoryReportDescription { get; set; }
        public bool? IsCredit { get; set; }
        public bool? IsRentAmount { get; set; }
        public bool? IsRentCaution { get; set; }
        public bool? IsRentResiliation { get; set; }
        public bool? IsRentExpense { get; set; }
        public bool? IsSyndic { get; set; }
        public bool? IsEcheance { get; set; }
        public Guid? StlCategoryId { get; set; }
        public Guid? RntFolderId { get; set; }
        [StringLength(255)]
        public string RntFolderCode { get; set; }
        public Guid? SynFolderId { get; set; }
        [StringLength(255)]
        public string SynFolderCode { get; set; }
        public Guid? ComFolderId { get; set; }
        [StringLength(255)]
        public string ComFolderCode { get; set; }
        public bool? IsInvoiceCustomerGroupping { get; set; }
        public bool? IsSynPricing { get; set; }
        [StringLength(255)]
        public string Status { get; set; }
        [Column(TypeName = "image")]
        public byte[] StatusImg { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsCancellation { get; set; }
        public bool? IsClosing { get; set; }
        public bool? FolderStatusIsClosing { get; set; }
        public Guid? StkItemId { get; set; }
        [StringLength(255)]
        public string StkItemCode { get; set; }
        [StringLength(255)]
        public string StkItemDescription { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [StringLength(255)]
        public string CfgTrancheCode { get; set; }
        [StringLength(255)]
        public string CfgTrancheDescription { get; set; }
        public Guid? CfgProjectId { get; set; }
        [StringLength(255)]
        public string CfgProjectCode { get; set; }
        [StringLength(255)]
        public string CfgProjectDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? CfgTierId { get; set; }
        [StringLength(255)]
        public string CfgTierCode { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? CfgCommercialId { get; set; }
        [StringLength(255)]
        public string CfgCommercialCode { get; set; }
        [StringLength(255)]
        public string CfgCommercialDescription { get; set; }
        public Guid? StlRecoveryFolderId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlRecoveryFolderCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlRecoveryDescription { get; set; }
        public Guid? CfgDebtCollectorId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgDebtCollectorCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgDebtCollectorDescription { get; set; }
        public Guid? CfgDebtManagerId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgDebtManagerCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgDebtManagerDescription { get; set; }
        public Guid? AdmModuleId { get; set; }
        [StringLength(255)]
        public string AdmModuleCode { get; set; }
        [StringLength(255)]
        public string AdmModuleDescription { get; set; }
        public int? RntRevivalCount { get; set; }
        public Guid? BuyDocumentLineId { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
    }
}

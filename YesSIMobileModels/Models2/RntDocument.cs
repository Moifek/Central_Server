using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("RntDocument")]
    [Index(nameof(RntFolderId), Name = "IDX_RntDocument_RntFolderId_PKey_RentAmountHT_RentVatRatio_RentAmountTTC")]
    [Index(nameof(RntFolderId), nameof(PaymentDate), Name = "IDX_RntDocument_RntFolderId_PaymentDate_PKey_RntSettlementCategoryId")]
    [Index(nameof(SynFolderId), Name = "_dta_index_RntDocument_5_1602156803__K10")]
    [Index(nameof(SynFolderId), nameof(Pkey), nameof(RntFolderId), nameof(RntSettlementCategoryId), nameof(AmountInvoicedCalculated), nameof(AmountToPayCalculated), nameof(Code), Name = "_dta_index_RntDocument_5_1602156803__K10_K1_K11_K30_K41_K46_K2_3_4_6")]
    [Index(nameof(SynFolderId), nameof(Pkey), nameof(SyndicAmountHt), nameof(SyndicAmountTtc), nameof(RntSettlementCategoryId), nameof(RntFolderId), nameof(FiscalStampCalculated), Name = "_dta_index_RntDocument_5_1602156803__K10_K1_K20_K23_K30_K11_K45")]
    [Index(nameof(SynFolderId), nameof(Pkey), nameof(RntSettlementCategoryId), nameof(RntFolderId), nameof(PaymentDate), nameof(SyndicAmountHt), nameof(AmountDocumentSettledCalculated), nameof(AmountInvoiceSettledCalculated), nameof(FiscalStampCalculated), nameof(SyndicAmountTtc), nameof(RentAmountTtc), nameof(RentAmountHt), Name = "_dta_index_RntDocument_5_1602156803__K10_K1_K30_K11_K4_K20_K47_K48_K45_K23_K17_K14")]
    [Index(nameof(SynFolderId), nameof(RntSettlementCategoryId), nameof(RntFolderId), nameof(Pkey), nameof(PaymentDate), Name = "_dta_index_RntDocument_5_1602156803__K10_K30_K11_K1_K4")]
    [Index(nameof(SynFolderId), nameof(RntSettlementCategoryId), nameof(PaymentDate), nameof(FiscalStampCalculated), nameof(RntFolderId), nameof(AmountDocumentSettledCalculated), nameof(AmountInvoiceSettledCalculated), Name = "_dta_index_RntDocument_5_1602156803__K10_K30_K4_K45_K11_K47_K48")]
    [Index(nameof(SynFolderId), nameof(PaymentDate), nameof(Pkey), nameof(RntFolderId), nameof(AmountHt), nameof(AmountInvoicedCalculated), nameof(RentAmountInvoicedRestCalculated), nameof(SyndicAmountInvoicedRestCalculated), nameof(Code), Name = "_dta_index_RntDocument_5_1602156803__K10_K4_K1_K11_K24_K41_K43_K44_K2_3_5_6_8_9_14_15_16_17_20_21_22_23_25_26_29_30_31_45_46")]
    [Index(nameof(SynFolderId), nameof(PaymentDate), nameof(Pkey), nameof(RntFolderId), nameof(AmountInvoicedRestTtccalculated), Name = "_dta_index_RntDocument_5_1602156803__K10_K4_K1_K11_K42")]
    [Index(nameof(SynFolderId), nameof(PaymentDate), nameof(Pkey), nameof(RntSettlementCategoryId), nameof(RntFolderId), nameof(SyndicAmountHt), nameof(SyndicAmountTtc), nameof(FiscalStampCalculated), nameof(AmountDocumentSettledCalculated), nameof(AmountInvoiceSettledCalculated), Name = "_dta_index_RntDocument_5_1602156803__K10_K4_K1_K30_K11_K20_K23_K45_K47_K48")]
    [Index(nameof(SynFolderId), nameof(PaymentDate), nameof(Pkey), nameof(RntSettlementCategoryId), nameof(RntFolderId), nameof(SyndicAmountHt), nameof(AmountDocumentSettledCalculated), nameof(AmountInvoiceSettledCalculated), nameof(FiscalStampCalculated), nameof(SyndicAmountTtc), nameof(RentAmountTtc), nameof(RentAmountHt), Name = "_dta_index_RntDocument_5_1602156803__K10_K4_K1_K30_K11_K20_K47_K48_K45_K23_K17_K14")]
    [Index(nameof(RntFolderId), Name = "_dta_index_RntDocument_5_1602156803__K11_30")]
    [Index(nameof(RntFolderId), nameof(RentAmountTtc), nameof(PaymentDate), Name = "_dta_index_RntDocument_5_1602156803__K11_K17_K4_30")]
    [Index(nameof(RntFolderId), nameof(Pkey), nameof(RentAmountTtc), nameof(RentAmountHt), nameof(SynFolderId), Name = "_dta_index_RntDocument_5_1602156803__K11_K1_K17_K14_K10")]
    [Index(nameof(RntFolderId), nameof(Pkey), nameof(SyndicAmountHt), nameof(SyndicAmountTtc), Name = "_dta_index_RntDocument_5_1602156803__K11_K1_K20_K23")]
    [Index(nameof(RntFolderId), nameof(Pkey), nameof(SyndicAmountHt), nameof(SyndicAmountTtc), nameof(SynFolderId), nameof(RntSettlementCategoryId), nameof(RentAmountTtc), Name = "_dta_index_RntDocument_5_1602156803__K11_K1_K20_K23_K10_K30_K17")]
    [Index(nameof(RntFolderId), nameof(Pkey), nameof(PaymentDate), nameof(SyndicAmountHt), nameof(SynFolderId), nameof(SyndicAmountTtc), nameof(RentAmountTtc), Name = "_dta_index_RntDocument_5_1602156803__K11_K1_K4_K20_K10_K23_K17_30")]
    [Index(nameof(RntFolderId), nameof(SyndicAmountTtc), Name = "_dta_index_RntDocument_5_1602156803__K11_K23_30")]
    [Index(nameof(RntFolderId), nameof(SyndicAmountTtc), nameof(PaymentDate), Name = "_dta_index_RntDocument_5_1602156803__K11_K23_K4_30")]
    [Index(nameof(RntFolderId), nameof(SyndicAmountTtc), nameof(PaymentDate), nameof(SynFolderId), nameof(Pkey), Name = "_dta_index_RntDocument_5_1602156803__K11_K23_K4_K10_K1_30")]
    [Index(nameof(RntFolderId), nameof(SyndicAmountTtc), nameof(PaymentDate), nameof(SynFolderId), nameof(Pkey), nameof(RentAmountTtc), nameof(AmountDocumentSettledCalculated), nameof(AmountInvoiceSettledCalculated), Name = "_dta_index_RntDocument_5_1602156803__K11_K23_K4_K10_K1_K17_K47_K48_30")]
    [Index(nameof(RntFolderId), nameof(PaymentDate), Name = "_dta_index_RntDocument_5_1602156803__K11_K4")]
    [Index(nameof(RntFolderId), nameof(FiscalStampCalculated), nameof(PaymentDate), Name = "_dta_index_RntDocument_5_1602156803__K11_K45_K4_30")]
    [Index(nameof(Pkey), nameof(RntFolderId), nameof(SynFolderId), Name = "_dta_index_RntDocument_5_1602156803__K1_K11_K10_6")]
    [Index(nameof(Pkey), nameof(RntFolderId), nameof(AmountTtc), Name = "_dta_index_RntDocument_5_1602156803__K1_K11_K26")]
    [Index(nameof(Pkey), nameof(SyndicAmountHt), nameof(SyndicAmountTtc), Name = "_dta_index_RntDocument_5_1602156803__K1_K20_K23_11")]
    [Index(nameof(Pkey), nameof(RntSettlementCategoryId), Name = "_dta_index_RntDocument_5_1602156803__K1_K30")]
    [Index(nameof(RntSettlementCategoryId), nameof(RntFolderId), nameof(RentAmountTtc), Name = "_dta_index_RntDocument_5_1602156803__K30_K11_K17")]
    [Index(nameof(RntSettlementCategoryId), nameof(RntFolderId), nameof(Pkey), nameof(PaymentDate), nameof(SynFolderId), Name = "_dta_index_RntDocument_5_1602156803__K30_K11_K1_K4_K10")]
    [Index(nameof(RntSettlementCategoryId), nameof(RntFolderId), nameof(AmountDocumentSettledCalculated), nameof(AmountInvoiceSettledCalculated), nameof(SynFolderId), nameof(Pkey), Name = "_dta_index_RntDocument_5_1602156803__K30_K11_K47_K48_K10_K1")]
    [Index(nameof(RntSettlementCategoryId), nameof(RntFolderId), nameof(PaymentDate), nameof(RentAmountTtc), nameof(SynFolderId), nameof(Pkey), Name = "_dta_index_RntDocument_5_1602156803__K30_K11_K4_K17_K10_K1")]
    [Index(nameof(RntSettlementCategoryId), nameof(RntFolderId), nameof(PaymentDate), nameof(SyndicAmountTtc), Name = "_dta_index_RntDocument_5_1602156803__K30_K11_K4_K23")]
    [Index(nameof(AmountInvoicedCalculated), nameof(RntFolderId), nameof(RntSettlementCategoryId), nameof(Code), nameof(SynFolderId), nameof(Pkey), Name = "_dta_index_RntDocument_5_1602156803__K41_K11_K30_K2_K10_K1_3_4_6")]
    [Index(nameof(AmountInvoicedRestTtccalculated), nameof(PaymentDate), nameof(RntFolderId), Name = "_dta_index_RntDocument_5_1602156803__K42_K4_K11")]
    [Index(nameof(PaymentDate), nameof(Pkey), nameof(RntFolderId), nameof(SyndicAmountHt), Name = "_dta_index_RntDocument_5_1602156803__K4D_K1_K11_K20_30")]
    [Index(nameof(PaymentDate), nameof(RntFolderId), nameof(SynFolderId), nameof(Pkey), nameof(RentAmountHt), nameof(RentAmountTtc), nameof(SyndicAmountHt), nameof(SyndicAmountTtc), nameof(FiscalStampCalculated), nameof(RntSettlementCategoryId), nameof(AmountHt), nameof(AmountInvoicedCalculated), nameof(RentAmountInvoicedRestCalculated), nameof(SyndicAmountInvoicedRestCalculated), nameof(Code), Name = "_dta_index_RntDocument_5_1602156803__K4_K11_K10_K1_K14_K17_K20_K23_K45_K30_K24_K41_K43_K44_K2_3_5_6_8_9_15_16_21_22_25_26_29_")]
    [Index(nameof(Pkey), nameof(SynFolderId), nameof(RntFolderId), Name = "_dta_index_RntDocument_7_1602156803__K1_K10_K11")]
    public partial class RntDocument
    {
        public RntDocument()
        {
            RntRevivals = new HashSet<RntRevival>();
            RntSettlementLines = new HashSet<RntSettlementLine>();
            StlDocumentLines = new HashSet<StlDocumentLine>();
            StlPaymentAuthorizationLines = new HashSet<StlPaymentAuthorizationLine>();
        }

        [Key]
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
        public Guid? SynFolderId { get; set; }
        public Guid? RntFolderId { get; set; }
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
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? RntSettlementCategoryId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? AdmModuleId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? RntReconductionHistoryId { get; set; }
        public Guid? RntPeriodicityId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountInvoicedCalculated { get; set; }
        [Column("AmountInvoicedRestTTCCalculated", TypeName = "decimal(26, 6)")]
        public decimal? AmountInvoicedRestTtccalculated { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? RentAmountInvoicedRestCalculated { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SyndicAmountInvoicedRestCalculated { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FiscalStampCalculated { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountToPayCalculated { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountDocumentSettledCalculated { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountInvoiceSettledCalculated { get; set; }
        [Column("AmountRefundedHTCalculated", TypeName = "decimal(26, 6)")]
        public decimal? AmountRefundedHtcalculated { get; set; }
        [Column("AmountRefundedTTCCalculated", TypeName = "decimal(26, 6)")]
        public decimal? AmountRefundedTtccalculated { get; set; }
        public Guid? CfgDebtCollectorId { get; set; }
        public Guid? StlRecoveryFolderId { get; set; }
        public Guid? BuyDocumentLineId { get; set; }
        public Guid? ComFolderId { get; set; }

        [ForeignKey(nameof(AdmModuleId))]
        [InverseProperty("RntDocuments")]
        public virtual AdmModule AdmModule { get; set; }
        [ForeignKey(nameof(BuyDocumentLineId))]
        [InverseProperty("RntDocuments")]
        public virtual BuyDocumentLine BuyDocumentLine { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("RntDocuments")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgDebtCollectorId))]
        [InverseProperty(nameof(CfgTier.RntDocuments))]
        public virtual CfgTier CfgDebtCollector { get; set; }
        [ForeignKey(nameof(ComFolderId))]
        [InverseProperty("RntDocuments")]
        public virtual ComFolder ComFolder { get; set; }
        [ForeignKey(nameof(RntFolderId))]
        [InverseProperty("RntDocuments")]
        public virtual RntFolder RntFolder { get; set; }
        [ForeignKey(nameof(RntPeriodicityId))]
        [InverseProperty("RntDocuments")]
        public virtual RntPeriodicity RntPeriodicity { get; set; }
        [ForeignKey(nameof(RntReconductionHistoryId))]
        [InverseProperty("RntDocuments")]
        public virtual RntReconductionHistory RntReconductionHistory { get; set; }
        [ForeignKey(nameof(RntSettlementCategoryId))]
        [InverseProperty("RntDocuments")]
        public virtual RntSettlementCategory RntSettlementCategory { get; set; }
        [ForeignKey(nameof(StlRecoveryFolderId))]
        [InverseProperty("RntDocuments")]
        public virtual StlRecoveryFolder StlRecoveryFolder { get; set; }
        [ForeignKey(nameof(SynFolderId))]
        [InverseProperty("RntDocuments")]
        public virtual SynFolder SynFolder { get; set; }
        [InverseProperty(nameof(RntRevival.RntDocument))]
        public virtual ICollection<RntRevival> RntRevivals { get; set; }
        [InverseProperty(nameof(RntSettlementLine.RntDocument))]
        public virtual ICollection<RntSettlementLine> RntSettlementLines { get; set; }
        [InverseProperty(nameof(StlDocumentLine.RntDocument))]
        public virtual ICollection<StlDocumentLine> StlDocumentLines { get; set; }
        [InverseProperty(nameof(StlPaymentAuthorizationLine.RntDocument))]
        public virtual ICollection<StlPaymentAuthorizationLine> StlPaymentAuthorizationLines { get; set; }
    }
}

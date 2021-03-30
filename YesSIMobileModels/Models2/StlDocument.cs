using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlDocument")]
    [Index(nameof(DocType), nameof(Pkey), Name = "_dta_index_StlDocument_5_1408060102__K17_K1")]
    [Index(nameof(DocType), nameof(Pkey), nameof(AmountToPay), Name = "_dta_index_StlDocument_5_1408060102__K17_K1_K14")]
    [Index(nameof(DocType), nameof(IsCredit), nameof(CfgTierId), nameof(Pkey), nameof(StrEntityId), nameof(AdmModuleId), nameof(CfgCompanyId), Name = "_dta_index_StlDocument_5_1408060102__K17_K22_K23_K1_K26_K24_K25_2_3_4_5_6_7_8_14_15_16_18_19_21_27_28_29_30_32_33_36_37_38_39_")]
    [Index(nameof(DocType), nameof(AdmModuleId), nameof(IsCredit), Name = "_dta_index_StlDocument_5_1408060102__K17_K24_K22_1_5_8_16_23")]
    [Index(nameof(DocType), nameof(AdmModuleId), nameof(IsCredit), nameof(CfgTierId), Name = "_dta_index_StlDocument_5_1408060102__K17_K24_K22_K23_1_5_8_16")]
    [Index(nameof(DocType), nameof(AmountHt), nameof(Pkey), Name = "_dta_index_StlDocument_5_1408060102__K17_K6_K1")]
    [Index(nameof(Pkey), Name = "_dta_index_StlDocument_5_1408060102__K1_2")]
    [Index(nameof(Pkey), nameof(DocType), Name = "_dta_index_StlDocument_5_1408060102__K1_K17")]
    [Index(nameof(Pkey), nameof(DocType), nameof(AmountHt), Name = "_dta_index_StlDocument_5_1408060102__K1_K17_K6")]
    [Index(nameof(Pkey), nameof(DocDate), nameof(DocType), nameof(AdmModuleId), nameof(IsCredit), Name = "_dta_index_StlDocument_5_1408060102__K1_K4_K17_K24_K22")]
    [Index(nameof(IsCredit), nameof(Pkey), nameof(DocType), nameof(AmountToPay), Name = "_dta_index_StlDocument_5_1408060102__K22_K1_K17_K14")]
    [Index(nameof(DocDate), nameof(DocType), nameof(AdmModuleId), nameof(IsCredit), nameof(Pkey), nameof(StrEntityId), nameof(CfgCompanyId), nameof(CfgTierId), Name = "_dta_index_StlDocument_5_1408060102__K4_K17_K24_K22_K1_K26_K25_K23_2_3_5_6_7_8_14_15_16_18_19_21_27_28_29_30_32_33_36_37_38_39_")]
    public partial class StlDocument
    {
        public StlDocument()
        {
            ActEntries = new HashSet<ActEntry>();
            ComSettlementLines = new HashSet<ComSettlementLine>();
            InverseStlPenaltyDocument = new HashSet<StlDocument>();
            RntRevivals = new HashSet<RntRevival>();
            RntSettlementLines = new HashSet<RntSettlementLine>();
            StlAccountingEntries = new HashSet<StlAccountingEntry>();
            StlDocumentLines = new HashSet<StlDocumentLine>();
            StlPaymentAuthorizationLines = new HashSet<StlPaymentAuthorizationLine>();
            StlVentilationCategories = new HashSet<StlVentilationCategory>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MaturityDate { get; set; }
        [Column("AmountHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountVat { get; set; }
        [Column("AmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? AmountTtc { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountToPay { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountRegul { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FiscalStamp { get; set; }
        [StringLength(255)]
        public string DocType { get; set; }
        [StringLength(255)]
        public string DocRef { get; set; }
        [StringLength(255)]
        public string ReferenceType { get; set; }
        [StringLength(255)]
        public string SupplierDescription { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public bool? IsCredit { get; set; }
        public Guid? CfgTierId { get; set; }
        public Guid? AdmModuleId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public int? LinesCount { get; set; }
        [StringLength(255)]
        public string PersonToContact { get; set; }
        [StringLength(1000)]
        public string Notes1 { get; set; }
        [Column("AmountRefundedHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountRefundedHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountRefundedVat { get; set; }
        [Column("AmountRefundedTTC", TypeName = "decimal(26, 6)")]
        public decimal? AmountRefundedTtc { get; set; }
        [Column("TotalHT", TypeName = "decimal(26, 6)")]
        public decimal? TotalHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TotalVat { get; set; }
        [Column("TotalTTC", TypeName = "decimal(26, 6)")]
        public decimal? TotalTtc { get; set; }
        [StringLength(255)]
        public string CodeProforma { get; set; }
        [StringLength(255)]
        public string OrderCode { get; set; }
        public bool? IsImported { get; set; }
        public bool? IsAccounted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PaymentAuthorizationDate { get; set; }
        public Guid? CfgDebtCollectorId { get; set; }
        public Guid? StlPenaltyDocumentId { get; set; }
        public Guid? StlRecoveryFolderId { get; set; }
        public Guid? StlCurrencyId { get; set; }

        [ForeignKey(nameof(AdmModuleId))]
        [InverseProperty("StlDocuments")]
        public virtual AdmModule AdmModule { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("StlDocuments")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgDebtCollectorId))]
        [InverseProperty("StlDocumentCfgDebtCollectors")]
        public virtual CfgTier CfgDebtCollector { get; set; }
        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("StlDocumentCfgTiers")]
        public virtual CfgTier CfgTier { get; set; }
        [ForeignKey(nameof(StlCurrencyId))]
        [InverseProperty("StlDocuments")]
        public virtual StlCurrency StlCurrency { get; set; }
        [ForeignKey(nameof(StlPenaltyDocumentId))]
        [InverseProperty(nameof(StlDocument.InverseStlPenaltyDocument))]
        public virtual StlDocument StlPenaltyDocument { get; set; }
        [ForeignKey(nameof(StlRecoveryFolderId))]
        [InverseProperty("StlDocuments")]
        public virtual StlRecoveryFolder StlRecoveryFolder { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("StlDocuments")]
        public virtual StrEntity StrEntity { get; set; }
        [InverseProperty(nameof(ActEntry.StlDocument))]
        public virtual ICollection<ActEntry> ActEntries { get; set; }
        [InverseProperty(nameof(ComSettlementLine.StlDocument))]
        public virtual ICollection<ComSettlementLine> ComSettlementLines { get; set; }
        [InverseProperty(nameof(StlDocument.StlPenaltyDocument))]
        public virtual ICollection<StlDocument> InverseStlPenaltyDocument { get; set; }
        [InverseProperty(nameof(RntRevival.StlDocument))]
        public virtual ICollection<RntRevival> RntRevivals { get; set; }
        [InverseProperty(nameof(RntSettlementLine.StlDocument))]
        public virtual ICollection<RntSettlementLine> RntSettlementLines { get; set; }
        [InverseProperty(nameof(StlAccountingEntry.StlDocument))]
        public virtual ICollection<StlAccountingEntry> StlAccountingEntries { get; set; }
        [InverseProperty(nameof(StlDocumentLine.StlDocument))]
        public virtual ICollection<StlDocumentLine> StlDocumentLines { get; set; }
        [InverseProperty(nameof(StlPaymentAuthorizationLine.StlDocument))]
        public virtual ICollection<StlPaymentAuthorizationLine> StlPaymentAuthorizationLines { get; set; }
        [InverseProperty(nameof(StlVentilationCategory.StlDocument))]
        public virtual ICollection<StlVentilationCategory> StlVentilationCategories { get; set; }
    }
}

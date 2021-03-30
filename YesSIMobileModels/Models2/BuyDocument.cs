using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyDocument")]
    [Index(nameof(IsPropotionCharged), nameof(Pkey), Name = "_dta_index_BuyDocument_10_935674381__K109_K1_9")]
    [Index(nameof(DocType), nameof(PrjMarketId), nameof(Pkey), Name = "_dta_index_BuyDocument_10_935674381__K19_K34_K1_44")]
    [Index(nameof(DocType), nameof(PrjMarketId), nameof(Pkey), nameof(StrEntityId), Name = "_dta_index_BuyDocument_10_935674381__K19_K34_K1_K87_6_9_12_14_26_36_38_40_42_44_70_73_74_96")]
    [Index(nameof(DocType), nameof(PrjMarketId), nameof(Pkey), nameof(StrEntityId), Name = "_dta_index_BuyDocument_10_935674381__K19_K34_K1_K87_6_9_12_26_36_38_40_42_44_70_73_74")]
    [Index(nameof(DocType), nameof(PrjMarketId), nameof(Pkey), nameof(StrEntityId), nameof(BuyOrderId), Name = "_dta_index_BuyDocument_10_935674381__K19_K34_K1_K87_K95_6_9_12_14_26_36_38_40_42_44_70_73_74_96")]
    [Index(nameof(DocType), nameof(PrjMarketId), nameof(Pkey), nameof(StrEntityId), nameof(BuyOrderId), nameof(CfgTierId), nameof(IsSelected), nameof(DocDate), Name = "_dta_index_BuyDocument_10_935674381__K19_K34_K1_K87_K95_K21_K22_K5_6_9_12_14_26_36_38_40_42_44_69_70_73_74_79_96")]
    [Index(nameof(DocType), nameof(PrjMarketId), nameof(Pkey), nameof(StrEntityId), nameof(BuyOrderId), nameof(CfgTierId), nameof(IsSelected), nameof(DocDate), nameof(IsPropotionCharged), nameof(PrjProjectId), Name = "_dta_index_BuyDocument_10_935674381__K19_K34_K1_K87_K95_K21_K22_K5_K109_K80_6_9_12_14_26_33_36_38_40_42_44_69_70_73_74_79_96")]
    [Index(nameof(DocType), nameof(BuyOrderId), Name = "_dta_index_BuyDocument_10_935674381__K19_K95_6")]
    [Index(nameof(DocType), nameof(BuyOrderId), nameof(PrjMarketId), Name = "_dta_index_BuyDocument_10_935674381__K19_K95_K34_1_5_6_9_12_14_21_22_26_33_36_38_40_42_44_51_69_70_73_74_79_80_87_96_109")]
    [Index(nameof(Pkey), Name = "_dta_index_BuyDocument_10_935674381__K1_2_4_14")]
    [Index(nameof(Pkey), nameof(PrjMarketId), Name = "_dta_index_BuyDocument_10_935674381__K1_K34")]
    [Index(nameof(ReferenceType), nameof(PrjMarketId), Name = "_dta_index_BuyDocument_10_935674381__K33_K34_9")]
    [Index(nameof(ReferenceType), nameof(PrjMarketId), nameof(Pkey), Name = "_dta_index_BuyDocument_10_935674381__K33_K34_K1_5_6_9_12_14_19_21_22_26_36_38_40_42_44_51_69_70_73_74_79_80_87_95_96_109")]
    [Index(nameof(PrjMarketId), nameof(DocType), nameof(IsSelected), nameof(DocDate), nameof(Pkey), Name = "_dta_index_BuyDocument_10_935674381__K34_K19_K22_K5_K1_6_9_33")]
    [Index(nameof(PrjMarketId), nameof(DocType), nameof(DocDate), Name = "_dta_index_BuyDocument_10_935674381__K34_K19_K5")]
    [Index(nameof(PrjMarketId), nameof(CfgTierId), nameof(DocType), nameof(IsSelected), nameof(DocDate), Name = "_dta_index_BuyDocument_10_935674381__K34_K21_K19_K22_K5_6_9")]
    [Index(nameof(PrjMarketId), nameof(ReferenceType), Name = "_dta_index_BuyDocument_10_935674381__K34_K33_1_5_6_9_12_14_19_21_22_26_36_38_40_42_44_51_69_70_73_74_79_87_95_96")]
    [Index(nameof(PrjMarketId), nameof(ReferenceType), Name = "_dta_index_BuyDocument_10_935674381__K34_K33_9")]
    [Index(nameof(PrjProjectId), nameof(IsPropotionCharged), nameof(PrjMarketId), nameof(ReferenceType), nameof(Pkey), Name = "_dta_index_BuyDocument_10_935674381__K80_K109_K34_K33_K1_5_6_9_12_14_19_21_22_26_36_38_40_42_44_51_69_70_73_74_79_87_95_96")]
    [Index(nameof(StrEntityId), nameof(Pkey), nameof(PrjMarketId), nameof(ReferenceType), Name = "_dta_index_BuyDocument_10_935674381__K87_K1_K34_K33_5_6_9_12_14_19_21_22_26_36_38_40_42_44_51_69_70_73_74_79_80_95_96_109")]
    [Index(nameof(BuyOrderId), nameof(DocType), Name = "_dta_index_BuyDocument_10_935674381__K95_K19_9")]
    [Index(nameof(BuyOrderId), nameof(DocType), nameof(PrjMarketId), Name = "_dta_index_BuyDocument_10_935674381__K95_K19_K34_1_5_6_9_12_14_21_22_26_33_36_38_40_42_44_51_69_70_73_74_79_80_87_96_109")]
    [Index(nameof(DocType), nameof(PrjMarketId), Name = "_dta_index_BuyDocument_5_1675153013__K19_K34_36")]
    [Index(nameof(DocType), nameof(PrjMarketId), Name = "_dta_index_BuyDocument_5_1675153013__K19_K34_38")]
    [Index(nameof(DocType), nameof(PrjMarketId), Name = "_dta_index_BuyDocument_5_1675153013__K19_K34_44")]
    [Index(nameof(DocType), nameof(PrjMarketId), Name = "_dta_index_BuyDocument_5_1675153013__K19_K34_6")]
    [Index(nameof(DocType), nameof(PrjMarketId), Name = "_dta_index_BuyDocument_5_1675153013__K19_K34_8")]
    [Index(nameof(Pkey), nameof(ComFolderId), nameof(PrjProjectId), nameof(PrjMarketId), nameof(BuyLoanScheduleId), Name = "_dta_index_BuyDocument_5_1675153013__K1_K93_K80_K34_K56_4_31")]
    [Index(nameof(ReferenceType), nameof(PrjMarketId), Name = "_dta_index_BuyDocument_5_1675153013__K33_K34_1_6_8_14_19_36_38_40_42_44")]
    [Index(nameof(PrjMarketId), nameof(DocType), Name = "_dta_index_BuyDocument_5_1675153013__K34_K19_14_33")]
    [Index(nameof(PrjMarketId), nameof(DocType), Name = "_dta_index_BuyDocument_5_1675153013__K34_K19_33")]
    [Index(nameof(PrjMarketId), nameof(DocType), Name = "_dta_index_BuyDocument_5_1675153013__K34_K19_40")]
    [Index(nameof(PrjMarketId), nameof(DocType), Name = "_dta_index_BuyDocument_5_1675153013__K34_K19_42")]
    [Index(nameof(PrjMarketId), nameof(ReferenceType), Name = "_dta_index_BuyDocument_5_1675153013__K34_K33_14_19")]
    [Index(nameof(PrjProjectId), nameof(ComFolderId), nameof(Pkey), Name = "_dta_index_BuyDocument_5_1675153013__K80_K93_K1")]
    [Index(nameof(BuyLoanScheduleId), nameof(Pkey), Name = "_dta_index_BuyDocument_5_935674381__K56_K1")]
    public partial class BuyDocument
    {
        public BuyDocument()
        {
            ActEntries = new HashSet<ActEntry>();
            BuyDocumentDocumentToAttaches = new HashSet<BuyDocumentDocumentToAttach>();
            BuyDocumentLines = new HashSet<BuyDocumentLine>();
            BuyDocumentOrigins = new HashSet<BuyDocumentOrigin>();
            BuyDocumentStatusHistories = new HashSet<BuyDocumentStatusHistory>();
            BuySettlementLines = new HashSet<BuySettlementLine>();
            BuyVentilationCategories = new HashSet<BuyVentilationCategory>();
            BuyVentilationExpenses = new HashSet<BuyVentilationExpense>();
            ComCommissionLines = new HashSet<ComCommissionLine>();
            InverseBuyInvoice = new HashSet<BuyDocument>();
            InverseBuyOrder = new HashSet<BuyDocument>();
            InverseBuyQuote = new HashSet<BuyDocument>();
            InverseInvoiceSource = new HashSet<BuyDocument>();
            PrjWorkingOuts = new HashSet<PrjWorkingOut>();
            StlAccountingEntries = new HashSet<StlAccountingEntry>();
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
        [Column("AmountHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountVat { get; set; }
        [Column("AmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? AmountTtc { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FiscalStamp { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountToPay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MaturityDate { get; set; }
        [StringLength(255)]
        public string DocType { get; set; }
        public Guid? CfgTierId { get; set; }
        public bool? IsSelected { get; set; }
        public Guid? BuyFolderId { get; set; }
        [StringLength(255)]
        public string DocRef { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountRegul { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public bool? IsClosed { get; set; }
        [StringLength(255)]
        public string ReferenceType { get; set; }
        public Guid? PrjMarketId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvanceRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvanceAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WarrantyRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WarrantyAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProportionRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProportionAmount { get; set; }
        [Column("InsuranceDECRatio", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceDecratio { get; set; }
        [Column("InsuranceDECAmount", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceDecamount { get; set; }
        [Column("InsuranceTRCRatio", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceTrcratio { get; set; }
        [Column("InsuranceTRCAmount", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceTrcamount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvanceRest { get; set; }
        [Column("InsuranceDECRest", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceDecrest { get; set; }
        [Column("InsuranceTRCRest", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceTrcrest { get; set; }
        [StringLength(255)]
        public string SupplierDescription { get; set; }
        public bool? CanBePayed { get; set; }
        public int? LinesCount { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PrevisionDeliveryDate { get; set; }
        [StringLength(1000)]
        public string ParentDocuments { get; set; }
        public Guid? BuyLoanId { get; set; }
        public Guid? BuyLoanScheduleId { get; set; }
        [StringLength(255)]
        public string State { get; set; }
        [StringLength(255)]
        public string PersonToContact { get; set; }
        public Guid? StkExpenseId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? AdmModuleId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StockAmountToPay { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WorkingOutAdvanceAmount { get; set; }
        public Guid? PrjMarketOfferId { get; set; }
        public bool? IsRejected { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? RetainedAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProrataRefundAmount { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FluctuationsToPay { get; set; }
        public Guid? PrjProjectId { get; set; }
        public Guid? BuyDocumentStatusId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StatusValidityDate { get; set; }
        public Guid? StrEntityId { get; set; }
        [Column("DefaultRSBasedOnRetainedAmounts")]
        public bool? DefaultRsbasedOnRetainedAmounts { get; set; }
        public Guid? CfgTierTriggerId { get; set; }
        public Guid? InvoiceSourceId { get; set; }
        public Guid? ComFolderId { get; set; }
        public Guid? PrjWorkingOutId { get; set; }
        public Guid? BuyOrderId { get; set; }
        [Column("orderAdvanceRatio", TypeName = "decimal(26, 6)")]
        public decimal? OrderAdvanceRatio { get; set; }
        public Guid? BuyQuoteId { get; set; }
        public Guid? BuyInvoiceId { get; set; }
        [Column("AmountToPay_OLD", TypeName = "decimal(26, 6)")]
        public decimal? AmountToPayOld { get; set; }
        [Column("AmountBeforeRS_OLD", TypeName = "decimal(26, 6)")]
        public decimal? AmountBeforeRsOld { get; set; }
        [Column("AmountRS_OLD", TypeName = "decimal(26, 6)")]
        public decimal? AmountRsOld { get; set; }
        [Column("AmountRSBasedOnAmount_OLD")]
        public bool? AmountRsbasedOnAmountOld { get; set; }
        [Column("RSRatio_OLD", TypeName = "decimal(26, 6)")]
        public decimal? RsratioOld { get; set; }
        public bool? IsFinancialRefund { get; set; }
        public string Notes2 { get; set; }
        public Guid? PrjMarketTypeId { get; set; }
        [StringLength(255)]
        public string OfficeOrderRef { get; set; }
        public bool? IsPropotionCharged { get; set; }
        [Column("StockAmountToPayHT", TypeName = "decimal(26, 6)")]
        public decimal? StockAmountToPayHt { get; set; }
        [Column("FluctuationsToPayHT", TypeName = "decimal(26, 6)")]
        public decimal? FluctuationsToPayHt { get; set; }
        public Guid? BuyConsultationId { get; set; }
        public Guid? BuyConsultationOfferId { get; set; }
        public bool? IsAccounted { get; set; }
        public Guid? StlCurrencyId { get; set; }
        public Guid? BuySelectionId { get; set; }
        public Guid? RntFolderId { get; set; }
        public Guid? SynFolderId { get; set; }
        public Guid? PrjClauseId { get; set; }

        [ForeignKey(nameof(AdmModuleId))]
        [InverseProperty("BuyDocuments")]
        public virtual AdmModule AdmModule { get; set; }
        [ForeignKey(nameof(BuyConsultationId))]
        [InverseProperty("BuyDocuments")]
        public virtual BuyConsultation BuyConsultation { get; set; }
        [ForeignKey(nameof(BuyDocumentStatusId))]
        [InverseProperty("BuyDocuments")]
        public virtual BuyDocumentStatus BuyDocumentStatus { get; set; }
        [ForeignKey(nameof(BuyFolderId))]
        [InverseProperty("BuyDocuments")]
        public virtual BuyFolder BuyFolder { get; set; }
        [ForeignKey(nameof(BuyInvoiceId))]
        [InverseProperty(nameof(BuyDocument.InverseBuyInvoice))]
        public virtual BuyDocument BuyInvoice { get; set; }
        [ForeignKey(nameof(BuyLoanId))]
        [InverseProperty("BuyDocuments")]
        public virtual BuyLoan BuyLoan { get; set; }
        [ForeignKey(nameof(BuyLoanScheduleId))]
        [InverseProperty("BuyDocuments")]
        public virtual BuyLoanSchedule BuyLoanSchedule { get; set; }
        [ForeignKey(nameof(BuyOrderId))]
        [InverseProperty(nameof(BuyDocument.InverseBuyOrder))]
        public virtual BuyDocument BuyOrder { get; set; }
        [ForeignKey(nameof(BuyQuoteId))]
        [InverseProperty(nameof(BuyDocument.InverseBuyQuote))]
        public virtual BuyDocument BuyQuote { get; set; }
        [ForeignKey(nameof(BuySelectionId))]
        [InverseProperty("BuyDocuments")]
        public virtual BuySelection BuySelection { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("BuyDocuments")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("BuyDocumentCfgTiers")]
        public virtual CfgTier CfgTier { get; set; }
        [ForeignKey(nameof(CfgTierTriggerId))]
        [InverseProperty("BuyDocumentCfgTierTriggers")]
        public virtual CfgTier CfgTierTrigger { get; set; }
        [ForeignKey(nameof(ComFolderId))]
        [InverseProperty("BuyDocuments")]
        public virtual ComFolder ComFolder { get; set; }
        [ForeignKey(nameof(InvoiceSourceId))]
        [InverseProperty(nameof(BuyDocument.InverseInvoiceSource))]
        public virtual BuyDocument InvoiceSource { get; set; }
        [ForeignKey(nameof(PrjClauseId))]
        [InverseProperty("BuyDocuments")]
        public virtual PrjClause PrjClause { get; set; }
        [ForeignKey(nameof(PrjMarketId))]
        [InverseProperty("BuyDocuments")]
        public virtual PrjMarket PrjMarket { get; set; }
        [ForeignKey(nameof(PrjMarketOfferId))]
        [InverseProperty("BuyDocuments")]
        public virtual PrjMarketOffer PrjMarketOffer { get; set; }
        [ForeignKey(nameof(PrjMarketTypeId))]
        [InverseProperty("BuyDocuments")]
        public virtual PrjMarketType PrjMarketType { get; set; }
        [ForeignKey(nameof(PrjProjectId))]
        [InverseProperty("BuyDocuments")]
        public virtual PrjProject PrjProject { get; set; }
        [ForeignKey(nameof(PrjWorkingOutId))]
        [InverseProperty("BuyDocuments")]
        public virtual PrjWorkingOut PrjWorkingOut { get; set; }
        [ForeignKey(nameof(RntFolderId))]
        [InverseProperty("BuyDocuments")]
        public virtual RntFolder RntFolder { get; set; }
        [ForeignKey(nameof(StkExpenseId))]
        [InverseProperty("BuyDocuments")]
        public virtual StkExpense StkExpense { get; set; }
        [ForeignKey(nameof(StlCurrencyId))]
        [InverseProperty("BuyDocuments")]
        public virtual StlCurrency StlCurrency { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("BuyDocuments")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(SynFolderId))]
        [InverseProperty("BuyDocuments")]
        public virtual SynFolder SynFolder { get; set; }
        [InverseProperty(nameof(ActEntry.BuyDocument))]
        public virtual ICollection<ActEntry> ActEntries { get; set; }
        [InverseProperty(nameof(BuyDocumentDocumentToAttach.BuyDocument))]
        public virtual ICollection<BuyDocumentDocumentToAttach> BuyDocumentDocumentToAttaches { get; set; }
        [InverseProperty(nameof(BuyDocumentLine.BuyDocument))]
        public virtual ICollection<BuyDocumentLine> BuyDocumentLines { get; set; }
        [InverseProperty(nameof(BuyDocumentOrigin.BuyDocument))]
        public virtual ICollection<BuyDocumentOrigin> BuyDocumentOrigins { get; set; }
        [InverseProperty(nameof(BuyDocumentStatusHistory.BuyDocument))]
        public virtual ICollection<BuyDocumentStatusHistory> BuyDocumentStatusHistories { get; set; }
        [InverseProperty(nameof(BuySettlementLine.BuyDocument))]
        public virtual ICollection<BuySettlementLine> BuySettlementLines { get; set; }
        [InverseProperty(nameof(BuyVentilationCategory.BuyDocument))]
        public virtual ICollection<BuyVentilationCategory> BuyVentilationCategories { get; set; }
        [InverseProperty(nameof(BuyVentilationExpense.BuyDocument))]
        public virtual ICollection<BuyVentilationExpense> BuyVentilationExpenses { get; set; }
        [InverseProperty(nameof(ComCommissionLine.BuyDocument))]
        public virtual ICollection<ComCommissionLine> ComCommissionLines { get; set; }
        [InverseProperty(nameof(BuyDocument.BuyInvoice))]
        public virtual ICollection<BuyDocument> InverseBuyInvoice { get; set; }
        [InverseProperty(nameof(BuyDocument.BuyOrder))]
        public virtual ICollection<BuyDocument> InverseBuyOrder { get; set; }
        [InverseProperty(nameof(BuyDocument.BuyQuote))]
        public virtual ICollection<BuyDocument> InverseBuyQuote { get; set; }
        [InverseProperty(nameof(BuyDocument.InvoiceSource))]
        public virtual ICollection<BuyDocument> InverseInvoiceSource { get; set; }
        [InverseProperty("BuyDocument")]
        public virtual ICollection<PrjWorkingOut> PrjWorkingOuts { get; set; }
        [InverseProperty(nameof(StlAccountingEntry.BuyDocument))]
        public virtual ICollection<StlAccountingEntry> StlAccountingEntries { get; set; }
    }
}

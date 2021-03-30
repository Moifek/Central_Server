using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlSettlement")]
    [Index(nameof(StrEntityId), nameof(Pkey), nameof(AdmModuleId), nameof(TierId), nameof(StlSettlementTypeId), nameof(CfgBankId), nameof(TierPayerId), nameof(CfgCompanyId), nameof(StlCategoryId), Name = "_dta_index_StlSettlement_5_642101328__K71_K1_K33_K16_K13_K12_K47_K32_K28_2_4_5_6_7_31_43_44_45_65")]
    [Index(nameof(TierId), nameof(Pkey), nameof(CfgCompanyId), Name = "_dta_index_StlSettlement_5_706101556__K16_K1_K32_8_43")]
    [Index(nameof(Pkey), Name = "_dta_index_StlSettlement_5_706101556__K1_8_43")]
    [Index(nameof(Pkey), nameof(StlSettlementTypeId), nameof(Status), Name = "_dta_index_StlSettlement_5_706101556__K1_K13_K9_8")]
    [Index(nameof(Pkey), nameof(StlAccountPositionId), Name = "_dta_index_StlSettlement_5_706101556__K1_K38_8")]
    [Index(nameof(Pkey), nameof(BuyLoanScheduleId), Name = "_dta_index_StlSettlement_5_706101556__K1_K48_8_43")]
    [Index(nameof(Pkey), nameof(BuySubLoanId), Name = "_dta_index_StlSettlement_5_706101556__K1_K49_8")]
    [Index(nameof(Pkey), nameof(BuySubLoanId), nameof(BuyLoanScheduleId), Name = "_dta_index_StlSettlement_5_706101556__K1_K49_K48_43")]
    [Index(nameof(Pkey), nameof(StlInternalTransferId), Name = "_dta_index_StlSettlement_5_706101556__K1_K50_8")]
    [Index(nameof(CfgCompanyId), nameof(StlSettlementTypeId), nameof(Pkey), nameof(TierId), Name = "_dta_index_StlSettlement_5_706101556__K32_K13_K1_K16_2_3_4_5_7_8_9_43_44_45_46")]
    [Index(nameof(BuySubLoanId), nameof(BuyLoanScheduleId), nameof(StlAccountPositionId), nameof(StlInternalTransferId), nameof(Pkey), nameof(StlCategoryId), Name = "_dta_index_StlSettlement_5_706101556__K49_K48_K38_K50_K1_K28_8")]
    [Index(nameof(StlSettlementTypeId), nameof(Pkey), nameof(Status), Name = "_dta_index_StlSettlement_7_706101556__K13_K1_K9_8")]
    public partial class StlSettlement
    {
        public StlSettlement()
        {
            ActEntries = new HashSet<ActEntry>();
            BuySettlementLines = new HashSet<BuySettlementLine>();
            ComSettlements = new HashSet<ComSettlement>();
            RntSettlements = new HashSet<RntSettlement>();
            StlAccountingEntries = new HashSet<StlAccountingEntry>();
            StlPaymentAuthorizations = new HashSet<StlPaymentAuthorization>();
            StlSettlementHistories = new HashSet<StlSettlementHistory>();
            StlSlipLines = new HashSet<StlSlipLine>();
            StlTransmissionSheetLines = new HashSet<StlTransmissionSheetLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EcheanceDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SettlementDate { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        public bool? IsCredit { get; set; }
        [StringLength(255)]
        public string Status { get; set; }
        public string Notes { get; set; }
        public Guid? CfgBankId { get; set; }
        public Guid? StlSettlementTypeId { get; set; }
        public Guid? StlAccountId { get; set; }
        public Guid? TierId { get; set; }
        [StringLength(255)]
        public string TierType { get; set; }
        [StringLength(255)]
        public string Category { get; set; }
        public Guid? CategoryId { get; set; }
        public string ItemNumber { get; set; }
        [StringLength(255)]
        public string Group1Label { get; set; }
        [StringLength(255)]
        public string Group2Label { get; set; }
        [StringLength(255)]
        public string Group3Label { get; set; }
        public Guid? StlCategoryId { get; set; }
        public string ItemDescription { get; set; }
        [StringLength(255)]
        public string ReceiptCode { get; set; }
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
        public Guid? StlAccountPositionId { get; set; }
        public Guid? CfgTierOtherId { get; set; }
        public bool? IsDcoumentDeliveredToCenter { get; set; }
        public Guid? CfgLawyerId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveredToCenterDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountBase { get; set; }
        [Column("AmountRS", TypeName = "decimal(26, 6)")]
        public decimal? AmountRs { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? RsRatio { get; set; }
        [Column("RSAmountSettled")]
        public bool? RsamountSettled { get; set; }
        public Guid? TierPayerId { get; set; }
        public Guid? BuyLoanScheduleId { get; set; }
        public Guid? BuySubLoanId { get; set; }
        public Guid? StlInternalTransferId { get; set; }
        [Column("RSSettlementDate", TypeName = "datetime")]
        public DateTime? RssettlementDate { get; set; }
        [Column("RSSheetCode")]
        [StringLength(255)]
        public string RssheetCode { get; set; }
        [StringLength(255)]
        public string PropositionSheetCode { get; set; }
        [StringLength(255)]
        public string SlipCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SlipDate { get; set; }
        public bool? IsAccounted { get; set; }
        public Guid? StlSlipId { get; set; }
        public Guid? StlDepositId { get; set; }
        public Guid? StlCurrencyId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ConvertValue { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountBaseConverted { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountStamp { get; set; }
        public Guid? StlAcountDepositId { get; set; }
        public Guid? StlCurrencyAffectationId { get; set; }
        public int? ConvertUnit { get; set; }
        [Column("BuySettlementId_old")]
        public Guid? BuySettlementIdOld { get; set; }
        public Guid? BuyLoanId { get; set; }
        public Guid? StrEntityId { get; set; }

        [ForeignKey(nameof(AdmModuleId))]
        [InverseProperty("StlSettlements")]
        public virtual AdmModule AdmModule { get; set; }
        [ForeignKey(nameof(BuyLoanId))]
        [InverseProperty("StlSettlements")]
        public virtual BuyLoan BuyLoan { get; set; }
        [ForeignKey(nameof(BuyLoanScheduleId))]
        [InverseProperty("StlSettlements")]
        public virtual BuyLoanSchedule BuyLoanSchedule { get; set; }
        [ForeignKey(nameof(BuySubLoanId))]
        [InverseProperty("StlSettlements")]
        public virtual BuySubLoan BuySubLoan { get; set; }
        [ForeignKey(nameof(CfgBankId))]
        [InverseProperty(nameof(CfgTier.StlSettlementCfgBanks))]
        public virtual CfgTier CfgBank { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("StlSettlements")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgLawyerId))]
        [InverseProperty(nameof(CfgTier.StlSettlementCfgLawyers))]
        public virtual CfgTier CfgLawyer { get; set; }
        [ForeignKey(nameof(CfgTierOtherId))]
        [InverseProperty(nameof(CfgTier.StlSettlementCfgTierOthers))]
        public virtual CfgTier CfgTierOther { get; set; }
        [ForeignKey(nameof(StlAccountId))]
        [InverseProperty("StlSettlements")]
        public virtual StlAccount StlAccount { get; set; }
        [ForeignKey(nameof(StlAccountPositionId))]
        [InverseProperty("StlSettlements")]
        public virtual StlAccountPosition StlAccountPosition { get; set; }
        [ForeignKey(nameof(StlAcountDepositId))]
        [InverseProperty("StlSettlements")]
        public virtual StlAcountDeposit StlAcountDeposit { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("StlSettlements")]
        public virtual StlCategory StlCategory { get; set; }
        [ForeignKey(nameof(StlCurrencyId))]
        [InverseProperty("StlSettlementStlCurrencies")]
        public virtual StlCurrency StlCurrency { get; set; }
        [ForeignKey(nameof(StlCurrencyAffectationId))]
        [InverseProperty("StlSettlementStlCurrencyAffectations")]
        public virtual StlCurrency StlCurrencyAffectation { get; set; }
        [ForeignKey(nameof(StlDepositId))]
        [InverseProperty("StlSettlements")]
        public virtual StlDeposit StlDeposit { get; set; }
        [ForeignKey(nameof(StlInternalTransferId))]
        [InverseProperty("StlSettlements")]
        public virtual StlInternalTransfer StlInternalTransfer { get; set; }
        [ForeignKey(nameof(StlSettlementTypeId))]
        [InverseProperty("StlSettlements")]
        public virtual StlSettlementType StlSettlementType { get; set; }
        [ForeignKey(nameof(StlSlipId))]
        [InverseProperty("StlSettlements")]
        public virtual StlSlip StlSlip { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("StlSettlements")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(TierId))]
        [InverseProperty(nameof(CfgTier.StlSettlementTiers))]
        public virtual CfgTier Tier { get; set; }
        [ForeignKey(nameof(TierPayerId))]
        [InverseProperty(nameof(CfgTier.StlSettlementTierPayers))]
        public virtual CfgTier TierPayer { get; set; }
        [InverseProperty(nameof(ActEntry.StlSettlement))]
        public virtual ICollection<ActEntry> ActEntries { get; set; }
        [InverseProperty(nameof(BuySettlementLine.StlSettlement))]
        public virtual ICollection<BuySettlementLine> BuySettlementLines { get; set; }
        [InverseProperty(nameof(ComSettlement.StlSettlement))]
        public virtual ICollection<ComSettlement> ComSettlements { get; set; }
        [InverseProperty(nameof(RntSettlement.StlSettlement))]
        public virtual ICollection<RntSettlement> RntSettlements { get; set; }
        [InverseProperty(nameof(StlAccountingEntry.StlSettlement))]
        public virtual ICollection<StlAccountingEntry> StlAccountingEntries { get; set; }
        [InverseProperty(nameof(StlPaymentAuthorization.StlSettlement))]
        public virtual ICollection<StlPaymentAuthorization> StlPaymentAuthorizations { get; set; }
        [InverseProperty(nameof(StlSettlementHistory.StlSettlement))]
        public virtual ICollection<StlSettlementHistory> StlSettlementHistories { get; set; }
        [InverseProperty(nameof(StlSlipLine.StlSettlement))]
        public virtual ICollection<StlSlipLine> StlSlipLines { get; set; }
        [InverseProperty(nameof(StlTransmissionSheetLine.StlSettlement))]
        public virtual ICollection<StlTransmissionSheetLine> StlTransmissionSheetLines { get; set; }
    }
}

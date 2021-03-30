using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlSettlementView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool? IsCredit { get; set; }
        [Required]
        [StringLength(255)]
        public string Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EcheanceDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SettlementDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? MotionOriginDate { get; set; }
        public bool? MotionReported { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? MotionDate { get; set; }
        [Column("MotionMONTH")]
        public int? MotionMonth { get; set; }
        [Column("MotionYEAR")]
        public int? MotionYear { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? AccountingDate { get; set; }
        public bool? IsAccounted { get; set; }
        public bool? IsDcoumentDeliveredToCenter { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveredToCenterDate { get; set; }
        public string Notes { get; set; }
        [StringLength(255)]
        public string ReceiptCode { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountBase { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? RestAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? RsRatio { get; set; }
        [Column("AmountRS", TypeName = "decimal(26, 6)")]
        public decimal? AmountRs { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountStamp { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        public Guid? StlCurrencyId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlCurrencyCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlCurrencyDescription { get; set; }
        [Column("RSAmountSettled")]
        public bool? RsamountSettled { get; set; }
        [Column("RSSettlementDate", TypeName = "datetime")]
        public DateTime? RssettlementDate { get; set; }
        [Column("RSSheetCode")]
        [StringLength(255)]
        public string RssheetCode { get; set; }
        public Guid? StlSlipId { get; set; }
        [StringLength(255)]
        public string SlipCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SlipDate { get; set; }
        [StringLength(255)]
        public string PropositionSheetCode { get; set; }
        public Guid? AdmModuleId { get; set; }
        [StringLength(255)]
        public string AdmModuleCode { get; set; }
        [StringLength(255)]
        public string AdmModuleDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? TierId { get; set; }
        [StringLength(255)]
        public string CfgTierCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? TierPayerId { get; set; }
        [StringLength(255)]
        public string CfgPayerCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgPayerDescription { get; set; }
        public Guid? CfgTierOtherId { get; set; }
        [StringLength(255)]
        public string CfgTierOtherDescription { get; set; }
        [StringLength(255)]
        public string CfgTierOtherTitle { get; set; }
        public Guid? CfgLawyerId { get; set; }
        [StringLength(255)]
        public string CfgLawyerDescription { get; set; }
        [StringLength(255)]
        public string CfgLawyerTitle { get; set; }
        public Guid? StlSettlementTypeId { get; set; }
        [StringLength(255)]
        public string StlSettlementTypeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlSettlementTypeDescription { get; set; }
        public bool IsNotContabilized { get; set; }
        public bool StlSettlementTypeIsDeposit { get; set; }
        public bool StlSettlementTypeIsAccount { get; set; }
        public Guid? StlAccountId { get; set; }
        [StringLength(255)]
        public string StlAccountCode { get; set; }
        [StringLength(255)]
        public string StlAccountDescription { get; set; }
        public Guid? StlDepositId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlDepositCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlDepositDescription { get; set; }
        public Guid? CfgBankId { get; set; }
        [StringLength(255)]
        public string CfgBankCode { get; set; }
        [StringLength(255)]
        public string CfgBankDescription { get; set; }
        [StringLength(255)]
        public string TierType { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? ComSettlementId { get; set; }
        public Guid? RntSettlementId { get; set; }
        public Guid BuySettlementId { get; set; }
        public Guid? StlInternalTransferId { get; set; }
        public Guid? StlAccountPositionId { get; set; }
        public string ItemDescription { get; set; }
        public string StkItemTypeDescription { get; set; }
        public string TrancheDescription { get; set; }
        public string CodeTranche { get; set; }
        public string MarketDescription { get; set; }
        public string ProjectDescription { get; set; }
        public string CategoryDescription { get; set; }
        public string PrjProjectIds { get; set; }
        [StringLength(255)]
        public string TresoGroupping { get; set; }
        public Guid ObjectId { get; set; }
        [StringLength(255)]
        public string ObjectNameSpace { get; set; }
        [Required]
        [StringLength(12)]
        public string ObjectDescription { get; set; }
        public Guid? StrEntityId { get; set; }
    }
}

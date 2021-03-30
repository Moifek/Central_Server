using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class RntSettlementView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid StlSettlementId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? MotionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EcheanceDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SettlementDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveredToCenterDate { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool? IsCredit { get; set; }
        [StringLength(255)]
        public string Status { get; set; }
        public string Notes { get; set; }
        [StringLength(255)]
        public string ReceiptCode { get; set; }
        public bool? IsDcoumentDeliveredToCenter { get; set; }
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
        public string RntSettlementCategoryDescription { get; set; }
        public string StlInvoiceCode { get; set; }
        public string StkItemCode { get; set; }
        public string StkItemDescription { get; set; }
        public string CfgTrancheCode { get; set; }
        public string CfgTrancheDescription { get; set; }
        public string CfgProjectCode { get; set; }
        public string CfgProjectDescription { get; set; }
        public string FolderCode { get; set; }
        public int? AffectCount { get; set; }
        public Guid? StlSettlementTypeId { get; set; }
        [StringLength(255)]
        public string StlSettlementTypeCode { get; set; }
        [StringLength(255)]
        public string StlSettlementTypeDescription { get; set; }
        public bool? IsNotContabilized { get; set; }
        public bool? StlSettlementTypeIsDeposit { get; set; }
        public bool? StlSettlementTypeIsAccount { get; set; }
        public Guid? CfgBankId { get; set; }
        [StringLength(255)]
        public string CfgBankCode { get; set; }
        [StringLength(255)]
        public string CfgBankDescription { get; set; }
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
        public Guid? TierId { get; set; }
        [StringLength(255)]
        public string TierType { get; set; }
        [StringLength(255)]
        public string CfgTierCode { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? CfgTierPayerId { get; set; }
        [StringLength(255)]
        public string CfgTierPayerCode { get; set; }
        [StringLength(255)]
        public string CfgTierPayerDescription { get; set; }
        public Guid? CfgTierOtherId { get; set; }
        [StringLength(255)]
        public string CfgTierOtherCode { get; set; }
        [StringLength(255)]
        public string CfgTierOtherDescription { get; set; }
        public Guid? CfgTierLawyerId { get; set; }
        [StringLength(255)]
        public string CfgTierLawyerCode { get; set; }
        [StringLength(255)]
        public string CfgTierLawyerDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? AdmModuleId { get; set; }
        [StringLength(255)]
        public string AdmModuleCode { get; set; }
        [StringLength(255)]
        public string AdmModuleDescription { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
    }
}

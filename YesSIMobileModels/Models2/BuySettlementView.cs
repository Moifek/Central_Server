using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class BuySettlementView
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
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public bool? IsCredit { get; set; }
        [StringLength(255)]
        public string Status { get; set; }
        public string Notes { get; set; }
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
        public Guid? StlSettlementTypeId { get; set; }
        [StringLength(255)]
        public string StlSettlementTypeCode { get; set; }
        [StringLength(255)]
        public string StlSettlementTypeDescription { get; set; }
        public bool? StlSettlementTypeIsDeposit { get; set; }
        public bool? StlSettlementTypeIsAccount { get; set; }
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
        public Guid? TierId { get; set; }
        [StringLength(255)]
        public string CfgTierCode { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
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
        [Required]
        public string CategoryDescription { get; set; }
        [Required]
        public string DocumentDescription { get; set; }
        [Required]
        public string MarketDescription { get; set; }
        [Required]
        public string ProjectDescription { get; set; }
        [StringLength(255)]
        public string TierType { get; set; }
        [StringLength(255)]
        public string ReceiptCode { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public int? AffectCount { get; set; }
        public Guid ObjectId { get; set; }
        [StringLength(255)]
        public string ObjectNameSpace { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? StlCurrencyId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlCurrencyCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlCurrencyDescription { get; set; }
    }
}

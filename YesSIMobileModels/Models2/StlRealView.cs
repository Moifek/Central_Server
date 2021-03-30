using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlRealView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StlSettlementViewDocDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? OriginDate { get; set; }
        public bool? Reported { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DocDate { get; set; }
        [Column("MONTH")]
        public int? Month { get; set; }
        [Column("YEAR")]
        public int? Year { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountBase { get; set; }
        [Column("AmountRS", TypeName = "decimal(26, 6)")]
        public decimal? AmountRs { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? RsRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? RestAmount { get; set; }
        public bool? IsCredit { get; set; }
        [StringLength(770)]
        public string Description { get; set; }
        [Required]
        [StringLength(255)]
        public string StlSettlementTypeDescription { get; set; }
        [Required]
        [StringLength(255)]
        public string Groupping { get; set; }
        [Column("CfgCompanyPKey")]
        public Guid? CfgCompanyPkey { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? CfgTierId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? ObjectId { get; set; }
        [StringLength(255)]
        public string ObjectNameSpace { get; set; }
        [Required]
        [StringLength(255)]
        public string SocialReason { get; set; }
        public string StlSettlementItemDescription { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? SettlementDate { get; set; }
        public Guid? StlSettlementTypeId { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [Column("RSAmountSettled")]
        public bool? RsamountSettled { get; set; }
        [Required]
        [StringLength(255)]
        public string Status { get; set; }
        public Guid? StlAccountId { get; set; }
        [StringLength(255)]
        public string StlAccountCode { get; set; }
        [StringLength(255)]
        public string StlAccountDescription { get; set; }
        public Guid? ComSettlementId { get; set; }
        public Guid? RntSettlementId { get; set; }
        public Guid? BuySettlementId { get; set; }
        public string ItemDescription { get; set; }
        public string TrancheDescription { get; set; }
        public string MarketDescription { get; set; }
        public string PrjProjectIds { get; set; }
        public string ProjectDescription { get; set; }
        public string CategoryDescription { get; set; }
        public Guid? BuyLoanId { get; set; }
        public string TresoGroupping2 { get; set; }
        public string TresoGroupping1 { get; set; }
        [StringLength(255)]
        public string TresoGroupping { get; set; }
    }
}

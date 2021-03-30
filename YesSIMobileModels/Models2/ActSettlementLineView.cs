using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class ActSettlementLineView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? Amount { get; set; }
        public Guid? ActTierId { get; set; }
        [StringLength(255)]
        public string ActTierCode { get; set; }
        [StringLength(255)]
        public string ActTierDescription { get; set; }
        public Guid? ActAccountId { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountCode { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountDescription { get; set; }
        public bool ActAccountIsTierAccountMandatory { get; set; }
        public Guid? ActAccountForPaymentId { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountForPaymentCode { get; set; }
        [Required]
        [StringLength(255)]
        public string ActAccountForPaymentDescription { get; set; }
        public bool ActAccountForPaymentIsTierAccountMandatory { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? StlSettlementId { get; set; }
        public bool? IsAccounted { get; set; }
        public bool? RelationIsAccounted { get; set; }
        public bool? IsExpense { get; set; }
        public bool? IsInvoice { get; set; }
        public bool? IsClient { get; set; }
        [Column(TypeName = "decimal(36, 16)")]
        public decimal? VatRatio { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? CfgProjectId { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [StringLength(255)]
        public string ActDefaultAccountCode { get; set; }
        public Guid? StlCurrencyId { get; set; }
        public Guid? CfgTierId { get; set; }
        public Guid? ComFolderId { get; set; }
        public Guid? RntFolderId { get; set; }
        public Guid? SynFolderId { get; set; }
        public Guid? StlCategoryId { get; set; }
    }
}

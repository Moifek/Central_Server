using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlAccountingEntry")]
    public partial class StlAccountingEntry
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(255)]
        public string DocNumber { get; set; }
        [StringLength(255)]
        public string DocNumberRef { get; set; }
        [StringLength(255)]
        public string DocLabel { get; set; }
        [StringLength(255)]
        public string CodeCountable { get; set; }
        [StringLength(255)]
        public string CodeCountableCollective { get; set; }
        [StringLength(255)]
        public string CodeCountableJournal { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountCredit { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountDebit { get; set; }
        public Guid CfgCompanyId { get; set; }
        public Guid CfgTierId { get; set; }
        public Guid BuyDocumentId { get; set; }
        public Guid StlDocumentId { get; set; }
        public Guid StlSettlementId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(BuyDocumentId))]
        [InverseProperty("StlAccountingEntries")]
        public virtual BuyDocument BuyDocument { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("StlAccountingEntries")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("StlAccountingEntries")]
        public virtual CfgTier CfgTier { get; set; }
        [ForeignKey(nameof(StlDocumentId))]
        [InverseProperty("StlAccountingEntries")]
        public virtual StlDocument StlDocument { get; set; }
        [ForeignKey(nameof(StlSettlementId))]
        [InverseProperty("StlAccountingEntries")]
        public virtual StlSettlement StlSettlement { get; set; }
    }
}

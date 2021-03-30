using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ActEntryLine")]
    public partial class ActEntryLine
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        public Guid? ActAccountId { get; set; }
        [StringLength(255)]
        public string ActAccountCode { get; set; }
        [StringLength(255)]
        public string ActAccountDescription { get; set; }
        public Guid? CfgTierId { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountDebit { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountCredit { get; set; }
        public Guid? ActEntryId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? RntSettlementLineId { get; set; }
        public Guid? ActTierId { get; set; }
        [StringLength(255)]
        public string ActTierCode { get; set; }
        [StringLength(255)]
        public string ActTierDescription { get; set; }

        [ForeignKey(nameof(ActAccountId))]
        [InverseProperty("ActEntryLines")]
        public virtual ActAccount ActAccount { get; set; }
        [ForeignKey(nameof(ActEntryId))]
        [InverseProperty("ActEntryLines")]
        public virtual ActEntry ActEntry { get; set; }
        [ForeignKey(nameof(ActTierId))]
        [InverseProperty("ActEntryLines")]
        public virtual ActTier ActTier { get; set; }
        [ForeignKey(nameof(RntSettlementLineId))]
        [InverseProperty("ActEntryLines")]
        public virtual RntSettlementLine RntSettlementLine { get; set; }
    }
}

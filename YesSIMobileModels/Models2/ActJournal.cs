using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ActJournal")]
    public partial class ActJournal
    {
        public ActJournal()
        {
            ActDefaultJournals = new HashSet<ActDefaultJournal>();
            ActEntries = new HashSet<ActEntry>();
            CfgTiers = new HashSet<CfgTier>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        public Guid? ActJournalTypeId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? CfgCompanyId { get; set; }

        [ForeignKey(nameof(ActJournalTypeId))]
        [InverseProperty("ActJournals")]
        public virtual ActJournalType ActJournalType { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("ActJournals")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("ActJournals")]
        public virtual StrEntity StrEntity { get; set; }
        [InverseProperty(nameof(ActDefaultJournal.ActJournal))]
        public virtual ICollection<ActDefaultJournal> ActDefaultJournals { get; set; }
        [InverseProperty(nameof(ActEntry.ActJournal))]
        public virtual ICollection<ActEntry> ActEntries { get; set; }
        [InverseProperty(nameof(CfgTier.ActJournal))]
        public virtual ICollection<CfgTier> CfgTiers { get; set; }
    }
}

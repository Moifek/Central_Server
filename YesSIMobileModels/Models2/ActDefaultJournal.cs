using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ActDefaultJournal")]
    public partial class ActDefaultJournal
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        public Guid? ActJournalId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? StlAccountId { get; set; }
        public bool? IsSystem { get; set; }

        [ForeignKey(nameof(ActJournalId))]
        [InverseProperty("ActDefaultJournals")]
        public virtual ActJournal ActJournal { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("ActDefaultJournals")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(StlAccountId))]
        [InverseProperty("ActDefaultJournals")]
        public virtual StlAccount StlAccount { get; set; }
    }
}

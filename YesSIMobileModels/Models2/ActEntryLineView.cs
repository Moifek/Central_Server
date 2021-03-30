using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class ActEntryLineView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        public Guid? ActAccountId { get; set; }
        [StringLength(255)]
        public string ActAccountCode { get; set; }
        [StringLength(255)]
        public string ActAccountDescription { get; set; }
        public bool ActAccountIsTierAccountMandatory { get; set; }
        public Guid? ActTierId { get; set; }
        [StringLength(255)]
        public string ActTierCode { get; set; }
        [StringLength(255)]
        public string ActTierDescription { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountDebit { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountCredit { get; set; }
        public Guid? ActEntryId { get; set; }
        [StringLength(255)]
        public string ActEntryCode { get; set; }
        [StringLength(255)]
        public string ActEntryDocCode { get; set; }
        [StringLength(255)]
        public string ActEntryDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(500)]
        public string ActEntryNotes { get; set; }
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
        public Guid? ActJournalId { get; set; }
        [StringLength(255)]
        public string ActJournalCode { get; set; }
        [StringLength(255)]
        public string ActJournalDescription { get; set; }
        public Guid? RelationId { get; set; }
        [StringLength(255)]
        public string RelationDescription { get; set; }
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

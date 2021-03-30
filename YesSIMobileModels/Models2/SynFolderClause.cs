using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("SynFolderClause")]
    public partial class SynFolderClause
    {
        public SynFolderClause()
        {
            SynFolderClauseLines = new HashSet<SynFolderClauseLine>();
            SynFolderClauseRntDocuments = new HashSet<SynFolderClauseRntDocument>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string Usage { get; set; }
        public int? PeriodicityNumber { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PeriodicityReconductionRatio { get; set; }
        public int? PeriodicityReconductionFrequency { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        public Guid? SynFolderId { get; set; }
        public Guid? RntPeriodicityId { get; set; }
        public Guid? RntReconductionTypeId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EffectiveDate { get; set; }
        public bool? IsValidated { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NextAugmentationDate { get; set; }

        [ForeignKey(nameof(SynFolderId))]
        [InverseProperty("SynFolderClauses")]
        public virtual SynFolder SynFolder { get; set; }
        [InverseProperty(nameof(SynFolderClauseLine.SynFolderClause))]
        public virtual ICollection<SynFolderClauseLine> SynFolderClauseLines { get; set; }
        [InverseProperty(nameof(SynFolderClauseRntDocument.SynFolderClause))]
        public virtual ICollection<SynFolderClauseRntDocument> SynFolderClauseRntDocuments { get; set; }
    }
}

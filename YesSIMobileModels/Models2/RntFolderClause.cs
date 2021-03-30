using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("RntFolderClause")]
    public partial class RntFolderClause
    {
        public RntFolderClause()
        {
            RntFolderClauseLines = new HashSet<RntFolderClauseLine>();
            RntFolderClauseRntDocuments = new HashSet<RntFolderClauseRntDocument>();
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
        public Guid? RntFolderId { get; set; }
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

        [ForeignKey(nameof(RntFolderId))]
        [InverseProperty("RntFolderClauses")]
        public virtual RntFolder RntFolder { get; set; }
        [InverseProperty(nameof(RntFolderClauseLine.RntFolderClause))]
        public virtual ICollection<RntFolderClauseLine> RntFolderClauseLines { get; set; }
        [InverseProperty(nameof(RntFolderClauseRntDocument.RntFolderClause))]
        public virtual ICollection<RntFolderClauseRntDocument> RntFolderClauseRntDocuments { get; set; }
    }
}

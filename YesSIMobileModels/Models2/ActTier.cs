using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ActTier")]
    public partial class ActTier
    {
        public ActTier()
        {
            ActEntryLines = new HashSet<ActEntryLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? CfgTierId { get; set; }
        public Guid? ComFolderId { get; set; }
        public Guid? RntFolderId { get; set; }
        public Guid? SynFolderId { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("ActTiers")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("ActTiers")]
        public virtual CfgTier CfgTier { get; set; }
        [ForeignKey(nameof(ComFolderId))]
        [InverseProperty("ActTiers")]
        public virtual ComFolder ComFolder { get; set; }
        [ForeignKey(nameof(RntFolderId))]
        [InverseProperty("ActTiers")]
        public virtual RntFolder RntFolder { get; set; }
        [ForeignKey(nameof(SynFolderId))]
        [InverseProperty("ActTiers")]
        public virtual SynFolder SynFolder { get; set; }
        [InverseProperty(nameof(ActEntryLine.ActTier))]
        public virtual ICollection<ActEntryLine> ActEntryLines { get; set; }
    }
}

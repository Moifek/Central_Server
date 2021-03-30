using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class ActTierView1
    {
        [Column("PKey")]
        public Guid? Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? CfgTierId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [Required]
        [StringLength(1000)]
        public string CfgCompanyDescription { get; set; }
        public Guid? ComFolderId { get; set; }
        [Required]
        [StringLength(255)]
        public string ComFolderCode { get; set; }
        [Required]
        [StringLength(255)]
        public string ComFolderDescription { get; set; }
        public Guid? RntFolderId { get; set; }
        [Required]
        [StringLength(255)]
        public string RntFolderCode { get; set; }
        [Required]
        [StringLength(255)]
        public string RntFolderDescription { get; set; }
        public Guid? SynFolderId { get; set; }
        [Required]
        [StringLength(255)]
        public string SynFolderCode { get; set; }
        [Required]
        [StringLength(255)]
        public string SynFolderDescription { get; set; }
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
        public bool? IsSaved { get; set; }
    }
}

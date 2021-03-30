using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class PrjProjectView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(500)]
        public string DescriptionLong { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public bool? IsVentilated { get; set; }
        [Column("IsACommon")]
        public bool? IsAcommon { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DefaultVentilationRate { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? CfgTierManagerId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierManagerCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierManagerDescription { get; set; }
        public Guid? StkLevelingId { get; set; }
        [Required]
        [StringLength(255)]
        public string StkLevelingCode { get; set; }
        public Guid? ReferenceId { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjProjectReferenceCode { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjProjectReferenceDescription { get; set; }
        public string CfgTranches { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
    }
}

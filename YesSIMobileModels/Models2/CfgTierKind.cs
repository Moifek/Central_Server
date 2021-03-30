using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("CfgTierKind")]
    public partial class CfgTierKind
    {
        public CfgTierKind()
        {
            CfgTiers = new HashSet<CfgTier>();
            GrhEmployeeHistories = new HashSet<GrhEmployeeHistory>();
            GrhPaySlips = new HashSet<GrhPaySlip>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? CfgTierTypeId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? CfgCompanyId { get; set; }

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("CfgTierKinds")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgTierTypeId))]
        [InverseProperty("CfgTierKinds")]
        public virtual CfgTierType CfgTierType { get; set; }
        [InverseProperty(nameof(CfgTier.CfgTierKind))]
        public virtual ICollection<CfgTier> CfgTiers { get; set; }
        [InverseProperty(nameof(GrhEmployeeHistory.GrhEmployeeKind))]
        public virtual ICollection<GrhEmployeeHistory> GrhEmployeeHistories { get; set; }
        [InverseProperty(nameof(GrhPaySlip.GrhEmployeeKind))]
        public virtual ICollection<GrhPaySlip> GrhPaySlips { get; set; }
    }
}

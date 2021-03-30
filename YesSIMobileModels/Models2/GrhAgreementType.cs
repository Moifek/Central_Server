using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("GrhAgreementType")]
    public partial class GrhAgreementType
    {
        public GrhAgreementType()
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

        [InverseProperty(nameof(CfgTier.GrhAgreementType))]
        public virtual ICollection<CfgTier> CfgTiers { get; set; }
        [InverseProperty(nameof(GrhEmployeeHistory.GrhAgreementType))]
        public virtual ICollection<GrhEmployeeHistory> GrhEmployeeHistories { get; set; }
        [InverseProperty(nameof(GrhPaySlip.GrhAgreementType))]
        public virtual ICollection<GrhPaySlip> GrhPaySlips { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmMatrimonialRegime")]
    public partial class AdmMatrimonialRegime
    {
        public AdmMatrimonialRegime()
        {
            CfgTiers = new HashSet<CfgTier>();
            GrhEmployeeHistories = new HashSet<GrhEmployeeHistory>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [InverseProperty(nameof(CfgTier.AdmMatrimonialRegime))]
        public virtual ICollection<CfgTier> CfgTiers { get; set; }
        [InverseProperty(nameof(GrhEmployeeHistory.AdmMatrimonialRegime))]
        public virtual ICollection<GrhEmployeeHistory> GrhEmployeeHistories { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("AdmRank")]
    public partial class AdmRank
    {
        public AdmRank()
        {
            CfgTiers = new HashSet<CfgTier>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Rank { get; set; }
        [StringLength(255)]
        public string Code { get; set; }

        [InverseProperty(nameof(CfgTier.AdmRank))]
        public virtual ICollection<CfgTier> CfgTiers { get; set; }
    }
}

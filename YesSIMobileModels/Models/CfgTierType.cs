using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models
{
    [Table("CfgTierType")]
    public partial class CfgTierType
    {
        public CfgTierType()
        {
            CfgTiers = new HashSet<CfgTier>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Description { get; set; }

        [InverseProperty(nameof(CfgTier.CfgTierType))]
        public virtual ICollection<CfgTier> CfgTiers { get; set; }
    }
}

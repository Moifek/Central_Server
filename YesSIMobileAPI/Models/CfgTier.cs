using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileAPI.Models
{
    [Table("CfgTier")]
    public partial class CfgTier
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string UrlServer { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string Mobile { get; set; }
        public Guid? CfgTierTypeId { get; set; }

        [ForeignKey(nameof(CfgTierTypeId))]
        [InverseProperty("CfgTiers")]
        public virtual CfgTierType CfgTierType { get; set; }
    }
}

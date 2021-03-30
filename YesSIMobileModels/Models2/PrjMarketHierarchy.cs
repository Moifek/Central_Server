using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketHierarchy")]
    public partial class PrjMarketHierarchy
    {
        public PrjMarketHierarchy()
        {
            PrjMarketViewHierarchies = new HashSet<PrjMarketViewHierarchy>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid PrjMarketId { get; set; }
        public Guid StkHierarchyId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(PrjMarketId))]
        [InverseProperty("PrjMarketHierarchies")]
        public virtual PrjMarket PrjMarket { get; set; }
        [ForeignKey(nameof(StkHierarchyId))]
        [InverseProperty(nameof(CfgTrancheLevelingDefinition.PrjMarketHierarchies))]
        public virtual CfgTrancheLevelingDefinition StkHierarchy { get; set; }
        [InverseProperty(nameof(PrjMarketViewHierarchy.PrjMarketHierarchy))]
        public virtual ICollection<PrjMarketViewHierarchy> PrjMarketViewHierarchies { get; set; }
    }
}

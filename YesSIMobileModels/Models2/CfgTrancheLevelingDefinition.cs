using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("CfgTrancheLevelingDefinition")]
    public partial class CfgTrancheLevelingDefinition
    {
        public CfgTrancheLevelingDefinition()
        {
            BulMeetingPrjProjectProgressCriteriaLines = new HashSet<BulMeetingPrjProjectProgressCriteriaLine>();
            GrhWorkedDays = new HashSet<GrhWorkedDay>();
            InverseParent = new HashSet<CfgTrancheLevelingDefinition>();
            PrjMarketHierarchies = new HashSet<PrjMarketHierarchy>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? ParentId { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        public int? Sorting { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(CfgTrancheId))]
        [InverseProperty(nameof(PrjProject.CfgTrancheLevelingDefinitions))]
        public virtual PrjProject CfgTranche { get; set; }
        [ForeignKey(nameof(ParentId))]
        [InverseProperty(nameof(CfgTrancheLevelingDefinition.InverseParent))]
        public virtual CfgTrancheLevelingDefinition Parent { get; set; }
        [InverseProperty(nameof(BulMeetingPrjProjectProgressCriteriaLine.CfgTrancheLevelingdefinition))]
        public virtual ICollection<BulMeetingPrjProjectProgressCriteriaLine> BulMeetingPrjProjectProgressCriteriaLines { get; set; }
        [InverseProperty(nameof(GrhWorkedDay.CfgTrancheLevelingDefinition))]
        public virtual ICollection<GrhWorkedDay> GrhWorkedDays { get; set; }
        [InverseProperty(nameof(CfgTrancheLevelingDefinition.Parent))]
        public virtual ICollection<CfgTrancheLevelingDefinition> InverseParent { get; set; }
        [InverseProperty(nameof(PrjMarketHierarchy.StkHierarchy))]
        public virtual ICollection<PrjMarketHierarchy> PrjMarketHierarchies { get; set; }
    }
}

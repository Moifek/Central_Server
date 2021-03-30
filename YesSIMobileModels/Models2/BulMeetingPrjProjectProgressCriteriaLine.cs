using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BulMeetingPrjProjectProgressCriteriaLine")]
    public partial class BulMeetingPrjProjectProgressCriteriaLine
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Achievement { get; set; }
        public Guid? BulMeetingId { get; set; }
        public Guid? PrjProjectProgressCriteriaLineId { get; set; }
        public Guid? CfgTrancheLevelingdefinitionId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(BulMeetingId))]
        [InverseProperty("BulMeetingPrjProjectProgressCriteriaLines")]
        public virtual BulMeeting BulMeeting { get; set; }
        [ForeignKey(nameof(CfgTrancheLevelingdefinitionId))]
        [InverseProperty(nameof(CfgTrancheLevelingDefinition.BulMeetingPrjProjectProgressCriteriaLines))]
        public virtual CfgTrancheLevelingDefinition CfgTrancheLevelingdefinition { get; set; }
        [ForeignKey(nameof(PrjProjectProgressCriteriaLineId))]
        [InverseProperty("BulMeetingPrjProjectProgressCriteriaLines")]
        public virtual PrjProjectProgressCriteriaLine PrjProjectProgressCriteriaLine { get; set; }
    }
}

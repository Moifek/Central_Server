using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjProjectProgressCriteriaLine")]
    public partial class PrjProjectProgressCriteriaLine
    {
        public PrjProjectProgressCriteriaLine()
        {
            BulMeetingPrjProjectProgressCriteriaLines = new HashSet<BulMeetingPrjProjectProgressCriteriaLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? StlCategoryId { get; set; }
        public Guid? PrjProjectId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(PrjProjectId))]
        [InverseProperty("PrjProjectProgressCriteriaLines")]
        public virtual PrjProject PrjProject { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("PrjProjectProgressCriteriaLines")]
        public virtual StlCategory StlCategory { get; set; }
        [InverseProperty(nameof(BulMeetingPrjProjectProgressCriteriaLine.PrjProjectProgressCriteriaLine))]
        public virtual ICollection<BulMeetingPrjProjectProgressCriteriaLine> BulMeetingPrjProjectProgressCriteriaLines { get; set; }
    }
}

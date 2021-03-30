using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjGanttTask")]
    public partial class PrjGanttTask
    {
        [Key]
        public Guid Pkey { get; set; }
        [Column("TaskGUID")]
        public Guid? TaskGuid { get; set; }
        public Guid? ParentId { get; set; }
        public int? TaskId { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? VersionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        public int? Delay { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PercentComplete { get; set; }
        public int? Level { get; set; }
        public Guid? PrjProjectId { get; set; }

        [ForeignKey(nameof(PrjProjectId))]
        [InverseProperty("PrjGanttTasks")]
        public virtual PrjProject PrjProject { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjProjectAchievementReal")]
    public partial class PrjProjectAchievementReal
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Achievement { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? PrjProjectId { get; set; }

        [ForeignKey(nameof(PrjProjectId))]
        [InverseProperty("PrjProjectAchievementReals")]
        public virtual PrjProject PrjProject { get; set; }
    }
}

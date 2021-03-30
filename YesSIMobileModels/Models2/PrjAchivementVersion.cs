using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjAchivementVersion")]
    public partial class PrjAchivementVersion
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? VersionDate { get; set; }
        [Column(TypeName = "text")]
        public string AchivementDates { get; set; }
        [Column(TypeName = "text")]
        public string AchivementValues { get; set; }
        public Guid? PrjProjectId { get; set; }

        [ForeignKey(nameof(PrjProjectId))]
        [InverseProperty("PrjAchivementVersions")]
        public virtual PrjProject PrjProject { get; set; }
    }
}

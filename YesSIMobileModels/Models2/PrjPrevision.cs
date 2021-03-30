using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjPrevision")]
    public partial class PrjPrevision
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? PrevisionYear { get; set; }
        public int? PrevisionMonth { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PrevisionAmount { get; set; }
        public Guid? PrjProjectId { get; set; }

        [ForeignKey(nameof(PrjProjectId))]
        [InverseProperty("PrjPrevisions")]
        public virtual PrjProject PrjProject { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjWorkingOutLineSubLine")]
    public partial class PrjWorkingOutLineSubLine
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Coefficient { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Quantity { get; set; }
        public Guid? PrjWorkingOutLineId { get; set; }
        public int? Sorting { get; set; }

        [ForeignKey(nameof(PrjWorkingOutLineId))]
        [InverseProperty("PrjWorkingOutLineSubLines")]
        public virtual PrjWorkingOutLine PrjWorkingOutLine { get; set; }
    }
}

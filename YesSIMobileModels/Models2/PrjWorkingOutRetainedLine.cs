using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjWorkingOutRetainedLine")]
    public partial class PrjWorkingOutRetainedLine
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid PrjWorkingOutId { get; set; }
        public int? Sorting { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }

        [ForeignKey(nameof(PrjWorkingOutId))]
        [InverseProperty("PrjWorkingOutRetainedLines")]
        public virtual PrjWorkingOut PrjWorkingOut { get; set; }
    }
}

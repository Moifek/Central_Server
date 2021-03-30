using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjCoefficientCost")]
    public partial class PrjCoefficientCost
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Coefficient { get; set; }
        public Guid? PrjProjectId { get; set; }
        public Guid? StkCostCategoryId { get; set; }

        [ForeignKey(nameof(PrjProjectId))]
        [InverseProperty("PrjCoefficientCosts")]
        public virtual PrjProject PrjProject { get; set; }
        [ForeignKey(nameof(StkCostCategoryId))]
        [InverseProperty("PrjCoefficientCosts")]
        public virtual StkCostCategory StkCostCategory { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketVentilationCategory")]
    public partial class PrjMarketVentilationCategory
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? StlCategoryId { get; set; }
        public Guid? PrjMarketId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VentilationRate { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(PrjMarketId))]
        [InverseProperty("PrjMarketVentilationCategories")]
        public virtual PrjMarket PrjMarket { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("PrjMarketVentilationCategories")]
        public virtual StlCategory StlCategory { get; set; }
    }
}

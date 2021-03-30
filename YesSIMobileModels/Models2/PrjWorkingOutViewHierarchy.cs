using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjWorkingOutViewHierarchy")]
    public partial class PrjWorkingOutViewHierarchy
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid PrjWorkingOutId { get; set; }
        public Guid PrjMarketViewHierarchyId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvancementQuantity { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvancementRatio { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(PrjMarketViewHierarchyId))]
        [InverseProperty("PrjWorkingOutViewHierarchies")]
        public virtual PrjMarketViewHierarchy PrjMarketViewHierarchy { get; set; }
        [ForeignKey(nameof(PrjWorkingOutId))]
        [InverseProperty("PrjWorkingOutViewHierarchies")]
        public virtual PrjWorkingOut PrjWorkingOut { get; set; }
    }
}

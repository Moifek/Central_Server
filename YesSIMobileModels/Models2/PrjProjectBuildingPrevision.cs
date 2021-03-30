using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjProjectBuildingPrevision")]
    public partial class PrjProjectBuildingPrevision
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? PrjProjectId { get; set; }
        public Guid? GrhWorkedDayTypeId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Quantity { get; set; }
        [Column("UnitPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(GrhWorkedDayTypeId))]
        [InverseProperty("PrjProjectBuildingPrevisions")]
        public virtual GrhWorkedDayType GrhWorkedDayType { get; set; }
        [ForeignKey(nameof(PrjProjectId))]
        [InverseProperty("PrjProjectBuildingPrevisions")]
        public virtual PrjProject PrjProject { get; set; }
    }
}

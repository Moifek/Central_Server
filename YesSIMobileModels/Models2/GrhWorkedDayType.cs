using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("GrhWorkedDayType")]
    public partial class GrhWorkedDayType
    {
        public GrhWorkedDayType()
        {
            GrhWorkedDays = new HashSet<GrhWorkedDay>();
            PrjProjectBuildingPrevisions = new HashSet<PrjProjectBuildingPrevision>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [StringLength(255)]
        public string GroupDescription { get; set; }
        [StringLength(255)]
        public string Unity { get; set; }
        [Column("UnitPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [StringLength(255)]
        public string Unity1 { get; set; }
        [Column("UnitPriceHT1", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceHt1 { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio1 { get; set; }

        [InverseProperty(nameof(GrhWorkedDay.GrhWorkedDayType))]
        public virtual ICollection<GrhWorkedDay> GrhWorkedDays { get; set; }
        [InverseProperty(nameof(PrjProjectBuildingPrevision.GrhWorkedDayType))]
        public virtual ICollection<PrjProjectBuildingPrevision> PrjProjectBuildingPrevisions { get; set; }
    }
}

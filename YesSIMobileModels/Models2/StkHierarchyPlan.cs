using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkHierarchyPlan")]
    public partial class StkHierarchyPlan
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public string PlanImage { get; set; }
        public Guid? StkHierarchyId { get; set; }
        public Guid? StkFloorId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column("width", TypeName = "decimal(26, 6)")]
        public decimal? Width { get; set; }
        [Column("height", TypeName = "decimal(26, 6)")]
        public decimal? Height { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? X { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Y { get; set; }

        [ForeignKey(nameof(StkFloorId))]
        [InverseProperty("StkHierarchyPlans")]
        public virtual StkFloor StkFloor { get; set; }
        [ForeignKey(nameof(StkHierarchyId))]
        [InverseProperty(nameof(CfgTranche.StkHierarchyPlans))]
        public virtual CfgTranche StkHierarchy { get; set; }
    }
}

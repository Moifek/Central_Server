using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkFeasibilityStudyCfgTrancheStkBaseUnit")]
    public partial class StkFeasibilityStudyCfgTrancheStkBaseUnit
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Quantity { get; set; }
        public Guid? FeasibilityStudyId { get; set; }
        public Guid? StkBaseUnitId { get; set; }
        public Guid? StkFeasibilityStudyCfgTrancheId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Weight { get; set; }

        [ForeignKey(nameof(StkBaseUnitId))]
        [InverseProperty(nameof(StkFsbaseUnitStkFeasibilityStudy.StkFeasibilityStudyCfgTrancheStkBaseUnits))]
        public virtual StkFsbaseUnitStkFeasibilityStudy StkBaseUnit { get; set; }
        [ForeignKey(nameof(StkFeasibilityStudyCfgTrancheId))]
        [InverseProperty("StkFeasibilityStudyCfgTrancheStkBaseUnits")]
        public virtual StkFeasibilityStudyCfgTranche StkFeasibilityStudyCfgTranche { get; set; }
    }
}

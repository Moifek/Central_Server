using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkFSBaseUnitStkFeasibilityStudy")]
    public partial class StkFsbaseUnitStkFeasibilityStudy
    {
        public StkFsbaseUnitStkFeasibilityStudy()
        {
            StkFeasibilityStudyCfgTrancheStkBaseUnits = new HashSet<StkFeasibilityStudyCfgTrancheStkBaseUnit>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        public Guid? FeasibilityStudyId { get; set; }
        [Column("StkFSBaseUnitId")]
        public Guid? StkFsbaseUnitId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Quantity { get; set; }

        [ForeignKey(nameof(FeasibilityStudyId))]
        [InverseProperty(nameof(StkFeasibilityStudy.StkFsbaseUnitStkFeasibilityStudies))]
        public virtual StkFeasibilityStudy FeasibilityStudy { get; set; }
        [ForeignKey(nameof(StkFsbaseUnitId))]
        [InverseProperty("StkFsbaseUnitStkFeasibilityStudies")]
        public virtual StkFsbaseUnit StkFsbaseUnit { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudyCfgTrancheStkBaseUnit.StkBaseUnit))]
        public virtual ICollection<StkFeasibilityStudyCfgTrancheStkBaseUnit> StkFeasibilityStudyCfgTrancheStkBaseUnits { get; set; }
    }
}

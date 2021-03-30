using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkFSBaseUnit")]
    public partial class StkFsbaseUnit
    {
        public StkFsbaseUnit()
        {
            StkFsbaseUnitStkFeasibilityStudies = new HashSet<StkFsbaseUnitStkFeasibilityStudy>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? StkItemCategoryId { get; set; }
        public bool? IsArea { get; set; }
        public Guid? SpecificFunctionId { get; set; }

        [ForeignKey(nameof(SpecificFunctionId))]
        [InverseProperty("StkFsbaseUnits")]
        public virtual SpecificFunction SpecificFunction { get; set; }
        [ForeignKey(nameof(StkItemCategoryId))]
        [InverseProperty("StkFsbaseUnits")]
        public virtual StkItemCategory StkItemCategory { get; set; }
        [InverseProperty(nameof(StkFsbaseUnitStkFeasibilityStudy.StkFsbaseUnit))]
        public virtual ICollection<StkFsbaseUnitStkFeasibilityStudy> StkFsbaseUnitStkFeasibilityStudies { get; set; }
    }
}

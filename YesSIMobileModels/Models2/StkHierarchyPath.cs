using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkHierarchyPath")]
    public partial class StkHierarchyPath
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "text")]
        public string SvgPath { get; set; }
        public Guid? StkItemId { get; set; }
        public Guid? StkFloorId { get; set; }

        [ForeignKey(nameof(StkFloorId))]
        [InverseProperty("StkHierarchyPaths")]
        public virtual StkFloor StkFloor { get; set; }
        [ForeignKey(nameof(StkItemId))]
        [InverseProperty("StkHierarchyPaths")]
        public virtual StkItem StkItem { get; set; }
    }
}

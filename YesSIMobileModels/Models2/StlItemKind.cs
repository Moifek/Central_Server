using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlItemKind")]
    public partial class StlItemKind
    {
        public StlItemKind()
        {
            StlItemDefinitions = new HashSet<StlItemDefinition>();
            StlItemGroups = new HashSet<StlItemGroup>();
        }

        [Key]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(500)]
        public string ReportDescription { get; set; }
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

        [InverseProperty(nameof(StlItemDefinition.StlItemKind))]
        public virtual ICollection<StlItemDefinition> StlItemDefinitions { get; set; }
        [InverseProperty(nameof(StlItemGroup.StlItemKind))]
        public virtual ICollection<StlItemGroup> StlItemGroups { get; set; }
    }
}

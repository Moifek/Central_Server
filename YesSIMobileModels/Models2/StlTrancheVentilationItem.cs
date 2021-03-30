using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlTrancheVentilationItem")]
    public partial class StlTrancheVentilationItem
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? StlTrancheVentilationId { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VentilationRate { get; set; }
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

        [ForeignKey(nameof(CfgTrancheId))]
        [InverseProperty("StlTrancheVentilationItems")]
        public virtual CfgTranche CfgTranche { get; set; }
        [ForeignKey(nameof(StlTrancheVentilationId))]
        [InverseProperty("StlTrancheVentilationItems")]
        public virtual StlTrancheVentilation StlTrancheVentilation { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjProjectCfgTrancheVentilation")]
    public partial class PrjProjectCfgTrancheVentilation
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? PrjProjectId { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VentilationRate { get; set; }

        [ForeignKey(nameof(CfgTrancheId))]
        [InverseProperty("PrjProjectCfgTrancheVentilations")]
        public virtual CfgTranche CfgTranche { get; set; }
        [ForeignKey(nameof(PrjProjectId))]
        [InverseProperty("PrjProjectCfgTrancheVentilations")]
        public virtual PrjProject PrjProject { get; set; }
    }
}

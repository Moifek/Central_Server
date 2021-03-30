using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlProjectVentilation")]
    public partial class StlProjectVentilation
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VentilationRate { get; set; }
        public Guid? CfgTrancheId { get; set; }
        public int? PrevisionYear { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? CfgCompanyId { get; set; }

        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("StlProjectVentilations")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgTrancheId))]
        [InverseProperty("StlProjectVentilations")]
        public virtual CfgTranche CfgTranche { get; set; }
    }
}

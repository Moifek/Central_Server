using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlTrancheVentilationView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? VentilationRate { get; set; }
        [Required]
        public string CfgTrancheDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlAccountPositionView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime PositionDate { get; set; }
        public int? PositionYear { get; set; }
        public int? PositionMonth { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PositionCalculated { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal Position { get; set; }
        [Column(TypeName = "decimal(27, 6)")]
        public decimal? PositionDifference { get; set; }
        public Guid StlAccountId { get; set; }
        [StringLength(255)]
        public string StlAccountCode { get; set; }
        [StringLength(255)]
        public string StlAccountDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
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
    }
}

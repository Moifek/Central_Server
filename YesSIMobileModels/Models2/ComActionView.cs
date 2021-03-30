using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class ComActionView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [StringLength(255)]
        public string ColorName { get; set; }
        public bool? IsActive { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Budget { get; set; }
        public bool? CanAddTotalCost { get; set; }
        [Column("isDefault")]
        public bool? IsDefault { get; set; }
        public Guid? BuyFolderId { get; set; }
        [StringLength(255)]
        public string BuyFolderDescription { get; set; }
        public Guid? CfgEmployeeId { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public int? ProspectionCount { get; set; }
        public int? SalesCount { get; set; }
        public int? EffectiveSalesCount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalCost { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column(TypeName = "decimal(37, 19)")]
        public decimal? TransformationRatio { get; set; }
    }
}

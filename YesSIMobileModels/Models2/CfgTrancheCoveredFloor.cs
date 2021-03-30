using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("CfgTrancheCoveredFloor")]
    public partial class CfgTrancheCoveredFloor
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? CfgTrancheId { get; set; }
        public Guid? StkItemCategoryId { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? Area { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(CfgTrancheId))]
        [InverseProperty("CfgTrancheCoveredFloors")]
        public virtual CfgTranche CfgTranche { get; set; }
        [ForeignKey(nameof(StkItemCategoryId))]
        [InverseProperty("CfgTrancheCoveredFloors")]
        public virtual StkItemCategory StkItemCategory { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("CfgTrancheLevel")]
    public partial class CfgTrancheLevel
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? CfgTrancheId { get; set; }
        public Guid? LndLevelId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(CfgTrancheId))]
        [InverseProperty("CfgTrancheLevels")]
        public virtual CfgTranche CfgTranche { get; set; }
        [ForeignKey(nameof(LndLevelId))]
        [InverseProperty("CfgTrancheLevels")]
        public virtual LndLevel LndLevel { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("LndLevel")]
    public partial class LndLevel
    {
        public LndLevel()
        {
            CfgTrancheLevels = new HashSet<CfgTrancheLevel>();
            CfgTranches = new HashSet<CfgTranche>();
            LndLands = new HashSet<LndLand>();
            StkItems = new HashSet<StkItem>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [InverseProperty(nameof(CfgTrancheLevel.LndLevel))]
        public virtual ICollection<CfgTrancheLevel> CfgTrancheLevels { get; set; }
        [InverseProperty(nameof(CfgTranche.LndLevel))]
        public virtual ICollection<CfgTranche> CfgTranches { get; set; }
        [InverseProperty(nameof(LndLand.LndLevel))]
        public virtual ICollection<LndLand> LndLands { get; set; }
        [InverseProperty(nameof(StkItem.LndLevel))]
        public virtual ICollection<StkItem> StkItems { get; set; }
    }
}

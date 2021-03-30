using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("RntSettlement")]
    [Index(nameof(StlSettlementId), Name = "_dta_index_RntSettlement_5_679009500__K3")]
    [Index(nameof(StlSettlementId), nameof(Pkey), Name = "_dta_index_RntSettlement_5_679009500__K3_K1")]
    public partial class RntSettlement
    {
        public RntSettlement()
        {
            RntSettlementLines = new HashSet<RntSettlementLine>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? CfgTierId { get; set; }
        public Guid? StlSettlementId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("RntSettlements")]
        public virtual CfgTier CfgTier { get; set; }
        [ForeignKey(nameof(StlSettlementId))]
        [InverseProperty("RntSettlements")]
        public virtual StlSettlement StlSettlement { get; set; }
        [InverseProperty(nameof(RntSettlementLine.RntSettlement))]
        public virtual ICollection<RntSettlementLine> RntSettlementLines { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComSettlement")]
    [Index(nameof(StlSettlementId), nameof(Pkey), Name = "_dta_index_ComSettlement_5_1620200822__K3_K1")]
    [Index(nameof(StlSettlementId), Name = "_dta_index_ComSettlement_7_1620200822__K3")]
    public partial class ComSettlement
    {
        public ComSettlement()
        {
            ComSettlementDocumentToAttaches = new HashSet<ComSettlementDocumentToAttach>();
            ComSettlementLines = new HashSet<ComSettlementLine>();
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
        [InverseProperty("ComSettlements")]
        public virtual CfgTier CfgTier { get; set; }
        [ForeignKey(nameof(StlSettlementId))]
        [InverseProperty("ComSettlements")]
        public virtual StlSettlement StlSettlement { get; set; }
        [InverseProperty(nameof(ComSettlementDocumentToAttach.ComSettlement))]
        public virtual ICollection<ComSettlementDocumentToAttach> ComSettlementDocumentToAttaches { get; set; }
        [InverseProperty(nameof(ComSettlementLine.ComSettlement))]
        public virtual ICollection<ComSettlementLine> ComSettlementLines { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketReceptionCfgTier")]
    public partial class PrjMarketReceptionCfgTier
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column("sorting")]
        public int? Sorting { get; set; }
        public Guid? PrjMarketReceptionId { get; set; }
        public Guid? CfgTierId { get; set; }

        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("PrjMarketReceptionCfgTiers")]
        public virtual CfgTier CfgTier { get; set; }
        [ForeignKey(nameof(PrjMarketReceptionId))]
        [InverseProperty("PrjMarketReceptionCfgTiers")]
        public virtual PrjMarketReception PrjMarketReception { get; set; }
    }
}

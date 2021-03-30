using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketReception")]
    public partial class PrjMarketReception
    {
        public PrjMarketReception()
        {
            PrjMarketReceptionCfgTiers = new HashSet<PrjMarketReceptionCfgTier>();
            PrjMarketReceptionReserves = new HashSet<PrjMarketReceptionReserve>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column("sorting")]
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(255)]
        public string MeetingPlace { get; set; }
        public bool? RequiredBySupplier { get; set; }
        public Guid? PrjMarketId { get; set; }
        public Guid? PrjMarketReceptionTypeId { get; set; }
        public Guid? PrjMarketReceptionKindId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(PrjMarketId))]
        [InverseProperty("PrjMarketReceptions")]
        public virtual PrjMarket PrjMarket { get; set; }
        [ForeignKey(nameof(PrjMarketReceptionKindId))]
        [InverseProperty("PrjMarketReceptions")]
        public virtual PrjMarketReceptionKind PrjMarketReceptionKind { get; set; }
        [ForeignKey(nameof(PrjMarketReceptionTypeId))]
        [InverseProperty("PrjMarketReceptions")]
        public virtual PrjMarketReceptionType PrjMarketReceptionType { get; set; }
        [InverseProperty(nameof(PrjMarketReceptionCfgTier.PrjMarketReception))]
        public virtual ICollection<PrjMarketReceptionCfgTier> PrjMarketReceptionCfgTiers { get; set; }
        [InverseProperty(nameof(PrjMarketReceptionReserve.PrjMarketReception))]
        public virtual ICollection<PrjMarketReceptionReserve> PrjMarketReceptionReserves { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketStatusHistory")]
    public partial class PrjMarketStatusHistory
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public Guid? PrjMarketStatusId { get; set; }
        public Guid? PrjMarketId { get; set; }
        public Guid? AdmUserId { get; set; }

        [ForeignKey(nameof(AdmUserId))]
        [InverseProperty("PrjMarketStatusHistories")]
        public virtual AdmUser2 AdmUser { get; set; }
        [ForeignKey(nameof(PrjMarketId))]
        [InverseProperty("PrjMarketStatusHistories")]
        public virtual PrjMarket PrjMarket { get; set; }
        [ForeignKey(nameof(PrjMarketStatusId))]
        [InverseProperty("PrjMarketStatusHistories")]
        public virtual PrjMarketStatus PrjMarketStatus { get; set; }
    }
}

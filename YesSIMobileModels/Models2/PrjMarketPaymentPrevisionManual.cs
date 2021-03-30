using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketPaymentPrevisionManual")]
    public partial class PrjMarketPaymentPrevisionManual
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PaymentDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Amount { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? PrjMarketId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Achievement { get; set; }

        [ForeignKey(nameof(PrjMarketId))]
        [InverseProperty("PrjMarketPaymentPrevisionManuals")]
        public virtual PrjMarket PrjMarket { get; set; }
    }
}

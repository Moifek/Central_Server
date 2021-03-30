using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjPrevisionDate")]
    public partial class PrjPrevisionDate
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PrevisionDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PrevisionAmount { get; set; }
        [StringLength(255)]
        public string PrevisionDescription { get; set; }
        public Guid? PrjMarketId { get; set; }

        [ForeignKey(nameof(PrjMarketId))]
        [InverseProperty("PrjPrevisionDates")]
        public virtual PrjMarket PrjMarket { get; set; }
    }
}

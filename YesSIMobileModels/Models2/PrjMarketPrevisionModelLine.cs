using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketPrevisionModelLine")]
    public partial class PrjMarketPrevisionModelLine
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PointTime { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PointAchivement { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PointPayment { get; set; }
        public Guid? PrjMarketPrevisionModelId { get; set; }

        [ForeignKey(nameof(PrjMarketPrevisionModelId))]
        [InverseProperty("PrjMarketPrevisionModelLines")]
        public virtual PrjMarketPrevisionModel PrjMarketPrevisionModel { get; set; }
    }
}

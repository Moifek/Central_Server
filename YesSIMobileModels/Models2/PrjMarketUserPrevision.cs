using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    [Table("PrjMarketUserPrevision")]
    public partial class PrjMarketUserPrevision
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? PointTime { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PointDate { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? PointAchivement { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PointPayment { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PointAmount { get; set; }
        public Guid? PrjMarketId { get; set; }
    }
}

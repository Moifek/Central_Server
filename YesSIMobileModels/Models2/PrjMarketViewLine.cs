using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketViewLine")]
    public partial class PrjMarketViewLine
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid PrjMarketViewId { get; set; }
        public Guid PrjMarketLineId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Percentage { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(PrjMarketLineId))]
        [InverseProperty("PrjMarketViewLines")]
        public virtual PrjMarketLine PrjMarketLine { get; set; }
        [ForeignKey(nameof(PrjMarketViewId))]
        [InverseProperty("PrjMarketViewLines")]
        public virtual PrjMarketView PrjMarketView { get; set; }
    }
}

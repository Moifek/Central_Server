using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("SynPricingItem")]
    public partial class SynPricingItem
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? SynPricingId { get; set; }
        public Guid? StkItemId { get; set; }
        [Column("AmountHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [Column("AmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? AmountTtc { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }

        [ForeignKey(nameof(StkItemId))]
        [InverseProperty("SynPricingItems")]
        public virtual StkItem StkItem { get; set; }
        [ForeignKey(nameof(SynPricingId))]
        [InverseProperty("SynPricingItems")]
        public virtual SynPricing SynPricing { get; set; }
    }
}

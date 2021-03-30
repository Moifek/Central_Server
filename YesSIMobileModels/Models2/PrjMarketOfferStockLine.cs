using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarketOfferStockLine")]
    public partial class PrjMarketOfferStockLine
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column("unity")]
        [StringLength(255)]
        public string Unity { get; set; }
        [Column("quantity", TypeName = "decimal(26, 6)")]
        public decimal? Quantity { get; set; }
        [Column("sorting")]
        public int? Sorting { get; set; }
        public Guid? PrjMarketOfferId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [Column("UnitPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceHt { get; set; }
        [Column("UnitPriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceTtc { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column("FODECRatio", TypeName = "decimal(26, 16)")]
        public decimal? Fodecratio { get; set; }
        [StringLength(2500)]
        public string Notes { get; set; }

        [ForeignKey(nameof(PrjMarketOfferId))]
        [InverseProperty("PrjMarketOfferStockLines")]
        public virtual PrjMarketOffer PrjMarketOffer { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuySelectionLine")]
    public partial class BuySelectionLine
    {
        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(2000)]
        public string Description { get; set; }
        [StringLength(50)]
        public string Unity { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Quantity { get; set; }
        [Column("UnitPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceHt { get; set; }
        [Column("FODECRatio", TypeName = "decimal(26, 16)")]
        public decimal? Fodecratio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [Column("UnitPriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceTtc { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? BuySelectionId { get; set; }
        public Guid? StlCategoryId { get; set; }
        public Guid? BuyItemId { get; set; }
        public Guid? BuySelectionGroupId { get; set; }

        [ForeignKey(nameof(BuyItemId))]
        [InverseProperty("BuySelectionLines")]
        public virtual BuyItem BuyItem { get; set; }
        [ForeignKey(nameof(BuySelectionId))]
        [InverseProperty("BuySelectionLines")]
        public virtual BuySelection BuySelection { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("BuySelectionLines")]
        public virtual StlCategory StlCategory { get; set; }
    }
}

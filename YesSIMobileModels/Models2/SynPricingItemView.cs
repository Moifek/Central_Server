using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class SynPricingItemView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public Guid? SynPricingId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public Guid? CfgTrancheId { get; set; }
        public Guid? StkItemId { get; set; }
        [StringLength(255)]
        public string StkItemCode { get; set; }
        [StringLength(255)]
        public string StkItemDescription { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StkItemArea { get; set; }
        [StringLength(255)]
        public string StkItemCategoryDescription { get; set; }
        [StringLength(255)]
        public string StkItemTypeDescription { get; set; }
        [Column("stkItemIsUnderItem")]
        public bool? StkItemIsUnderItem { get; set; }
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
    }
}

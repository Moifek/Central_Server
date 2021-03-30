using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class BuyCostView
    {
        public Guid? StlCategoryId { get; set; }
        public Guid? ParentId { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [StringLength(255)]
        public string CfgTrancheDescription { get; set; }
        [Required]
        [StringLength(28)]
        public string LineType { get; set; }
        [Column("EstimatedPriceHT", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedPriceHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? EstimatedPriceVat { get; set; }
        [Column("EstimatedPriceTTC", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedPriceTtc { get; set; }
        [Column("OriginalOfferedPriceHT", TypeName = "decimal(38, 6)")]
        public decimal? OriginalOfferedPriceHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OriginalOfferedPriceVat { get; set; }
        [Column("OriginalOfferedPriceTTC", TypeName = "decimal(38, 6)")]
        public decimal? OriginalOfferedPriceTtc { get; set; }
        [Column("OfferedPriceHT", TypeName = "decimal(38, 6)")]
        public decimal? OfferedPriceHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OfferedPriceVat { get; set; }
        [Column("OfferedPriceTTC", TypeName = "decimal(38, 6)")]
        public decimal? OfferedPriceTtc { get; set; }
        [Column("InvoiceAmountHT", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceAmountHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? InvoiceAmountVat { get; set; }
        [Column("InvoiceAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceAmountTtc { get; set; }
    }
}

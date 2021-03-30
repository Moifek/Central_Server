using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class PrjMarketLineView
    {
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
        [Column("UnitPriceHT", TypeName = "decimal(26, 16)")]
        public decimal? UnitPriceHt { get; set; }
        [Column("BaseTotalHT", TypeName = "decimal(38, 7)")]
        public decimal? BaseTotalHt { get; set; }
        [Column("BaseWorkingOutTotalHT", TypeName = "decimal(38, 6)")]
        public decimal BaseWorkingOutTotalHt { get; set; }
        [Column("BaseInvoiceTotalHT", TypeName = "decimal(38, 6)")]
        public decimal BaseInvoiceTotalHt { get; set; }
        [Column("WorkingOutTotalHT", TypeName = "decimal(38, 6)")]
        public decimal WorkingOutTotalHt { get; set; }
        [Column("WorkingOutTotalTTC", TypeName = "decimal(38, 6)")]
        public decimal WorkingOutTotalTtc { get; set; }
        [Column("InvoiceTotalHT", TypeName = "decimal(38, 6)")]
        public decimal InvoiceTotalHt { get; set; }
        [Column("InvoiceTotalTTC", TypeName = "decimal(38, 6)")]
        public decimal InvoiceTotalTtc { get; set; }
        [Column("FODECRatio", TypeName = "decimal(26, 16)")]
        public decimal? Fodecratio { get; set; }
        [Column("UnitPriceHTNet", TypeName = "decimal(38, 16)")]
        public decimal? UnitPriceHtnet { get; set; }
        [Column("TotalHT", TypeName = "decimal(38, 6)")]
        public decimal? TotalHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [Column("TotalVAT", TypeName = "decimal(38, 6)")]
        public decimal? TotalVat { get; set; }
        [Column("UnitPriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceTtc { get; set; }
        [Column("TotalTTC", TypeName = "decimal(38, 6)")]
        public decimal? TotalTtc { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? ParentId { get; set; }
        [StringLength(255)]
        public string ParentCode { get; set; }
        [StringLength(255)]
        public string ParentDescription { get; set; }
        public int? ParentSorting { get; set; }
        public Guid? PrjMarketId { get; set; }
        [StringLength(255)]
        public string PrjMarketCode { get; set; }
        [StringLength(255)]
        public string PrjMarketDescription { get; set; }
        public Guid? PrjProjectId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PrjMarketProportionRatio { get; set; }
        public Guid? StlCategoryId { get; set; }
        [StringLength(255)]
        public string StlCategoryCode { get; set; }
        [StringLength(255)]
        public string StlCategoryDescription { get; set; }
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

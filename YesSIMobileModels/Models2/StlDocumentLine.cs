using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StlDocumentLine")]
    [Index(nameof(StlCategoryId), nameof(StlDocumentId), nameof(RntDocumentId), nameof(Pkey), Name = "_dta_index_StlDocumentLine_5_1504060444__K12_K13_K20_K1_23")]
    [Index(nameof(StlDocumentId), nameof(Pkey), Name = "_dta_index_StlDocumentLine_5_1504060444__K13_K1")]
    [Index(nameof(StlDocumentId), nameof(Pkey), nameof(RntDocumentId), Name = "_dta_index_StlDocumentLine_5_1504060444__K13_K1_K20_23")]
    [Index(nameof(StlDocumentId), nameof(Pkey), nameof(RntDocumentId), nameof(StlCategoryId), Name = "_dta_index_StlDocumentLine_5_1504060444__K13_K1_K20_K12_23")]
    [Index(nameof(StlDocumentId), nameof(Pkey), nameof(StlInvoiceLineId), Name = "_dta_index_StlDocumentLine_5_1504060444__K13_K1_K21")]
    [Index(nameof(StlDocumentId), nameof(Pkey), nameof(StlInvoiceLineId), nameof(TotalTtc), Name = "_dta_index_StlDocumentLine_5_1504060444__K13_K1_K21_K25_20")]
    [Index(nameof(StlDocumentId), nameof(RntDocumentId), nameof(Pkey), nameof(StlCategoryId), nameof(StlInvoiceLineId), Name = "_dta_index_StlDocumentLine_5_1504060444__K13_K20_K1_K12_K21_23_25")]
    [Index(nameof(StlDocumentId), nameof(RntDocumentId), nameof(Pkey), nameof(StlInvoiceLineId), Name = "_dta_index_StlDocumentLine_5_1504060444__K13_K20_K1_K21")]
    [Index(nameof(Pkey), nameof(RntDocumentId), Name = "_dta_index_StlDocumentLine_5_1504060444__K1_K20")]
    [Index(nameof(RntDocumentId), Name = "_dta_index_StlDocumentLine_5_1504060444__K20_13_23")]
    [Index(nameof(RntDocumentId), nameof(Pkey), Name = "_dta_index_StlDocumentLine_5_1504060444__K20_K1")]
    [Index(nameof(RntDocumentId), nameof(StlDocumentId), Name = "_dta_index_StlDocumentLine_5_1504060444__K20_K13")]
    [Index(nameof(RntDocumentId), nameof(StlDocumentId), nameof(Pkey), nameof(StlCategoryId), nameof(StlInvoiceLineId), Name = "_dta_index_StlDocumentLine_5_1504060444__K20_K13_K1_K12_K21_23_25")]
    [Index(nameof(RntDocumentId), nameof(StlDocumentId), nameof(Pkey), nameof(StlInvoiceLineId), Name = "_dta_index_StlDocumentLine_5_1504060444__K20_K13_K1_K21")]
    [Index(nameof(RntDocumentId), nameof(StlInvoiceLineId), Name = "_dta_index_StlDocumentLine_5_1504060444__K20_K21_1_23_25")]
    [Index(nameof(RntDocumentId), nameof(StlInvoiceLineId), Name = "_dta_index_StlDocumentLine_5_1504060444__K20_K21_1_25")]
    [Index(nameof(StlInvoiceLineId), Name = "_dta_index_StlDocumentLine_5_1504060444__K21_23")]
    [Index(nameof(StlInvoiceLineId), Name = "_dta_index_StlDocumentLine_5_1504060444__K21_25")]
    [Index(nameof(StlInvoiceLineId), nameof(RntDocumentId), nameof(StlDocumentId), nameof(Pkey), Name = "_dta_index_StlDocumentLine_5_1504060444__K21_K20_K13_K1")]
    [Index(nameof(StlInvoiceLineId), nameof(TotalTtc), Name = "_dta_index_StlDocumentLine_5_1504060444__K21_K25")]
    [Index(nameof(StlDocumentId), Name = "_dta_index_StlDocumentLine_7_1504060444__K13_1_20")]
    public partial class StlDocumentLine
    {
        public StlDocumentLine()
        {
            InverseStlInvoiceLine = new HashSet<StlDocumentLine>();
        }

        [Key]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(255)]
        public string Unity { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? DiscountRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [Column("FODECRatio", TypeName = "decimal(26, 16)")]
        public decimal? Fodecratio { get; set; }
        [Column("UnitPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceHt { get; set; }
        [Column("UnitPriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceTtc { get; set; }
        public Guid? StlCategoryId { get; set; }
        public Guid? StlDocumentId { get; set; }
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
        public Guid? RntDocumentId { get; set; }
        public Guid? StlInvoiceLineId { get; set; }
        [Column("UnitPriceHTNet", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceHtnet { get; set; }
        [Column("TotalHT", TypeName = "decimal(26, 6)")]
        public decimal? TotalHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TotalVat { get; set; }
        [Column("TotalTTC", TypeName = "decimal(26, 6)")]
        public decimal? TotalTtc { get; set; }
        public Guid? ComDocumentId { get; set; }
        public Guid? ComFolderId { get; set; }
        public Guid? StlItemId { get; set; }

        [ForeignKey(nameof(ComDocumentId))]
        [InverseProperty("StlDocumentLines")]
        public virtual ComDocument ComDocument { get; set; }
        [ForeignKey(nameof(ComFolderId))]
        [InverseProperty("StlDocumentLines")]
        public virtual ComFolder ComFolder { get; set; }
        [ForeignKey(nameof(RntDocumentId))]
        [InverseProperty("StlDocumentLines")]
        public virtual RntDocument RntDocument { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("StlDocumentLines")]
        public virtual StlCategory StlCategory { get; set; }
        [ForeignKey(nameof(StlDocumentId))]
        [InverseProperty("StlDocumentLines")]
        public virtual StlDocument StlDocument { get; set; }
        [ForeignKey(nameof(StlInvoiceLineId))]
        [InverseProperty(nameof(StlDocumentLine.InverseStlInvoiceLine))]
        public virtual StlDocumentLine StlInvoiceLine { get; set; }
        [ForeignKey(nameof(StlItemId))]
        [InverseProperty("StlDocumentLines")]
        public virtual StlItem StlItem { get; set; }
        [InverseProperty(nameof(StlDocumentLine.StlInvoiceLine))]
        public virtual ICollection<StlDocumentLine> InverseStlInvoiceLine { get; set; }
    }
}

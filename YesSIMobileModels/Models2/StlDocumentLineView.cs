using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class StlDocumentLineView
    {
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
        [Column("UnitPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceHt { get; set; }
        [Column(TypeName = "decimal(26, 16)")]
        public decimal? DiscountRatio { get; set; }
        [Column("FODECRatio", TypeName = "decimal(26, 16)")]
        public decimal? Fodecratio { get; set; }
        [Column("UnitPriceHTNet", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceHtnet { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? VatRatio { get; set; }
        [Column("UnitPriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? UnitPriceTtc { get; set; }
        [Column("TotalHT", TypeName = "decimal(26, 6)")]
        public decimal? TotalHt { get; set; }
        [Column("TotalVAT", TypeName = "decimal(26, 6)")]
        public decimal? TotalVat { get; set; }
        [Column("TotalTTC", TypeName = "decimal(26, 6)")]
        public decimal? TotalTtc { get; set; }
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
        public Guid? StlDocumentId { get; set; }
        [StringLength(255)]
        public string StlDocumentCode { get; set; }
        [StringLength(255)]
        public string StlDocumentDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StlDocumentDocDate { get; set; }
        [StringLength(255)]
        public string StlDocumentDocType { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? CfgTierId { get; set; }
        [StringLength(255)]
        public string CfgTierCode { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? StlCategoryId { get; set; }
        [StringLength(255)]
        public string StlCategoryCode { get; set; }
        [StringLength(255)]
        public string StlCategoryDescription { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        public Guid? RntDocumentId { get; set; }
        public Guid? ComDocumentId { get; set; }
        public Guid? StlItemId { get; set; }
        public Guid? StlInvoiceLineId { get; set; }
        public Guid? StlInvoiceId { get; set; }
        [StringLength(255)]
        public string StlInvoiceCode { get; set; }
        [StringLength(255)]
        public string StlInvoiceDescription { get; set; }
        public Guid? ComFolderId { get; set; }
        public Guid? RntFolderId { get; set; }
        public Guid? SynFolderId { get; set; }
        [StringLength(255)]
        public string RntDocumentCode { get; set; }
        [StringLength(500)]
        public string RntDocumentDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PaymentDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        public Guid? RelationId { get; set; }
        [StringLength(255)]
        public string RelationCode { get; set; }
        public Guid? StkItemId { get; set; }
        [StringLength(255)]
        public string StkItemCode { get; set; }
        [StringLength(255)]
        public string StkItemDescription { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [StringLength(255)]
        public string CfgTrancheDescription { get; set; }
        public Guid? CfgProjectId { get; set; }
        [StringLength(255)]
        public string RntPeriodicityCode { get; set; }
        [StringLength(255)]
        public string RntPeriodicityDescription { get; set; }
        public int? RntPeriodicityMonthNumber { get; set; }
        public int? RntPeriodicitySorting { get; set; }
        [StringLength(255)]
        public string RntPeriodicityUnity { get; set; }
        [Column(TypeName = "decimal(37, 17)")]
        public decimal? PeriodUnitPrice { get; set; }
        [StringLength(255)]
        public string RntSettlementCategoryCode { get; set; }
        [StringLength(500)]
        public string RntSettlementCategoryDescription { get; set; }
        [StringLength(500)]
        public string RntSettlementCategoryReportDescription { get; set; }
        public bool? RntSettlementCategoryIsSyndic { get; set; }
        public bool? RntSettlementCategoryIsRent { get; set; }
        [StringLength(255)]
        public string StkItemCategoryCode { get; set; }
        [StringLength(255)]
        public string StkItemCategoryDescription { get; set; }
        [StringLength(500)]
        public string StkItemCategoryReportDescription { get; set; }
        [StringLength(255)]
        public string StkItemTypeCode { get; set; }
        [StringLength(255)]
        public string StkItemTypeDescription { get; set; }
        [StringLength(500)]
        public string StkItemTypeReportDescription { get; set; }
    }
}

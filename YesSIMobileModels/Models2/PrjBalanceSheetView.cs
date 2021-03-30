using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class PrjBalanceSheetView
    {
        public Guid? PrjMarketId { get; set; }
        [StringLength(255)]
        public string PrjMarketCode { get; set; }
        [StringLength(255)]
        public string PrjMarketDescription { get; set; }
        [Required]
        public string SupplierDescription { get; set; }
        public bool? IsMultiSupplier { get; set; }
        public Guid? PrjProjectId { get; set; }
        [StringLength(255)]
        public string PrjProjectCode { get; set; }
        [StringLength(255)]
        public string PrjProjectDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? PrjMarketTypeId { get; set; }
        [StringLength(255)]
        public string PrjMarketTypeCode { get; set; }
        [StringLength(255)]
        public string PrjMarketTypeDescription { get; set; }
        public Guid? PrjMarketStatusId { get; set; }
        [StringLength(255)]
        public string PrjMarketStatusCode { get; set; }
        [StringLength(255)]
        public string PrjMarketStatusDescription { get; set; }
        public Guid? StlCategoryId { get; set; }
        [StringLength(255)]
        public string StlCategoryDescription { get; set; }
        public Guid? StlCategoryParentId { get; set; }
        public int? StlCategorySorting { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? VentilationRate { get; set; }
        [Column("FeasabilityStudyHT", TypeName = "decimal(38, 6)")]
        public decimal? FeasabilityStudyHt { get; set; }
        [Column("FeasabilityStudyVAT", TypeName = "decimal(38, 6)")]
        public decimal? FeasabilityStudyVat { get; set; }
        [Column("FeasabilityStudyTTC", TypeName = "decimal(38, 6)")]
        public decimal? FeasabilityStudyTtc { get; set; }
        [Column("EstimatedAmountHTManual", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedAmountHtmanual { get; set; }
        [Column("EstimatedAmountVATManual", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedAmountVatmanual { get; set; }
        [Column("EstimatedAmountTTCManual", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedAmountTtcmanual { get; set; }
        [Column("EstimatedAmountHT", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedAmountHt { get; set; }
        [Column("EstimatedAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedAmountVat { get; set; }
        [Column("EstimatedAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedAmountTtc { get; set; }
        [Column("OfferedPriceHT", TypeName = "decimal(38, 6)")]
        public decimal? OfferedPriceHt { get; set; }
        [Column("OfferedPriceVAT", TypeName = "decimal(38, 6)")]
        public decimal? OfferedPriceVat { get; set; }
        [Column("OfferedPriceTTC", TypeName = "decimal(38, 6)")]
        public decimal? OfferedPriceTtc { get; set; }
        [Column("OffredAmountAjustedHT", TypeName = "decimal(38, 6)")]
        public decimal? OffredAmountAjustedHt { get; set; }
        [Column("OffredAmountAjustedVAT", TypeName = "decimal(38, 6)")]
        public decimal? OffredAmountAjustedVat { get; set; }
        [Column("OffredAmountAjustedTTC", TypeName = "decimal(38, 6)")]
        public decimal? OffredAmountAjustedTtc { get; set; }
        [Column("PrevisionHT", TypeName = "decimal(38, 6)")]
        public decimal? PrevisionHt { get; set; }
        [Column("PrevisionVAT", TypeName = "decimal(38, 6)")]
        public decimal? PrevisionVat { get; set; }
        [Column("PrevisionTTC", TypeName = "decimal(38, 6)")]
        public decimal? PrevisionTtc { get; set; }
        [Column("CostTotalHT", TypeName = "decimal(38, 6)")]
        public decimal? CostTotalHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? CostTotalVat { get; set; }
        [Column("CostTotalTTC", TypeName = "decimal(38, 6)")]
        public decimal? CostTotalTtc { get; set; }
        [Column("PositionTotalHT", TypeName = "decimal(38, 6)")]
        public decimal? PositionTotalHt { get; set; }
        [Column("PositionTotalVAT", TypeName = "decimal(38, 6)")]
        public decimal? PositionTotalVat { get; set; }
        [Column("PositionTotalTTC", TypeName = "decimal(38, 6)")]
        public decimal? PositionTotalTtc { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Gap { get; set; }
        [Required]
        [StringLength(16)]
        public string DocumentType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OperationDate { get; set; }
        [Column("InvoiceTotalHT", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceTotalHt { get; set; }
        [Column("InvoiceTotalTTC", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceTotalTtc { get; set; }
        [Column("InvoiceAmountHT", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceAmountHt { get; set; }
        [Column("InvoiceAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceAmountTtc { get; set; }
        [Column("TotalRNR", TypeName = "decimal(38, 6)")]
        public decimal? TotalRnr { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalAmountSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TotalAmountRest { get; set; }
    }
}

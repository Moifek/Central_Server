using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class BuyDocumentBaseView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column("AmountHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountVat { get; set; }
        [Column("AmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? AmountTtc { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FiscalStamp { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountToPay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MaturityDate { get; set; }
        [StringLength(255)]
        public string DocType { get; set; }
        public bool? IsSelected { get; set; }
        [StringLength(255)]
        public string DocRef { get; set; }
        public bool? IsClosed { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountRegul { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public string Notes2 { get; set; }
        [StringLength(255)]
        public string ReferenceType { get; set; }
        [StringLength(255)]
        public string OfficeOrderRef { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvanceRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvanceAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WarrantyRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WarrantyAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProportionRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProportionAmount { get; set; }
        [Column("InsuranceDECRatio", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceDecratio { get; set; }
        [Column("InsuranceDECAmount", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceDecamount { get; set; }
        [Column("InsuranceTRCRatio", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceTrcratio { get; set; }
        [Column("InsuranceTRCAmount", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceTrcamount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvanceRest { get; set; }
        [Column("InsuranceDECRest", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceDecrest { get; set; }
        [Column("InsuranceTRCRest", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceTrcrest { get; set; }
        public bool? CanBePayed { get; set; }
        public int? LinesCount { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PrevisionDeliveryDate { get; set; }
        [StringLength(1000)]
        public string ParentDocuments { get; set; }
        [StringLength(255)]
        public string State { get; set; }
        [StringLength(255)]
        public string PersonToContact { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StockAmountToPay { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WorkingOutAdvanceAmount { get; set; }
        public bool? IsRejected { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? RetainedAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProrataRefundAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FluctuationsToPay { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [StringLength(255)]
        public string SupplierDescription { get; set; }
        public Guid? CfgTierId { get; set; }
        [StringLength(255)]
        public string CfgTierCode { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? PrjMarketId { get; set; }
        [StringLength(255)]
        public string MarketCode { get; set; }
        [StringLength(255)]
        public string PrjMarketDescription { get; set; }
        [StringLength(255)]
        public string MarketDescription { get; set; }
        public Guid? PrjProjectId { get; set; }
        [StringLength(255)]
        public string PrjProjectCode { get; set; }
        public string PrjProjectDescription { get; set; }
        [StringLength(255)]
        public string ProjectDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? PrjMarketOfferId { get; set; }
        public Guid? BuyLoanId { get; set; }
        public Guid? BuyLoanScheduleId { get; set; }
        public Guid? BuyConsultationOfferId { get; set; }
        public Guid? AdmModuleId { get; set; }
        [StringLength(255)]
        public string AdmModuleCode { get; set; }
        [StringLength(255)]
        public string AdmModuleDescription { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        [Column(TypeName = "text")]
        public string StrEntityDescriptionLong { get; set; }
        public bool? StrEntityIsCharge { get; set; }
        public Guid? BuyFolderId { get; set; }
        [StringLength(255)]
        public string BuyFolderCode { get; set; }
        [StringLength(255)]
        public string BuyFolderDescription { get; set; }
        [StringLength(255)]
        public string FolderDescription { get; set; }
        public Guid? StkExpenseId { get; set; }
        [StringLength(255)]
        public string StkExpenseTypeCode { get; set; }
        [StringLength(255)]
        public string StkExpenseTypeDescription { get; set; }
        public Guid? InvoiceSourceId { get; set; }
        [StringLength(255)]
        public string BuyInvoiceCode { get; set; }
        [StringLength(255)]
        public string BuyInvoiceDescription { get; set; }
        public Guid? BuyInvoiceId { get; set; }
        public Guid? BuyOrderId { get; set; }
        [StringLength(255)]
        public string BuyOrderCode { get; set; }
        [StringLength(255)]
        public string BuyOrderDescription { get; set; }
        public Guid? BuyQuoteId { get; set; }
        [StringLength(255)]
        public string BuyQuoteCode { get; set; }
        [StringLength(255)]
        public string BuyQuoteDescription { get; set; }
        public Guid? PrjMarketTypeId { get; set; }
        [StringLength(255)]
        public string PrjMarketTypeCode { get; set; }
        [StringLength(255)]
        public string PrjMarketTypeDescription { get; set; }
        [Required]
        public string StlCategoryDescription { get; set; }
    }
}

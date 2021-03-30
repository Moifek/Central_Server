using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class BuyDocumentToPayView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MaturityDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AlerteDate { get; set; }
        [StringLength(255)]
        public string DocRef { get; set; }
        [StringLength(255)]
        public string PersonToContact { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public string Notes2 { get; set; }
        [StringLength(255)]
        public string DocType { get; set; }
        [StringLength(255)]
        public string ReferenceType { get; set; }
        [StringLength(255)]
        public string OfficeOrderRef { get; set; }
        [Column("AmountHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountVat { get; set; }
        [Column("AmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? AmountTtc { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FiscalStamp { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountRegul { get; set; }
        [Column(TypeName = "decimal(33, 6)")]
        public decimal? TotalRetainedAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountRest { get; set; }
        public bool? IsSelected { get; set; }
        public bool? IsClosed { get; set; }
        public bool? CanBePayed { get; set; }
        public bool? IsRejected { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AccountingDate { get; set; }
        public bool? IsAccounted { get; set; }
        public Guid ObjectId { get; set; }
        [Required]
        [StringLength(41)]
        public string ObjectNameSpace { get; set; }
        [StringLength(255)]
        public string ObjectDescription { get; set; }
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
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StockAmountToPay { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WorkingOutAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? RetainedAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProrataRefundAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FluctuationsToPay { get; set; }
        public int? LinesCount { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PrevisionDeliveryDate { get; set; }
        [StringLength(1000)]
        public string ParentDocuments { get; set; }
        [StringLength(255)]
        public string State { get; set; }
        public Guid? CfgTierId { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? CfgTierTriggerId { get; set; }
        [StringLength(255)]
        public string CfgTierTriggerDescription { get; set; }
        public Guid? PrjMarketId { get; set; }
        [StringLength(255)]
        public string PrjMarketDescription { get; set; }
        public Guid? BuyConsultationId { get; set; }
        [StringLength(255)]
        public string BuyConsultationDescription { get; set; }
        public Guid? PrjMarketTypeId { get; set; }
        [StringLength(255)]
        public string PrjMarketTypeCode { get; set; }
        [StringLength(255)]
        public string PrjMarketTypeDescription { get; set; }
        public Guid? BuyFolderId { get; set; }
        [StringLength(255)]
        public string BuyFolderDescription { get; set; }
        public Guid? RntFolderId { get; set; }
        [StringLength(255)]
        public string RntFolderDescription { get; set; }
        public Guid? BuyLoanId { get; set; }
        [StringLength(255)]
        public string BuyLoanDescription { get; set; }
        [StringLength(255)]
        public string BuyLoanTypeDescription { get; set; }
        public Guid? BuyLoanScheduleId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? BuyLoanSchedulePaymentDate { get; set; }
        public Guid? StkExpenseId { get; set; }
        [StringLength(1000)]
        public string StkExpenseNotes { get; set; }
        [StringLength(255)]
        public string StkExpenseTypeDescription { get; set; }
        [StringLength(255)]
        public string StkItemCode { get; set; }
        [StringLength(255)]
        public string StkItemDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? AdmModuleId { get; set; }
        [StringLength(255)]
        public string AdmModuleCode { get; set; }
        [StringLength(255)]
        public string AdmModuleDescription { get; set; }
        public Guid? PrjMarketOfferId { get; set; }
        [StringLength(255)]
        public string PrjMarketOfferCode { get; set; }
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        [Column(TypeName = "text")]
        public string StrEntityDescriptionLong { get; set; }
        public bool? StrEntityIsaccountable { get; set; }
        public Guid? BuyDocumentStatusId { get; set; }
        [StringLength(255)]
        public string BuyDocumentStatusCode { get; set; }
        [StringLength(255)]
        public string BuyDocumentStatusDescription { get; set; }
        public Guid? BuyDocumentStatusCfgImageId { get; set; }
        [Column(TypeName = "image")]
        public byte[] StatusImg { get; set; }
        public bool? BuyDocumentStatusIsOkForPayement { get; set; }
        public bool? BuyDocumentStatusIsValidatedOnAccounting { get; set; }
        public Guid? BuyOrderId { get; set; }
        [StringLength(255)]
        public string BuyOrderCode { get; set; }
        [StringLength(255)]
        public string BuyOrderDescription { get; set; }
        public Guid? InvoiceSourceId { get; set; }
        public Guid? BuyInvoiceId { get; set; }
        public Guid? PrjProjectId { get; set; }
        public string PrjProjectIds { get; set; }
        public string PrjProjectDescription { get; set; }
        public string StlCategoryDescription { get; set; }
        public Guid? BuyConsultationOfferId { get; set; }
        [StringLength(255)]
        public string BuyConsultationOfferCode { get; set; }
        public Guid? StlCurrencyId { get; set; }
        [StringLength(255)]
        public string StlCurrencyCode { get; set; }
        [StringLength(255)]
        public string StlCurrencyDescription { get; set; }
        public bool? IsFinancialRefund { get; set; }
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

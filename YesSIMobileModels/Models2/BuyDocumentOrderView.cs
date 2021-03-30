using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class BuyDocumentOrderView
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
        public int? AlerteDate { get; set; }
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
        public bool? IsSelected { get; set; }
        public bool? IsClosed { get; set; }
        public bool? CanBePayed { get; set; }
        public bool? IsRejected { get; set; }
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
        [StringLength(255)]
        public string OfficeOrderRef { get; set; }
        public Guid? BuyOrderId { get; set; }
        public Guid? CfgTierId { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? CfgTierTriggerId { get; set; }
        [StringLength(255)]
        public string CfgTierTriggerDescription { get; set; }
        public Guid? PrjProjectId { get; set; }
        public string PrjProjectDescription { get; set; }
        public Guid? PrjMarketId { get; set; }
        [StringLength(255)]
        public string PrjMarketCode { get; set; }
        [StringLength(255)]
        public string PrjMarketDescription { get; set; }
        public Guid? PrjMarketStlCategoryId { get; set; }
        public Guid? PrjMarketPrjProjectId { get; set; }
        public Guid? BuyConsultationId { get; set; }
        [StringLength(255)]
        public string BuyConsultationCode { get; set; }
        [StringLength(255)]
        public string BuyConsultationDescription { get; set; }
        public Guid? BuyFolderId { get; set; }
        [StringLength(255)]
        public string BuyFolderDescription { get; set; }
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
        public string CfgCompanyDescription { get; set; }
        public Guid? AdmModuleId { get; set; }
        [StringLength(255)]
        public string AdmModuleDescription { get; set; }
        public Guid? PrjMarketOfferId { get; set; }
        [StringLength(255)]
        public string PrjMarketOfferCode { get; set; }
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
        public Guid? StrEntityId { get; set; }
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        [Column(TypeName = "text")]
        public string StrEntityDescriptionLong { get; set; }
        public Guid? PrjMarketTypeId { get; set; }
        [StringLength(255)]
        public string PrjMarketTypeCode { get; set; }
        [StringLength(255)]
        public string PrjMarketTypeDescription { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal OrderAdvanceRatio { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PrevisionOrderAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OrderAdvanceAmountRealRatio { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? WarrantyAmountRetained { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? WarrantyAmountRestitued { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? WarrantyAmountRest { get; set; }
        [Column("AmountHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountHt { get; set; }
        [Column(TypeName = "decimal(27, 6)")]
        public decimal? AmountVat { get; set; }
        [Column("AmountTTC", TypeName = "decimal(26, 6)")]
        public decimal? AmountTtc { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FiscalStamp { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountRegul { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AmountToPay { get; set; }
        [Column("OrderAdvanceAmountHT", TypeName = "decimal(38, 6)")]
        public decimal? OrderAdvanceAmountHt { get; set; }
        [Column("OrderAdvanceAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? OrderAdvanceAmountVat { get; set; }
        [Column("OrderAdvanceAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal? OrderAdvanceAmountTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OrderAdvanceAmount { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OrderAdvanceAmountSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OrderAdvanceAmountRest { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AdvanceAmountAmortized { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AdvanceAmountRestAmortized { get; set; }
        [Column("InvoicedAmountHT", TypeName = "decimal(38, 6)")]
        public decimal? InvoicedAmountHt { get; set; }
        [Column("InvoicedAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? InvoicedAmountVat { get; set; }
        [Column("InvoicedAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal? InvoicedAmountTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? InvoicedAmountAmortized { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? InvoicedAmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? InvoiceAmountToPay { get; set; }
        [Column("OverHT", TypeName = "decimal(38, 6)")]
        public decimal? OverHt { get; set; }
        [Column("OverVAT", TypeName = "decimal(38, 6)")]
        public decimal? OverVat { get; set; }
        [Column("OverTTC", TypeName = "decimal(38, 6)")]
        public decimal? OverTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? OverToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? PrevisionAmount { get; set; }
        [Column("PrevisionAmountHT", TypeName = "decimal(38, 6)")]
        public decimal? PrevisionAmountHt { get; set; }
        [Column("PrevisionAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal? PrevisionAmountTtc { get; set; }
        public Guid? InvoiceSourceId { get; set; }
        public string StlCategoryDescription { get; set; }
        [Column("DeliveryAmountHT", TypeName = "decimal(38, 6)")]
        public decimal? DeliveryAmountHt { get; set; }
        [Column("DeliveryAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal? DeliveryAmountTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? DeliveryAmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountSettled { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountRestToPayInvoice { get; set; }
        [Column("RestDeliveredAmountHT", TypeName = "decimal(38, 6)")]
        public decimal? RestDeliveredAmountHt { get; set; }
        [Column("RestDeliveredAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal? RestDeliveredAmountTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? RestDeliveredAmountToPay { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountRestToPay { get; set; }
        [StringLength(1)]
        public string ActiveAlert { get; set; }
        public Guid? BuyQuoteId { get; set; }
        [Required]
        [StringLength(255)]
        public string BuyQuoteCode { get; set; }
        [Required]
        [StringLength(255)]
        public string BuyQuoteDescription { get; set; }
        public string BuyBeliveryCode { get; set; }
        public string BuyInvoiceCode { get; set; }
        public Guid? StlCurrencyId { get; set; }
        [StringLength(255)]
        public string StlCurrencyCode { get; set; }
        [StringLength(255)]
        public string StlCurrencyDescription { get; set; }
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

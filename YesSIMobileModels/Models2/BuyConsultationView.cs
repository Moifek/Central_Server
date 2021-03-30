using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class BuyConsultationView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DefaultVat { get; set; }
        [StringLength(500)]
        public string DescriptionLong { get; set; }
        public Guid? StrEntityId { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? PrjMarketTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjMarketTypeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjMarketTypeDescription { get; set; }
        public Guid? BuyConsultationStatusId { get; set; }
        public int? BuyConsultationStatusSorting { get; set; }
        [Required]
        [StringLength(255)]
        public string BuyConsultationStatusCode { get; set; }
        [Required]
        [StringLength(255)]
        public string Status { get; set; }
        [Column(TypeName = "image")]
        public byte[] StatusImg { get; set; }
        public Guid? PrjProjectId { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjProjectCode { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjProjectDescription { get; set; }
        public Guid? CfgTierId { get; set; }
        [StringLength(255)]
        public string CfgTierCode { get; set; }
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? StlCategoryId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlCategoryCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlCategoryDescription { get; set; }
        [Required]
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [Required]
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column("EstimatedPriceManualHT", TypeName = "decimal(26, 6)")]
        public decimal? EstimatedPriceManualHt { get; set; }
        [Column("EstimatedPriceManualVAT", TypeName = "decimal(27, 6)")]
        public decimal? EstimatedPriceManualVat { get; set; }
        [Column("EstimatedPriceManualTTC", TypeName = "decimal(26, 6)")]
        public decimal? EstimatedPriceManualTtc { get; set; }
        [Column("EstimatedPriceHT", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedPriceHt { get; set; }
        [Column("EstimatedPriceVAT", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedPriceVat { get; set; }
        [Column("EstimatedPriceTTC", TypeName = "decimal(38, 6)")]
        public decimal? EstimatedPriceTtc { get; set; }
        [Column("MarketPriceHT", TypeName = "decimal(26, 6)")]
        public decimal MarketPriceHt { get; set; }
        [Column("MarketPriceVAT", TypeName = "decimal(27, 6)")]
        public decimal? MarketPriceVat { get; set; }
        [Column("MarketPriceTTC", TypeName = "decimal(26, 6)")]
        public decimal MarketPriceTtc { get; set; }
        [Column("ModificationHT", TypeName = "decimal(38, 6)")]
        public decimal? ModificationHt { get; set; }
        [Column("ModificationVAT", TypeName = "decimal(38, 6)")]
        public decimal? ModificationVat { get; set; }
        [Column("ModificationTTC", TypeName = "decimal(38, 6)")]
        public decimal? ModificationTtc { get; set; }
        [Column("MarketPriceAdjustedHT", TypeName = "decimal(38, 6)")]
        public decimal MarketPriceAdjustedHt { get; set; }
        [Column("MarketPriceAdjustedVAT", TypeName = "decimal(38, 6)")]
        public decimal? MarketPriceAdjustedVat { get; set; }
        [Column("MarketPriceAdjustedTTC", TypeName = "decimal(38, 6)")]
        public decimal MarketPriceAdjustedTtc { get; set; }
        [Column("OrderAmountHT", TypeName = "decimal(38, 6)")]
        public decimal OrderAmountHt { get; set; }
        [Column("OrderAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? OrderAmountVat { get; set; }
        [Column("OrderAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal OrderAmountTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal OrderAdvance { get; set; }
        [Column("DeliveryAmountHT", TypeName = "decimal(38, 6)")]
        public decimal DeliveryAmountHt { get; set; }
        [Column("DeliveryAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? DeliveryAmountVat { get; set; }
        [Column("DeliveryAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal DeliveryAmountTtc { get; set; }
        [Column("InvoiceAmountHT", TypeName = "decimal(38, 6)")]
        public decimal InvoiceAmountHt { get; set; }
        [Column("InvoiceAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? InvoiceAmountVat { get; set; }
        [Column("InvoiceAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal InvoiceAmountTtc { get; set; }
        [Column("RefundAmountHT", TypeName = "decimal(38, 6)")]
        public decimal RefundAmountHt { get; set; }
        [Column("RefundAmountVAT", TypeName = "decimal(38, 6)")]
        public decimal? RefundAmountVat { get; set; }
        [Column("RefundAmountTTC", TypeName = "decimal(38, 6)")]
        public decimal RefundAmountTtc { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? AmountSettled { get; set; }
        public Guid? StlCurrencyId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlCurrencyCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlCurrencyDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LaunchOfTenderDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WithdrawalTenderDocumentsDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TenderMaturityDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TendersresortDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BidOpeningDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TendersreportDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TenderDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ContractSignatureDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ServiceOrderDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkLaunchDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkCompletionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReattachmentDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CancellationDate { get; set; }
        [StringLength(500)]
        public string CancellationCause { get; set; }
        public string TextLetterConsultation { get; set; }
    }
}

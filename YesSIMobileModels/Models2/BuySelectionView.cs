using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class BuySelectionView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        public int? Sorting { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(500)]
        public string DescriptionLong { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DefaultVat { get; set; }
        [Column("PriceEstimatedHT", TypeName = "decimal(26, 6)")]
        public decimal? PriceEstimatedHt { get; set; }
        [Column("PriceEstimatedVAT", TypeName = "decimal(27, 6)")]
        public decimal? PriceEstimatedVat { get; set; }
        [Column("PriceEstimatedTTC", TypeName = "decimal(26, 6)")]
        public decimal? PriceEstimatedTtc { get; set; }
        [Column("PriceHT", TypeName = "decimal(26, 6)")]
        public decimal? PriceHt { get; set; }
        [Column("PriceVAT", TypeName = "decimal(27, 6)")]
        public decimal? PriceVat { get; set; }
        [Column("PriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? PriceTtc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LaunchOfTenderDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WithdrawalTenderDocumentsDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TenderMaturityDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TendersResortDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BidOpeningDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TendersReportDate { get; set; }
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
        [StringLength(1000)]
        public string Notes { get; set; }
        public string TextLetterSelection { get; set; }
        public bool? IsTheLast { get; set; }
        public Guid? StrEntityId { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
        public Guid? StrStatusId { get; set; }
        public int? StrStatusSorting { get; set; }
        [StringLength(255)]
        public string StrStatusCode { get; set; }
        [StringLength(255)]
        public string StrStatusDescription { get; set; }
        public bool? StrStatusIsReadOnly { get; set; }
        public bool? StrStatusCanDelete { get; set; }
        public Guid? StrStatusTypeId { get; set; }
        public int? StrStatusTypeSorting { get; set; }
        [StringLength(255)]
        public string StrStatusTypeCode { get; set; }
        [StringLength(255)]
        public string StrStatusTypeDescription { get; set; }
        [StringLength(255)]
        public string StrStatusColorName { get; set; }
        public Guid? StrStatusCfgImageId { get; set; }
        [Column(TypeName = "image")]
        public byte[] StrStatusBytes { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? StlCurrencyId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlCurrencyCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlCurrencyDescription { get; set; }
        public Guid? PrjProjectId { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjProjectCode { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjProjectDescription { get; set; }
        public Guid? PrjMarketId { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjMarketCode { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjMarketDescription { get; set; }
        public Guid? BuyConsultationId { get; set; }
        [Required]
        [StringLength(255)]
        public string BuyConsultationCode { get; set; }
        [Required]
        [StringLength(255)]
        public string BuyConsultationDescription { get; set; }
        public Guid? PrjMarketTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjMarketTypeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string PrjMarketTypeDescription { get; set; }
        public Guid? StlCategoryId { get; set; }
        [Required]
        [StringLength(255)]
        public string StlCategoryCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StlCategoryDescription { get; set; }
        public Guid? BuySelectionKindId { get; set; }
        [Required]
        [StringLength(500)]
        public string BuySelectionKindCode { get; set; }
        [Required]
        [StringLength(500)]
        public string BuySelectionKindDescription { get; set; }
        public Guid? CfgTierId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
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

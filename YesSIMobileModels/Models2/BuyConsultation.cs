using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuyConsultation")]
    public partial class BuyConsultation
    {
        public BuyConsultation()
        {
            BuyConsultationEstimationGroups = new HashSet<BuyConsultationEstimationGroup>();
            BuyConsultationEstimationLines = new HashSet<BuyConsultationEstimationLine>();
            BuyConsultationGroups = new HashSet<BuyConsultationGroup>();
            BuyConsultationLines = new HashSet<BuyConsultationLine>();
            BuyConsultationOfferSuppliers = new HashSet<BuyConsultationOfferSupplier>();
            BuyConsultationOffers = new HashSet<BuyConsultationOffer>();
            BuyConsultationStatusHistories = new HashSet<BuyConsultationStatusHistory>();
            BuyDocuments = new HashSet<BuyDocument>();
            BuySelections = new HashSet<BuySelection>();
        }

        [Key]
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
        [Column("EstimatedPriceManualHT", TypeName = "decimal(26, 6)")]
        public decimal? EstimatedPriceManualHt { get; set; }
        [Column("EstimatedPriceManualTTC", TypeName = "decimal(26, 6)")]
        public decimal? EstimatedPriceManualTtc { get; set; }
        [Column("EstimatedPriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? EstimatedPriceTtc { get; set; }
        [Column("EstimatedPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? EstimatedPriceHt { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? PrjMarketTypeId { get; set; }
        public Guid? PrjProjectId { get; set; }
        public Guid? CfgTierId { get; set; }
        public Guid? StlCategoryId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
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
        public Guid? BuyConsultationStatusId { get; set; }
        public string TextLetterConsultation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CancellationDate { get; set; }
        [StringLength(500)]
        public string CancellationCause { get; set; }
        public Guid? StlCurrencyId { get; set; }
        public Guid? CfgCompanyId { get; set; }

        [ForeignKey(nameof(BuyConsultationStatusId))]
        [InverseProperty("BuyConsultations")]
        public virtual BuyConsultationStatus BuyConsultationStatus { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("BuyConsultations")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("BuyConsultations")]
        public virtual CfgTier CfgTier { get; set; }
        [ForeignKey(nameof(PrjMarketTypeId))]
        [InverseProperty("BuyConsultations")]
        public virtual PrjMarketType PrjMarketType { get; set; }
        [ForeignKey(nameof(PrjProjectId))]
        [InverseProperty("BuyConsultations")]
        public virtual PrjProject PrjProject { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("BuyConsultations")]
        public virtual StlCategory StlCategory { get; set; }
        [ForeignKey(nameof(StlCurrencyId))]
        [InverseProperty("BuyConsultations")]
        public virtual StlCurrency StlCurrency { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("BuyConsultations")]
        public virtual StrEntity StrEntity { get; set; }
        [InverseProperty(nameof(BuyConsultationEstimationGroup.BuyConsultation))]
        public virtual ICollection<BuyConsultationEstimationGroup> BuyConsultationEstimationGroups { get; set; }
        [InverseProperty(nameof(BuyConsultationEstimationLine.BuyConsultation))]
        public virtual ICollection<BuyConsultationEstimationLine> BuyConsultationEstimationLines { get; set; }
        [InverseProperty(nameof(BuyConsultationGroup.BuyConsultation))]
        public virtual ICollection<BuyConsultationGroup> BuyConsultationGroups { get; set; }
        [InverseProperty(nameof(BuyConsultationLine.BuyConsultation))]
        public virtual ICollection<BuyConsultationLine> BuyConsultationLines { get; set; }
        [InverseProperty(nameof(BuyConsultationOfferSupplier.BuyConsultation))]
        public virtual ICollection<BuyConsultationOfferSupplier> BuyConsultationOfferSuppliers { get; set; }
        [InverseProperty(nameof(BuyConsultationOffer.BuyConsultation))]
        public virtual ICollection<BuyConsultationOffer> BuyConsultationOffers { get; set; }
        [InverseProperty(nameof(BuyConsultationStatusHistory.BuyConsultation))]
        public virtual ICollection<BuyConsultationStatusHistory> BuyConsultationStatusHistories { get; set; }
        [InverseProperty(nameof(BuyDocument.BuyConsultation))]
        public virtual ICollection<BuyDocument> BuyDocuments { get; set; }
        [InverseProperty(nameof(BuySelection.BuyConsultation))]
        public virtual ICollection<BuySelection> BuySelections { get; set; }
    }
}

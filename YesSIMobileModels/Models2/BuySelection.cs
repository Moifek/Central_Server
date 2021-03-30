using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("BuySelection")]
    public partial class BuySelection
    {
        public BuySelection()
        {
            BuyDocuments = new HashSet<BuyDocument>();
            BuySelectionGroups = new HashSet<BuySelectionGroup>();
            BuySelectionLines = new HashSet<BuySelectionLine>();
            BuySelectionPaymentTerms = new HashSet<BuySelectionPaymentTerm>();
            BuySelectionStockLines = new HashSet<BuySelectionStockLine>();
            BuySelectionSuppliers = new HashSet<BuySelectionSupplier>();
        }

        [Key]
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
        [Column("PriceEstimatedTTC", TypeName = "decimal(26, 6)")]
        public decimal? PriceEstimatedTtc { get; set; }
        [Column("PriceHT", TypeName = "decimal(26, 6)")]
        public decimal? PriceHt { get; set; }
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
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? StrEntityId { get; set; }
        public Guid? StrStatusId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? StlCurrencyId { get; set; }
        public Guid? PrjProjectId { get; set; }
        public Guid? PrjMarketId { get; set; }
        public Guid? BuyConsultationId { get; set; }
        public Guid? PrjMarketTypeId { get; set; }
        public Guid? StlCategoryId { get; set; }
        public Guid? BuySelectionKindId { get; set; }
        public Guid? CfgTierId { get; set; }
        public Guid? GroupId { get; set; }
        public Guid? StlSettlementTypeId { get; set; }
        public int? PaymentDelay { get; set; }

        [ForeignKey(nameof(BuyConsultationId))]
        [InverseProperty("BuySelections")]
        public virtual BuyConsultation BuyConsultation { get; set; }
        [ForeignKey(nameof(BuySelectionKindId))]
        [InverseProperty("BuySelections")]
        public virtual BuySelectionKind BuySelectionKind { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("BuySelections")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgTierId))]
        [InverseProperty("BuySelections")]
        public virtual CfgTier CfgTier { get; set; }
        [ForeignKey(nameof(PrjMarketId))]
        [InverseProperty("BuySelections")]
        public virtual PrjMarket PrjMarket { get; set; }
        [ForeignKey(nameof(PrjMarketTypeId))]
        [InverseProperty("BuySelections")]
        public virtual PrjMarketType PrjMarketType { get; set; }
        [ForeignKey(nameof(PrjProjectId))]
        [InverseProperty("BuySelections")]
        public virtual PrjProject PrjProject { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("BuySelections")]
        public virtual StlCategory StlCategory { get; set; }
        [ForeignKey(nameof(StlCurrencyId))]
        [InverseProperty("BuySelections")]
        public virtual StlCurrency StlCurrency { get; set; }
        [ForeignKey(nameof(StlSettlementTypeId))]
        [InverseProperty("BuySelections")]
        public virtual StlSettlementType StlSettlementType { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("BuySelections")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(StrStatusId))]
        [InverseProperty("BuySelections")]
        public virtual StrStatus StrStatus { get; set; }
        [InverseProperty(nameof(BuyDocument.BuySelection))]
        public virtual ICollection<BuyDocument> BuyDocuments { get; set; }
        [InverseProperty(nameof(BuySelectionGroup.BuySelection))]
        public virtual ICollection<BuySelectionGroup> BuySelectionGroups { get; set; }
        [InverseProperty(nameof(BuySelectionLine.BuySelection))]
        public virtual ICollection<BuySelectionLine> BuySelectionLines { get; set; }
        [InverseProperty(nameof(BuySelectionPaymentTerm.BuySelection))]
        public virtual ICollection<BuySelectionPaymentTerm> BuySelectionPaymentTerms { get; set; }
        [InverseProperty(nameof(BuySelectionStockLine.BuySelection))]
        public virtual ICollection<BuySelectionStockLine> BuySelectionStockLines { get; set; }
        [InverseProperty(nameof(BuySelectionSupplier.BuySelection))]
        public virtual ICollection<BuySelectionSupplier> BuySelectionSuppliers { get; set; }
    }
}

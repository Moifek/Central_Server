using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("PrjMarket")]
    [Index(nameof(Pkey), nameof(PrjProjectId), Name = "_dta_index_PrjMarket_10_20195122__K1_K30_2_3_86_96")]
    [Index(nameof(PrjProjectId), Name = "_dta_index_PrjMarket_10_20195122__K30")]
    [Index(nameof(PrjProjectId), Name = "_dta_index_PrjMarket_10_20195122__K30_16_123")]
    [Index(nameof(PrjProjectId), nameof(Pkey), Name = "_dta_index_PrjMarket_10_20195122__K30_K1_2_3_86_96")]
    [Index(nameof(PrjProjectId), nameof(Pkey), nameof(StlSettlementTypeId), nameof(PrjMarketTypeId), nameof(PrjMarketStatusId), nameof(CfgSupplierId), nameof(StlCategoryId), nameof(StrEntityId), Name = "_dta_index_PrjMarket_10_20195122__K30_K1_K58_K29_K57_K34_K77_K137_2_3_4_10_11_12_14_15_16_17_22_24_38_39_59_78_81_86_87_88_91_")]
    [Index(nameof(StlCategoryId), nameof(Pkey), Name = "_dta_index_PrjMarket_10_20195122__K77_K1")]
    public partial class PrjMarket
    {
        public PrjMarket()
        {
            BulDelegates = new HashSet<BulDelegate>();
            BulMeetingLines = new HashSet<BulMeetingLine>();
            BuyDocuments = new HashSet<BuyDocument>();
            BuySelections = new HashSet<BuySelection>();
            PrjClauses = new HashSet<PrjClause>();
            PrjLinePrevisions = new HashSet<PrjLinePrevision>();
            PrjMarketDocumentToAttaches = new HashSet<PrjMarketDocumentToAttach>();
            PrjMarketHierarchies = new HashSet<PrjMarketHierarchy>();
            PrjMarketLineEstimations = new HashSet<PrjMarketLineEstimation>();
            PrjMarketLineGroupingEstimations = new HashSet<PrjMarketLineGroupingEstimation>();
            PrjMarketLineGroupings = new HashSet<PrjMarketLineGrouping>();
            PrjMarketLines = new HashSet<PrjMarketLine>();
            PrjMarketOfferSuppliers = new HashSet<PrjMarketOfferSupplier>();
            PrjMarketOffers = new HashSet<PrjMarketOffer>();
            PrjMarketPaymentPrevisionManuals = new HashSet<PrjMarketPaymentPrevisionManual>();
            PrjMarketPaymentPrevisions = new HashSet<PrjMarketPaymentPrevision>();
            PrjMarketPrevisions = new HashSet<PrjMarketPrevision>();
            PrjMarketReceptions = new HashSet<PrjMarketReception>();
            PrjMarketStatusHistories = new HashSet<PrjMarketStatusHistory>();
            PrjMarketVentilationCategories = new HashSet<PrjMarketVentilationCategory>();
            PrjMarketViews = new HashSet<PrjMarketView>();
            PrjMarketWarrantyLines = new HashSet<PrjMarketWarrantyLine>();
            PrjPrevisionDates = new HashSet<PrjPrevisionDate>();
            PrjProjects = new HashSet<PrjProject>();
            PrjStockLineEstimations = new HashSet<PrjStockLineEstimation>();
            PrjStockLines = new HashSet<PrjStockLine>();
            PrjWorkingOuts = new HashSet<PrjWorkingOut>();
            SavClaimPrjMarketClaims = new HashSet<SavClaim>();
            SavClaimPrjMarkets = new HashSet<SavClaim>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public int? Delay { get; set; }
        [Column("EstimatedPriceTTC", TypeName = "decimal(26, 6)")]
        public decimal? EstimatedPriceTtc { get; set; }
        [Column("InsuranceDECAmount", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceDecamount { get; set; }
        [Column("InsuranceTRCAmount", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceTrcamount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WarrantyRatio { get; set; }
        [Column("InsuranceDECRatio", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceDecratio { get; set; }
        [Column("InsuranceTRCRatio", TypeName = "decimal(26, 6)")]
        public decimal? InsuranceTrcratio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProportionRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvanceRatio { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? MassChangeRatio { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? PrjMarketTypeId { get; set; }
        public Guid? PrjProjectId { get; set; }
        public Guid? CfgSupplierId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        public Guid? PrjMarketStatusId { get; set; }
        public Guid? StlSettlementTypeId { get; set; }
        public int? PaymentDelay { get; set; }
        public Guid? StlCategoryId { get; set; }
        public bool? IsMultiSupplier { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? PercentComplete { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DefaultVat { get; set; }
        public bool? ExecutedQuantityBasedInsert { get; set; }
        public bool? DuplicateInsertAutorised { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StockPileRatio { get; set; }
        public Guid? StkLevelingLineId { get; set; }
        public bool? ApplyDiscountOnAdditionalWork { get; set; }
        public bool? ApplyWithholdingTaxOnAdditionalWork { get; set; }
        public int? TotalPoints { get; set; }
        public bool? WithMarketView { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LaunchOfTenderDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TenderMaturityDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TenderDate { get; set; }
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
        [Column(TypeName = "datetime")]
        public DateTime? BidOpeningDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TendersResortDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TendersReportDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ContractSignatureDate { get; set; }
        public bool? AchievmentBasedOnQuantity { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WithdrawalTenderDocumentsDate { get; set; }
        [Column("EstimatedPriceHTManual", TypeName = "decimal(26, 6)")]
        public decimal? EstimatedPriceHtmanual { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EstimatedVatAmountManual { get; set; }
        [Column("EstimatedPriceTTCManual", TypeName = "decimal(26, 6)")]
        public decimal? EstimatedPriceTtcmanual { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDateManual { get; set; }
        public int? DelayManual { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDateManual { get; set; }
        public bool? CanEditWorkingOutLineByAchivement { get; set; }
        [StringLength(500)]
        public string CancellationCause { get; set; }
        [StringLength(500)]
        public string DescriptionLong { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WarrantyInMonths { get; set; }
        public Guid? StrEntityId { get; set; }
        public bool? BlokWarrantyRestitution { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? IncludedInPaymentPrevision { get; set; }
        public bool? IsClosed { get; set; }
        [StringLength(255)]
        public string CodeConsultation { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Gap { get; set; }
        public Guid? StlCurrencyId { get; set; }

        [ForeignKey(nameof(PrjMarketStatusId))]
        [InverseProperty("PrjMarkets")]
        public virtual PrjMarketStatus PrjMarketStatus { get; set; }
        [ForeignKey(nameof(PrjMarketTypeId))]
        [InverseProperty("PrjMarkets")]
        public virtual PrjMarketType PrjMarketType { get; set; }
        [ForeignKey(nameof(PrjProjectId))]
        [InverseProperty("PrjMarkets")]
        public virtual PrjProject PrjProject { get; set; }
        [ForeignKey(nameof(StkLevelingLineId))]
        [InverseProperty("PrjMarkets")]
        public virtual StkLevelingLine StkLevelingLine { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("PrjMarkets")]
        public virtual StlCategory StlCategory { get; set; }
        [ForeignKey(nameof(StlCurrencyId))]
        [InverseProperty("PrjMarkets")]
        public virtual StlCurrency StlCurrency { get; set; }
        [ForeignKey(nameof(StlSettlementTypeId))]
        [InverseProperty("PrjMarkets")]
        public virtual StlSettlementType StlSettlementType { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("PrjMarkets")]
        public virtual StrEntity StrEntity { get; set; }
        [InverseProperty(nameof(BulDelegate.PrjMarket))]
        public virtual ICollection<BulDelegate> BulDelegates { get; set; }
        [InverseProperty(nameof(BulMeetingLine.PrjMarket))]
        public virtual ICollection<BulMeetingLine> BulMeetingLines { get; set; }
        [InverseProperty(nameof(BuyDocument.PrjMarket))]
        public virtual ICollection<BuyDocument> BuyDocuments { get; set; }
        [InverseProperty(nameof(BuySelection.PrjMarket))]
        public virtual ICollection<BuySelection> BuySelections { get; set; }
        [InverseProperty(nameof(PrjClause.PrjMarket))]
        public virtual ICollection<PrjClause> PrjClauses { get; set; }
        [InverseProperty(nameof(PrjLinePrevision.PrjMarket))]
        public virtual ICollection<PrjLinePrevision> PrjLinePrevisions { get; set; }
        [InverseProperty(nameof(PrjMarketDocumentToAttach.PrjMarket))]
        public virtual ICollection<PrjMarketDocumentToAttach> PrjMarketDocumentToAttaches { get; set; }
        [InverseProperty(nameof(PrjMarketHierarchy.PrjMarket))]
        public virtual ICollection<PrjMarketHierarchy> PrjMarketHierarchies { get; set; }
        [InverseProperty(nameof(PrjMarketLineEstimation.PrjMarket))]
        public virtual ICollection<PrjMarketLineEstimation> PrjMarketLineEstimations { get; set; }
        [InverseProperty(nameof(PrjMarketLineGroupingEstimation.PrjMarket))]
        public virtual ICollection<PrjMarketLineGroupingEstimation> PrjMarketLineGroupingEstimations { get; set; }
        [InverseProperty(nameof(PrjMarketLineGrouping.PrjMarket))]
        public virtual ICollection<PrjMarketLineGrouping> PrjMarketLineGroupings { get; set; }
        [InverseProperty(nameof(PrjMarketLine.PrjMarket))]
        public virtual ICollection<PrjMarketLine> PrjMarketLines { get; set; }
        [InverseProperty(nameof(PrjMarketOfferSupplier.PrjMarket))]
        public virtual ICollection<PrjMarketOfferSupplier> PrjMarketOfferSuppliers { get; set; }
        [InverseProperty(nameof(PrjMarketOffer.PrjMarket))]
        public virtual ICollection<PrjMarketOffer> PrjMarketOffers { get; set; }
        [InverseProperty(nameof(PrjMarketPaymentPrevisionManual.PrjMarket))]
        public virtual ICollection<PrjMarketPaymentPrevisionManual> PrjMarketPaymentPrevisionManuals { get; set; }
        [InverseProperty(nameof(PrjMarketPaymentPrevision.PrjMarket))]
        public virtual ICollection<PrjMarketPaymentPrevision> PrjMarketPaymentPrevisions { get; set; }
        [InverseProperty(nameof(PrjMarketPrevision.PrjMarket))]
        public virtual ICollection<PrjMarketPrevision> PrjMarketPrevisions { get; set; }
        [InverseProperty(nameof(PrjMarketReception.PrjMarket))]
        public virtual ICollection<PrjMarketReception> PrjMarketReceptions { get; set; }
        [InverseProperty(nameof(PrjMarketStatusHistory.PrjMarket))]
        public virtual ICollection<PrjMarketStatusHistory> PrjMarketStatusHistories { get; set; }
        [InverseProperty(nameof(PrjMarketVentilationCategory.PrjMarket))]
        public virtual ICollection<PrjMarketVentilationCategory> PrjMarketVentilationCategories { get; set; }
        [InverseProperty(nameof(PrjMarketView.PrjMarket))]
        public virtual ICollection<PrjMarketView> PrjMarketViews { get; set; }
        [InverseProperty(nameof(PrjMarketWarrantyLine.PrjMarket))]
        public virtual ICollection<PrjMarketWarrantyLine> PrjMarketWarrantyLines { get; set; }
        [InverseProperty(nameof(PrjPrevisionDate.PrjMarket))]
        public virtual ICollection<PrjPrevisionDate> PrjPrevisionDates { get; set; }
        [InverseProperty("ManageProrataPrjMarket")]
        public virtual ICollection<PrjProject> PrjProjects { get; set; }
        [InverseProperty(nameof(PrjStockLineEstimation.PrjMarket))]
        public virtual ICollection<PrjStockLineEstimation> PrjStockLineEstimations { get; set; }
        [InverseProperty(nameof(PrjStockLine.PrjMarket))]
        public virtual ICollection<PrjStockLine> PrjStockLines { get; set; }
        [InverseProperty(nameof(PrjWorkingOut.PrjMarket))]
        public virtual ICollection<PrjWorkingOut> PrjWorkingOuts { get; set; }
        [InverseProperty(nameof(SavClaim.PrjMarketClaim))]
        public virtual ICollection<SavClaim> SavClaimPrjMarketClaims { get; set; }
        [InverseProperty(nameof(SavClaim.PrjMarket))]
        public virtual ICollection<SavClaim> SavClaimPrjMarkets { get; set; }
    }
}

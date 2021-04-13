using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [JsonObject(MemberSerialization.OptIn)]
    [Table("CfgTranche")]
    [Index(nameof(Pkey), nameof(CfgProjectId), nameof(Description), Name = "_dta_index_CfgTranche_5_1081770911__K1_K14_K3")]
    [Index(nameof(Description), nameof(IsForRent), Name = "_dta_index_CfgTranche_5_1081770911__K3_K33_1_2_4_5_6_7_8_9_10_11_12_13_14_15_16_17_18_19_20_21_22_23_24_25_26_27_28_29_30_31_")]
    public partial class CfgTranche
    {
        public CfgTranche()
        {
            ActDefaultAccounts = new HashSet<ActDefaultAccount>();
            ActStockVariationCoefs = new HashSet<ActStockVariationCoef>();
            ActStockVariationExclusions = new HashSet<ActStockVariationExclusion>();
            AdmEvents = new HashSet<AdmEvent>();
            AdmUserHabilitations = new HashSet<AdmUserHabilitation>();
            CfgPrevisions = new HashSet<CfgPrevision>();
            CfgTrancheCoveredFloors = new HashSet<CfgTrancheCoveredFloor>();
            CfgTrancheLevels = new HashSet<CfgTrancheLevel>();
            CfgTrancheSettlementCategories = new HashSet<CfgTrancheSettlementCategory>();
            CfgTrancheStatuses = new HashSet<CfgTrancheStatus>();
            CfgTrancheStkItems = new HashSet<CfgTrancheStkItem>();
            ComActionCfgTranches = new HashSet<ComActionCfgTranche>();
            ComCommissionLines = new HashSet<ComCommissionLine>();
            ComOffers = new HashSet<ComOffer>();
            ComPrevisionVersions = new HashSet<ComPrevisionVersion>();
            ComPrevisions = new HashSet<ComPrevision>();
            ComProspectionProjects = new HashSet<ComProspectionProject>();
            ComProspections = new HashSet<ComProspection>();
            ComSalesCommissions = new HashSet<ComSalesCommission>();
            PrjProjectCfgTrancheVentilations = new HashSet<PrjProjectCfgTrancheVentilation>();
            PrmRequestOffers = new HashSet<PrmRequestOffer>();
            PrvSettlementPrevisions = new HashSet<PrvSettlementPrevision>();
            PrvTurnoverPrevisions = new HashSet<PrvTurnoverPrevision>();
            SavServiceExpenses = new HashSet<SavServiceExpense>();
            StkFeasibilityStudyCfgTranches = new HashSet<StkFeasibilityStudyCfgTranche>();
            StkHierarchyPlans = new HashSet<StkHierarchyPlan>();
            StkItemExonarations = new HashSet<StkItemExonaration>();
            StkItems = new HashSet<StkItem>();
            StkPresentationTypes = new HashSet<StkPresentationType>();
            StlItemPricings = new HashSet<StlItemPricing>();
            StlProjectVentilations = new HashSet<StlProjectVentilation>();
            StlSalePrevisionManuals = new HashSet<StlSalePrevisionManual>();
            StlTrancheVentilationItems = new HashSet<StlTrancheVentilationItem>();
            SynPricings = new HashSet<SynPricing>();
        }

        [Key]

        [Column("PKey")]
        [JsonProperty]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        [JsonProperty]
        public string Description { get; set; }
        [StringLength(255)]
        [JsonProperty]
        public string Address { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string Mobile { get; set; }
        [StringLength(255)]
        public string Phone { get; set; }
        [StringLength(255)]
        public string Fax { get; set; }
        [StringLength(255)]
        public string WebSite { get; set; }
        [StringLength(255)]
        public string Address2 { get; set; }
        [StringLength(255)]
        public string Address3 { get; set; }
        [StringLength(255)]
        public string ZipCode { get; set; }
        [StringLength(255)]
        public string City { get; set; }
        public Guid? CfgProjectId { get; set; }
        public Guid? AdmCountryId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkEndDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MarketingStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? MarketingEndDate { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvancePercent { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ConcretisationPercent { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EcarttypeFinalisation { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EcarttypeConcretisation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDateConcretisation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDateFinalisation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }
        public Guid? StkLevelingId { get; set; }
        public bool? IsForSale { get; set; }
        public bool? IsForRent { get; set; }
        public bool? IsForProject { get; set; }
        public bool? IsForBuy { get; set; }
        public bool? IsForSav { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OccupancyPermitsDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BeforeReservationAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SyndicAmount { get; set; }
        public int? SyndicPeriod { get; set; }
        public int? WarrantyDelayAdded { get; set; }
        public int? WarrantyDelay { get; set; }
        public int? AgreementFirstDelay { get; set; }
        public int? AgreementSecondDelay { get; set; }
        public int? PaymentBalanceDelay { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BeforeReservationAmountDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvancePercentDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DefaultExpenseAmountDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DefaultExpenseAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CancellationPenalityPercent { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CancellationPenalityPercentDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ArticleTransferPenality { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ArticleTransferPenalityDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SliceTransferPenality { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SliceTransferPenalityDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CustomerTransferPenality { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CustomerTransferPenalityDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SyndicAmountDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? OtherExpenseAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? OtherExpenseAmountDiscount { get; set; }
        public bool? CancellationPenalityBasedOnItemPrice { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AgreementFirstPenaltyPercent { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AgreementSecondPenaltyPercent { get; set; }
        [StringLength(255)]
        public string CommerceTribunal { get; set; }
        [StringLength(255)]
        public string CancellationRightCode { get; set; }
        public Guid? CfgClaimsManagerId { get; set; }
        public int? CountItemBasePrevision { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TotalSaleBasePrevision { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BaseMarketingStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BaseEndDateConcretisation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BaseStartDateFinalisation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BaseMarketingEndDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseEcarttypeConcretisation { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseEcarttypeFinalisation { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? BaseConcretisationPercent { get; set; }
        [StringLength(500)]
        public string DescriptionLong { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Revival1Date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PrevisionMarketingStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PrevisionEndDateConcretisation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PrevisionStartDateFinalisation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PrevisionMarketingEndDate { get; set; }
        public int? DelayLawyerMinute { get; set; }
        public int? DelayMinuteAllSettled { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? UnitConcretisation { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? UnitFinalisation { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? UnitTurnover { get; set; }
        public Guid? CfgTierOtherId { get; set; }
        public Guid? CfgTrancheStandingId { get; set; }
        public Guid? LndLevelId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CoveredFloorArea { get; set; }
        [StringLength(255)]
        public string SavAddress { get; set; }
        public bool? IsWithGiftForProposer { get; set; }
        public bool? IsWithGiftForOldCustomer { get; set; }
        public int? InterventionMinimumDelai { get; set; }
        public int? MaxVisitNumber { get; set; }
        public bool? IsWithGiftForProspectionOrigin { get; set; }
        public bool? AccumulatedGifts { get; set; }
        public bool? IsActiveAdvancePercentDiscount { get; set; }
        public Guid? ComFolderStatusDeliveryId1 { get; set; }
        public Guid? ComFolderStatusDeliveryId2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceptionDate { get; set; }
        public Guid? ActAccountId { get; set; }
        public int? WithdrawalDelay { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AdvanceAmount { get; set; }
        public bool? AdvanceBasedOnAmount { get; set; }
        public bool? IsForPrm { get; set; }
        public Guid? PrjProjectId { get; set; }
        public bool? IsForRom { get; set; }

        [ForeignKey(nameof(ActAccountId))]
        [InverseProperty("CfgTranches")]
        public virtual ActAccount ActAccount { get; set; }
        [ForeignKey(nameof(AdmCountryId))]
        [InverseProperty("CfgTranches")]
        public virtual AdmCountry AdmCountry { get; set; }
        [ForeignKey(nameof(CfgClaimsManagerId))]
        [InverseProperty(nameof(CfgTier.CfgTrancheCfgClaimsManagers))]
        public virtual CfgTier CfgClaimsManager { get; set; }
        [ForeignKey(nameof(CfgProjectId))]
        [InverseProperty("CfgTranches")]
        public virtual CfgProject CfgProject { get; set; }
        [ForeignKey(nameof(CfgTierOtherId))]
        [InverseProperty(nameof(CfgTier.CfgTrancheCfgTierOthers))]
        public virtual CfgTier CfgTierOther { get; set; }
        [ForeignKey(nameof(CfgTrancheStandingId))]
        [InverseProperty("CfgTranches")]
        public virtual CfgTrancheStanding CfgTrancheStanding { get; set; }
        [ForeignKey(nameof(ComFolderStatusDeliveryId1))]
        [InverseProperty(nameof(ComFolderStatus.CfgTrancheComFolderStatusDeliveryId1Navigations))]
        public virtual ComFolderStatus ComFolderStatusDeliveryId1Navigation { get; set; }
        [ForeignKey(nameof(ComFolderStatusDeliveryId2))]
        [InverseProperty(nameof(ComFolderStatus.CfgTrancheComFolderStatusDeliveryId2Navigations))]
        public virtual ComFolderStatus ComFolderStatusDeliveryId2Navigation { get; set; }
        [ForeignKey(nameof(LndLevelId))]
        [InverseProperty("CfgTranches")]
        public virtual LndLevel LndLevel { get; set; }
        [ForeignKey(nameof(PrjProjectId))]
        [InverseProperty("CfgTranches")]
        public virtual PrjProject PrjProject { get; set; }
        [ForeignKey(nameof(StkLevelingId))]
        [InverseProperty("CfgTranches")]
        public virtual StkLeveling StkLeveling { get; set; }
        [InverseProperty(nameof(ActDefaultAccount.CfgTranche))]
        public virtual ICollection<ActDefaultAccount> ActDefaultAccounts { get; set; }
        [InverseProperty(nameof(ActStockVariationCoef.CfgTranche))]
        public virtual ICollection<ActStockVariationCoef> ActStockVariationCoefs { get; set; }
        [InverseProperty(nameof(ActStockVariationExclusion.CfgTranche))]
        public virtual ICollection<ActStockVariationExclusion> ActStockVariationExclusions { get; set; }
        [InverseProperty(nameof(AdmEvent.CfgTranche))]
        public virtual ICollection<AdmEvent> AdmEvents { get; set; }
        [InverseProperty(nameof(AdmUserHabilitation.CfgTranche))]
        public virtual ICollection<AdmUserHabilitation> AdmUserHabilitations { get; set; }
        [InverseProperty(nameof(CfgPrevision.StkHierarchy))]
        public virtual ICollection<CfgPrevision> CfgPrevisions { get; set; }
        [InverseProperty(nameof(CfgTrancheCoveredFloor.CfgTranche))]
        public virtual ICollection<CfgTrancheCoveredFloor> CfgTrancheCoveredFloors { get; set; }
        [InverseProperty(nameof(CfgTrancheLevel.CfgTranche))]
        public virtual ICollection<CfgTrancheLevel> CfgTrancheLevels { get; set; }
        [InverseProperty(nameof(CfgTrancheSettlementCategory.Cfgtranche))]
        public virtual ICollection<CfgTrancheSettlementCategory> CfgTrancheSettlementCategories { get; set; }
        [InverseProperty(nameof(CfgTrancheStatus.CfgTranche))]
        public virtual ICollection<CfgTrancheStatus> CfgTrancheStatuses { get; set; }
        [InverseProperty(nameof(CfgTrancheStkItem.CfgTranche))]
        public virtual ICollection<CfgTrancheStkItem> CfgTrancheStkItems { get; set; }
        [InverseProperty(nameof(ComActionCfgTranche.CfgTranche))]
        public virtual ICollection<ComActionCfgTranche> ComActionCfgTranches { get; set; }
        [InverseProperty(nameof(ComCommissionLine.CfgTranche))]
        public virtual ICollection<ComCommissionLine> ComCommissionLines { get; set; }
        [InverseProperty(nameof(ComOffer.StkHierarchy))]
        public virtual ICollection<ComOffer> ComOffers { get; set; }
        [InverseProperty(nameof(ComPrevisionVersion.StkHierarchy))]
        public virtual ICollection<ComPrevisionVersion> ComPrevisionVersions { get; set; }
        [InverseProperty(nameof(ComPrevision.StkHierarchy))]
        public virtual ICollection<ComPrevision> ComPrevisions { get; set; }
        [InverseProperty(nameof(ComProspectionProject.StkHierarchy))]
        public virtual ICollection<ComProspectionProject> ComProspectionProjects { get; set; }
        [InverseProperty(nameof(ComProspection.StkHierarchy))]
        public virtual ICollection<ComProspection> ComProspections { get; set; }
        [InverseProperty(nameof(ComSalesCommission.CfgTranche))]
        public virtual ICollection<ComSalesCommission> ComSalesCommissions { get; set; }
        [InverseProperty(nameof(PrjProjectCfgTrancheVentilation.CfgTranche))]
        public virtual ICollection<PrjProjectCfgTrancheVentilation> PrjProjectCfgTrancheVentilations { get; set; }
        [InverseProperty(nameof(PrmRequestOffer.CfgTranche))]
        public virtual ICollection<PrmRequestOffer> PrmRequestOffers { get; set; }
        [InverseProperty(nameof(PrvSettlementPrevision.CfgTranche))]
        public virtual ICollection<PrvSettlementPrevision> PrvSettlementPrevisions { get; set; }
        [InverseProperty(nameof(PrvTurnoverPrevision.CfgTranche))]
        public virtual ICollection<PrvTurnoverPrevision> PrvTurnoverPrevisions { get; set; }
        [InverseProperty(nameof(SavServiceExpense.CfgTranche))]
        public virtual ICollection<SavServiceExpense> SavServiceExpenses { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudyCfgTranche.CfgTranche))]
        public virtual ICollection<StkFeasibilityStudyCfgTranche> StkFeasibilityStudyCfgTranches { get; set; }
        [InverseProperty(nameof(StkHierarchyPlan.StkHierarchy))]
        public virtual ICollection<StkHierarchyPlan> StkHierarchyPlans { get; set; }
        [InverseProperty(nameof(StkItemExonaration.CfgTranche))]
        public virtual ICollection<StkItemExonaration> StkItemExonarations { get; set; }
        [InverseProperty(nameof(StkItem.StkHierarchy))]
        public virtual ICollection<StkItem> StkItems { get; set; }
        [InverseProperty(nameof(StkPresentationType.StkHierarchy))]
        public virtual ICollection<StkPresentationType> StkPresentationTypes { get; set; }
        [InverseProperty(nameof(StlItemPricing.CfgTranche))]
        public virtual ICollection<StlItemPricing> StlItemPricings { get; set; }
        [InverseProperty(nameof(StlProjectVentilation.CfgTranche))]
        public virtual ICollection<StlProjectVentilation> StlProjectVentilations { get; set; }
        [InverseProperty(nameof(StlSalePrevisionManual.CfgTranche))]
        public virtual ICollection<StlSalePrevisionManual> StlSalePrevisionManuals { get; set; }
        [InverseProperty(nameof(StlTrancheVentilationItem.CfgTranche))]
        public virtual ICollection<StlTrancheVentilationItem> StlTrancheVentilationItems { get; set; }
        [InverseProperty(nameof(SynPricing.CfgTranche))]
        public virtual ICollection<SynPricing> SynPricings { get; set; }
    }
}

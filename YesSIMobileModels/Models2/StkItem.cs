using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkItem")]
    [Index(nameof(RntFolderId), nameof(ParentId), nameof(StkVocationId), nameof(StkHierarchyId), nameof(Pkey), Name = "_dta_index_StkItem_5_1936725952__K121_K47_K55_K78_K1")]
    [Index(nameof(RntFolderId), nameof(ParentId), nameof(StkVocationId), nameof(StkHierarchyId), nameof(Pkey), nameof(StkPresentationTypeId), nameof(StkItemTypeId), nameof(StkItemCategoryId), nameof(Code), Name = "_dta_index_StkItem_5_1936725952__K121_K47_K55_K78_K1_K64_K48_K49_K2_3_6_45")]
    [Index(nameof(RntFolderId), nameof(StkVocationId), nameof(ParentId), nameof(Pkey), Name = "_dta_index_StkItem_5_1936725952__K121_K55_K47_K1")]
    [Index(nameof(Pkey), nameof(Code), Name = "_dta_index_StkItem_5_1936725952__K1_K2_3_78")]
    [Index(nameof(Pkey), nameof(Description), Name = "_dta_index_StkItem_5_1936725952__K1_K3")]
    [Index(nameof(Pkey), nameof(StkHierarchyId), Name = "_dta_index_StkItem_5_1936725952__K1_K78")]
    [Index(nameof(Pkey), nameof(StkHierarchyId), nameof(StkItemCategoryId), nameof(StkItemTypeId), nameof(StkPresentationTypeId), nameof(Code), Name = "_dta_index_StkItem_5_1936725952__K1_K78_K49_K48_K64_K2_3")]
    [Index(nameof(ParentId), nameof(SynFolderId), nameof(Pkey), nameof(StkHierarchyId), nameof(StkItemCategoryId), nameof(StkItemTypeId), nameof(StkPresentationTypeId), nameof(StkVocationId), nameof(Code), Name = "_dta_index_StkItem_5_1936725952__K47_K119_K1_K78_K49_K48_K64_K55_K2_3_6_45")]
    [Index(nameof(ParentId), nameof(Description), nameof(Pkey), nameof(RntFolderId), Name = "_dta_index_StkItem_5_1936725952__K47_K3_K1_K121")]
    [Index(nameof(ParentId), nameof(StkVocationId), nameof(SynFolderId), nameof(StkHierarchyId), nameof(Pkey), nameof(StkPresentationTypeId), nameof(StkItemCategoryId), nameof(StkItemTypeId), nameof(Code), Name = "_dta_index_StkItem_5_1936725952__K47_K55_K119_K78_K1_K64_K49_K48_K2_3_6_45")]
    [Index(nameof(ParentId), nameof(StkPresentationTypeId), nameof(StkItemTypeId), nameof(StkItemCategoryId), nameof(Pkey), nameof(StkHierarchyId), nameof(RntFolderId), nameof(StkVocationId), nameof(Code), Name = "_dta_index_StkItem_5_1936725952__K47_K64_K48_K49_K1_K78_K121_K55_K2_3_6_45")]
    [Index(nameof(ParentId), nameof(StkHierarchyId), nameof(StkVocationId), nameof(RntFolderId), nameof(StkPresentationTypeId), nameof(StkItemTypeId), nameof(StkItemCategoryId), nameof(Pkey), nameof(Code), Name = "_dta_index_StkItem_5_1936725952__K47_K78_K55_K121_K64_K48_K49_K1_K2_3_6_45")]
    [Index(nameof(StkHierarchyId), nameof(Pkey), nameof(ParentId), nameof(StkPresentationTypeId), nameof(StkItemTypeId), nameof(StkItemCategoryId), nameof(RntFolderId), nameof(StkVocationId), nameof(Code), Name = "_dta_index_StkItem_5_1936725952__K78_K1_K47_K64_K48_K49_K121_K55_K2_3_6_45")]
    [Index(nameof(IsUnderItem), nameof(ComFolderId), nameof(StkVocationId), nameof(StkPresentationTypeId), nameof(StkHierarchyId), nameof(Pkey), nameof(StkBuildingId), nameof(StkFloorId), nameof(StkItemTypeId), nameof(StkItemCategoryId), nameof(ParentId), nameof(IsUnderItemOrigin), nameof(Code), Name = "_dta_index_StkItem_7_1936725952__K16_K63_K55_K64_K78_K1_K73_K72_K48_K49_K47_K92_K2_3_5_11_13_14_68_85_118_123")]
    [Index(nameof(ParentId), nameof(ComFolderId), nameof(Pkey), nameof(Code), Name = "_dta_index_StkItem_7_1936725952__K47_K63_K1_K2_3_68")]
    [Index(nameof(ParentId), nameof(ComFolderId), nameof(Pkey), nameof(Code), nameof(IsUnderItemOrigin), nameof(Area), nameof(StkHierarchyId), nameof(StkBuildingId), nameof(StkFloorId), nameof(StkPresentationTypeId), nameof(StkItemTypeId), nameof(StkItemCategoryId), nameof(StkVocationId), nameof(IsUnderItem), nameof(ComSaleUnitCost), nameof(SalePrice), Name = "_dta_index_StkItem_7_1936725952__K47_K63_K1_K2_K92_K5_K78_K73_K72_K64_K48_K49_K55_K16_K11_K14_3_13_68_85_118_123")]
    [Index(nameof(ParentId), nameof(IsUnderItemOrigin), nameof(Area), Name = "_dta_index_StkItem_7_1936725952__K47_K92_K5")]
    [Index(nameof(StkHierarchyId), nameof(Pkey), Name = "_dta_index_StkItem_7_1936725952__K78_K1")]
    [Index(nameof(StkHierarchyId), nameof(StkPresentationTypeId), nameof(Pkey), nameof(StkBuildingId), nameof(StkItemTypeId), nameof(StkItemCategoryId), Name = "_dta_index_StkItem_7_1936725952__K78_K64_K1_K73_K48_K49_72")]
    public partial class StkItem
    {
        public StkItem()
        {
            BuyLoans = new HashSet<BuyLoan>();
            CfgTrancheStkItems = new HashSet<CfgTrancheStkItem>();
            ComActionMessages = new HashSet<ComActionMessage>();
            ComCommissionLines = new HashSet<ComCommissionLine>();
            ComFolderItems = new HashSet<ComFolderItem>();
            ComFolderStatusHistories = new HashSet<ComFolderStatusHistory>();
            ComFolders = new HashSet<ComFolder>();
            ComOfferItems = new HashSet<ComOfferItem>();
            ComProspectionProjects = new HashSet<ComProspectionProject>();
            ComProspections = new HashSet<ComProspection>();
            ComSaleWithdrawalCancellationStkItems = new HashSet<ComSaleWithdrawalCancellation>();
            ComSaleWithdrawalCancellationStkOldItems = new HashSet<ComSaleWithdrawalCancellation>();
            ComSaleWithdrawalClients = new HashSet<ComSaleWithdrawalClient>();
            ComSaleWithdrawalProductStkItems = new HashSet<ComSaleWithdrawalProduct>();
            ComSaleWithdrawalProductStkOldItems = new HashSet<ComSaleWithdrawalProduct>();
            InverseParent = new HashSet<StkItem>();
            PrmRequestOffers = new HashSet<PrmRequestOffer>();
            RntFolderItems = new HashSet<RntFolderItem>();
            RntFolders = new HashSet<RntFolder>();
            StkExpenses = new HashSet<StkExpense>();
            StkFeasibilityStudies = new HashSet<StkFeasibilityStudy>();
            StkHierarchyPaths = new HashSet<StkHierarchyPath>();
            StkItemContenances = new HashSet<StkItemContenance>();
            StkItemVues = new HashSet<StkItemVue>();
            SynFolders = new HashSet<SynFolder>();
            SynPricingItems = new HashSet<SynPricingItem>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Address { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Area { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ComSaleUnitCost { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ComSaleMinAdvance { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ComSalePrice { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SalePrice { get; set; }
        [StringLength(1000)]
        public string Contenance { get; set; }
        public bool? IsUnderItem { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AreaNetOld { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AreaFloor { get; set; }
        public bool? AlwaysAffected { get; set; }
        [StringLength(50)]
        public string ElectricityRef { get; set; }
        [StringLength(50)]
        public string ElectricityMeter { get; set; }
        [StringLength(50)]
        public string ElectricityMeterIndex { get; set; }
        [StringLength(50)]
        public string ElectricityMeterPolice { get; set; }
        [StringLength(50)]
        public string GasMeter { get; set; }
        [StringLength(50)]
        public string GasMeterIndex { get; set; }
        [StringLength(50)]
        public string GasMeterPolice { get; set; }
        [StringLength(50)]
        public string WaterMeterPolice { get; set; }
        [StringLength(50)]
        public string WaterMeter { get; set; }
        [StringLength(50)]
        public string WaterMeterIndex { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(1000)]
        public string Anomalies { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Cos { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Cuf { get; set; }
        public int? AlinmentStop { get; set; }
        public int? NeighborStop { get; set; }
        public int? MaxHeight { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? RegistryDate { get; set; }
        [StringLength(255)]
        public string RegistryNumber { get; set; }
        [StringLength(255)]
        public string RegistryPlace { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ImmatriculationDate { get; set; }
        [Column("ImmatriculationCPF")]
        [StringLength(255)]
        public string ImmatriculationCpf { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PurchaseDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PurchaseUnitCost { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PurchaseCost { get; set; }
        [Column("AmountHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountHt { get; set; }
        public int? CautionNumber { get; set; }
        public Guid? ParentId { get; set; }
        public Guid StkItemTypeId { get; set; }
        public Guid StkItemCategoryId { get; set; }
        public Guid? CfgSupplierId { get; set; }
        public Guid? StkCostCategoryId { get; set; }
        public Guid StkVocationId { get; set; }
        public Guid StkKindId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public Guid? ComFolderId { get; set; }
        public Guid? StkPresentationTypeId { get; set; }
        [StringLength(255)]
        public string WaterRef { get; set; }
        [StringLength(255)]
        public string GasRef { get; set; }
        [StringLength(255)]
        public string TitleNumberMother { get; set; }
        [StringLength(255)]
        public string TitleNumber { get; set; }
        [StringLength(255)]
        public string TitleName { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TitleDate { get; set; }
        [StringLength(255)]
        public string TitleNotes { get; set; }
        public Guid? StkFloorId { get; set; }
        public Guid? StkBuildingId { get; set; }
        public Guid? StkOrientationId { get; set; }
        public Guid? CfgCompanyId { get; set; }
        public Guid? CfgProjectId { get; set; }
        public Guid? StkHierarchyId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }
        [StringLength(255)]
        public string PropertyCalled { get; set; }
        [StringLength(255)]
        public string FractionDivided { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DividedPart { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? UndividedPart { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Vat { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AreaCos { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AreaCuf { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ComSaleUnitCostFloor { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SalePriceFloor { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ComSalePriceFloor { get; set; }
        public bool? IsUnderItemOrigin { get; set; }
        [StringLength(255)]
        public string FractionDividedLand { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DiscountMax { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EquipementsCoef { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EquipementsArea { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SalableArea { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CoefSaleAbleArea { get; set; }
        public Guid? LndVocationId { get; set; }
        public Guid? LndLevelId { get; set; }
        public Guid? CfgMiddlemanId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProspectionUnitCost { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProspectionPrice { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProspectionPriceProposed { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? UnitCostNonBuiltPrice { get; set; }
        [StringLength(255)]
        public string Owner { get; set; }
        [StringLength(1000)]
        public string GmapLink { get; set; }
        public Guid? CfgLawyerId { get; set; }
        public Guid? AdmCountryId { get; set; }
        public Guid? AdmCityId { get; set; }
        public Guid? LndLandId { get; set; }
        public Guid? StkFacadeId { get; set; }
        [Column("ComSaleUnitCostFloorHT", TypeName = "decimal(26, 6)")]
        public decimal? ComSaleUnitCostFloorHt { get; set; }
        [Column("ComSaleUnitCostHT", TypeName = "decimal(26, 6)")]
        public decimal? ComSaleUnitCostHt { get; set; }
        public Guid? SynFolderId { get; set; }
        [StringLength(255)]
        public string GroupLandQuota { get; set; }
        public Guid? RntFolderId { get; set; }
        [Column("SalePriceHT", TypeName = "decimal(26, 6)")]
        public decimal? SalePriceHt { get; set; }
        [Column("ComSalePriceHT", TypeName = "decimal(26, 6)")]
        public decimal? ComSalePriceHt { get; set; }
        [Column("SalePriceFloorHT", TypeName = "decimal(26, 6)")]
        public decimal? SalePriceFloorHt { get; set; }
        [Column("ComSalePriceFloorHT", TypeName = "decimal(26, 6)")]
        public decimal? ComSalePriceFloorHt { get; set; }
        public bool? IsAvailableForRentInWebSite { get; set; }
        public bool? IsAvailableForSaleInWebSite { get; set; }
        public Guid? CfgCompanySyndicId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BuildingPermissionDate { get; set; }
        public bool? IsTitled { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? InteriorArea { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WallsArea { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CommonPartsArea { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DiscountMax2 { get; set; }
        public Guid? CfgOwnerId { get; set; }
        public Guid? StrEntityId { get; set; }
        [Column(TypeName = "decimal(20, 16)")]
        public decimal? MapLatitude { get; set; }
        [Column(TypeName = "decimal(20, 16)")]
        public decimal? MapLongitude { get; set; }
        [Column(TypeName = "decimal(20, 16)")]
        public decimal? CommissionRate { get; set; }
        public Guid? RntPeriodicityId { get; set; }
        public bool? IsReversmentBasedOnPayment { get; set; }

        [ForeignKey(nameof(AdmCityId))]
        [InverseProperty("StkItems")]
        public virtual AdmCity AdmCity { get; set; }
        [ForeignKey(nameof(AdmCountryId))]
        [InverseProperty("StkItems")]
        public virtual AdmCountry AdmCountry { get; set; }
        [ForeignKey(nameof(CfgCompanyId))]
        [InverseProperty("StkItemCfgCompanies")]
        public virtual CfgCompany CfgCompany { get; set; }
        [ForeignKey(nameof(CfgCompanySyndicId))]
        [InverseProperty("StkItemCfgCompanySyndics")]
        public virtual CfgCompany CfgCompanySyndic { get; set; }
        [ForeignKey(nameof(CfgLawyerId))]
        [InverseProperty(nameof(CfgTier.StkItemCfgLawyers))]
        public virtual CfgTier CfgLawyer { get; set; }
        [ForeignKey(nameof(CfgMiddlemanId))]
        [InverseProperty(nameof(CfgTier.StkItemCfgMiddlemen))]
        public virtual CfgTier CfgMiddleman { get; set; }
        [ForeignKey(nameof(CfgOwnerId))]
        [InverseProperty(nameof(CfgTier.StkItemCfgOwners))]
        public virtual CfgTier CfgOwner { get; set; }
        [ForeignKey(nameof(CfgProjectId))]
        [InverseProperty("StkItems")]
        public virtual CfgProject CfgProject { get; set; }
        [ForeignKey(nameof(CfgSupplierId))]
        [InverseProperty(nameof(CfgTier.StkItemCfgSuppliers))]
        public virtual CfgTier CfgSupplier { get; set; }
        [ForeignKey(nameof(LndLandId))]
        [InverseProperty("StkItems")]
        public virtual LndLand LndLand { get; set; }
        [ForeignKey(nameof(LndLevelId))]
        [InverseProperty("StkItems")]
        public virtual LndLevel LndLevel { get; set; }
        [ForeignKey(nameof(LndVocationId))]
        [InverseProperty("StkItems")]
        public virtual LndVocation LndVocation { get; set; }
        [ForeignKey(nameof(ParentId))]
        [InverseProperty(nameof(StkItem.InverseParent))]
        public virtual StkItem Parent { get; set; }
        [ForeignKey(nameof(RntFolderId))]
        [InverseProperty("StkItems")]
        public virtual RntFolder RntFolder { get; set; }
        [ForeignKey(nameof(RntPeriodicityId))]
        [InverseProperty("StkItems")]
        public virtual RntPeriodicity RntPeriodicity { get; set; }
        [ForeignKey(nameof(StkBuildingId))]
        [InverseProperty("StkItems")]
        public virtual StkBuilding StkBuilding { get; set; }
        [ForeignKey(nameof(StkCostCategoryId))]
        [InverseProperty("StkItems")]
        public virtual StkCostCategory StkCostCategory { get; set; }
        [ForeignKey(nameof(StkFacadeId))]
        [InverseProperty("StkItems")]
        public virtual StkFacade StkFacade { get; set; }
        [ForeignKey(nameof(StkFloorId))]
        [InverseProperty("StkItems")]
        public virtual StkFloor StkFloor { get; set; }
        [ForeignKey(nameof(StkHierarchyId))]
        [InverseProperty(nameof(CfgTranche.StkItems))]
        public virtual CfgTranche StkHierarchy { get; set; }
        [ForeignKey(nameof(StkItemCategoryId))]
        [InverseProperty("StkItems")]
        public virtual StkItemCategory StkItemCategory { get; set; }
        [ForeignKey(nameof(StkItemTypeId))]
        [InverseProperty("StkItems")]
        public virtual StkItemType StkItemType { get; set; }
        [ForeignKey(nameof(StkKindId))]
        [InverseProperty("StkItems")]
        public virtual StkKind StkKind { get; set; }
        [ForeignKey(nameof(StkOrientationId))]
        [InverseProperty("StkItems")]
        public virtual StkOrientation StkOrientation { get; set; }
        [ForeignKey(nameof(StkPresentationTypeId))]
        [InverseProperty("StkItems")]
        public virtual StkPresentationType StkPresentationType { get; set; }
        [ForeignKey(nameof(StkVocationId))]
        [InverseProperty("StkItems")]
        public virtual StkVocation StkVocation { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("StkItems")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(SynFolderId))]
        [InverseProperty("StkItems")]
        public virtual SynFolder SynFolder { get; set; }
        [InverseProperty(nameof(BuyLoan.StkItem))]
        public virtual ICollection<BuyLoan> BuyLoans { get; set; }
        [InverseProperty(nameof(CfgTrancheStkItem.StkItem))]
        public virtual ICollection<CfgTrancheStkItem> CfgTrancheStkItems { get; set; }
        [InverseProperty(nameof(ComActionMessage.StkItem))]
        public virtual ICollection<ComActionMessage> ComActionMessages { get; set; }
        [InverseProperty(nameof(ComCommissionLine.StkItem))]
        public virtual ICollection<ComCommissionLine> ComCommissionLines { get; set; }
        [InverseProperty(nameof(ComFolderItem.StkItem))]
        public virtual ICollection<ComFolderItem> ComFolderItems { get; set; }
        [InverseProperty(nameof(ComFolderStatusHistory.StkItem))]
        public virtual ICollection<ComFolderStatusHistory> ComFolderStatusHistories { get; set; }
        [InverseProperty(nameof(ComFolder.StkItem))]
        public virtual ICollection<ComFolder> ComFolders { get; set; }
        [InverseProperty(nameof(ComOfferItem.StkItem))]
        public virtual ICollection<ComOfferItem> ComOfferItems { get; set; }
        [InverseProperty(nameof(ComProspectionProject.StkItem))]
        public virtual ICollection<ComProspectionProject> ComProspectionProjects { get; set; }
        [InverseProperty(nameof(ComProspection.StkItem))]
        public virtual ICollection<ComProspection> ComProspections { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalCancellation.StkItem))]
        public virtual ICollection<ComSaleWithdrawalCancellation> ComSaleWithdrawalCancellationStkItems { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalCancellation.StkOldItem))]
        public virtual ICollection<ComSaleWithdrawalCancellation> ComSaleWithdrawalCancellationStkOldItems { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalClient.StkOldItem))]
        public virtual ICollection<ComSaleWithdrawalClient> ComSaleWithdrawalClients { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalProduct.StkItem))]
        public virtual ICollection<ComSaleWithdrawalProduct> ComSaleWithdrawalProductStkItems { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalProduct.StkOldItem))]
        public virtual ICollection<ComSaleWithdrawalProduct> ComSaleWithdrawalProductStkOldItems { get; set; }
        [InverseProperty(nameof(StkItem.Parent))]
        public virtual ICollection<StkItem> InverseParent { get; set; }
        [InverseProperty(nameof(PrmRequestOffer.PrmProperty))]
        public virtual ICollection<PrmRequestOffer> PrmRequestOffers { get; set; }
        [InverseProperty(nameof(RntFolderItem.StkItem))]
        public virtual ICollection<RntFolderItem> RntFolderItems { get; set; }
        [InverseProperty("StkItem")]
        public virtual ICollection<RntFolder> RntFolders { get; set; }
        [InverseProperty(nameof(StkExpense.StkItem))]
        public virtual ICollection<StkExpense> StkExpenses { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudy.StkItem))]
        public virtual ICollection<StkFeasibilityStudy> StkFeasibilityStudies { get; set; }
        [InverseProperty(nameof(StkHierarchyPath.StkItem))]
        public virtual ICollection<StkHierarchyPath> StkHierarchyPaths { get; set; }
        [InverseProperty(nameof(StkItemContenance.StkItem))]
        public virtual ICollection<StkItemContenance> StkItemContenances { get; set; }
        [InverseProperty(nameof(StkItemVue.StkItem))]
        public virtual ICollection<StkItemVue> StkItemVues { get; set; }
        [InverseProperty("StkItem")]
        public virtual ICollection<SynFolder> SynFolders { get; set; }
        [InverseProperty(nameof(SynPricingItem.StkItem))]
        public virtual ICollection<SynPricingItem> SynPricingItems { get; set; }
    }
}

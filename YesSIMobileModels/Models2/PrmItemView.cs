using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class PrmItemView
    {
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Address { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(1000)]
        public string Contenance { get; set; }
        [StringLength(1000)]
        public string GmapLink { get; set; }
        [Column(TypeName = "decimal(20, 16)")]
        public decimal? MapLatitude { get; set; }
        [Column(TypeName = "decimal(20, 16)")]
        public decimal? MapLongitude { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal AreaNet { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Vat { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AreaCos { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AreaCuf { get; set; }
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
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EquipementsArea { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ComSaleMinAdvance { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DiscountMax { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DiscountMax2 { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AreaFloor { get; set; }
        [Column("ComSaleUnitCostFloorHT", TypeName = "decimal(26, 6)")]
        public decimal? ComSaleUnitCostFloorHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ComSaleUnitCostFloor { get; set; }
        [Column("ItemPriceFloorHT", TypeName = "decimal(26, 6)")]
        public decimal? ItemPriceFloorHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SalePriceFloor { get; set; }
        [Column("SalePriceUnderFloorHT", TypeName = "decimal(38, 6)")]
        public decimal SalePriceUnderFloorHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal SalePriceUnderFloor { get; set; }
        [Column("SalePriceFloorHT", TypeName = "decimal(26, 6)")]
        public decimal? SalePriceFloorHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ComSalePriceFloor { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Area { get; set; }
        [Column("ComSaleUnitCostHT", TypeName = "decimal(26, 6)")]
        public decimal? ComSaleUnitCostHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ComSaleUnitCost { get; set; }
        [Column("ItemPriceHT", TypeName = "decimal(26, 6)")]
        public decimal? ItemPriceHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ComSalePrice { get; set; }
        [Column("SalePriceUnderHT", TypeName = "decimal(38, 6)")]
        public decimal SalePriceUnderHt { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal SalePriceUnder { get; set; }
        [Column("SalePriceHT", TypeName = "decimal(26, 6)")]
        public decimal? SalePriceHt { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SalePrice { get; set; }
        [Column("AmountHT", TypeName = "decimal(26, 6)")]
        public decimal? AmountHt { get; set; }
        [Column("AmountTTC", TypeName = "decimal(38, 6)")]
        public decimal? AmountTtc { get; set; }
        public int? CautionNumber { get; set; }
        public Guid? CfgCompanySyndicId { get; set; }
        [StringLength(255)]
        public string CfgCompanySyndicCode { get; set; }
        [StringLength(255)]
        public string CfgCompanySyndicDescription { get; set; }
        [StringLength(50)]
        public string ElectricityRef { get; set; }
        [StringLength(50)]
        public string ElectricityMeterPolice { get; set; }
        [StringLength(50)]
        public string ElectricityMeter { get; set; }
        [StringLength(50)]
        public string ElectricityMeterIndex { get; set; }
        [StringLength(255)]
        public string GasRef { get; set; }
        [StringLength(50)]
        public string GasMeterPolice { get; set; }
        [StringLength(50)]
        public string GasMeter { get; set; }
        [StringLength(50)]
        public string GasMeterIndex { get; set; }
        [StringLength(255)]
        public string WaterRef { get; set; }
        [StringLength(50)]
        public string WaterMeterPolice { get; set; }
        [StringLength(50)]
        public string WaterMeter { get; set; }
        [StringLength(50)]
        public string WaterMeterIndex { get; set; }
        public bool? IsAvailableForSaleInWebSite { get; set; }
        public bool? IsAvailableForRentInWebSite { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? InteriorArea { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? WallsArea { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CommonPartsArea { get; set; }
        public string StkVueDescription { get; set; }
        public Guid? StkFacadeId { get; set; }
        [Required]
        [StringLength(255)]
        public string StkFacadeCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StkFacadeDescription { get; set; }
        public bool? IsTitled { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? RegistryDate { get; set; }
        [StringLength(255)]
        public string RegistryNumber { get; set; }
        [StringLength(255)]
        public string RegistryPlace { get; set; }
        [Column("ImmatriculationCPF")]
        [StringLength(255)]
        public string ImmatriculationCpf { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ImmatriculationDate { get; set; }
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
        [StringLength(255)]
        public string PropertyCalled { get; set; }
        [StringLength(255)]
        public string FractionDivided { get; set; }
        [StringLength(255)]
        public string FractionDividedLand { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DividedPart { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? UndividedPart { get; set; }
        [StringLength(255)]
        public string GroupLandQuota { get; set; }
        public Guid StkItemTypeId { get; set; }
        [StringLength(255)]
        public string StkItemTypeCode { get; set; }
        [StringLength(255)]
        public string StkItemTypeDescription { get; set; }
        [StringLength(500)]
        public string StkItemTypeReportDescription { get; set; }
        public bool? StkItemTypeWithAreaSale { get; set; }
        public Guid StkItemCategoryId { get; set; }
        [StringLength(255)]
        public string StkItemCategoryCode { get; set; }
        [StringLength(255)]
        public string StkItemCategoryDescription { get; set; }
        [StringLength(500)]
        public string StkItemCategoryReportDescription { get; set; }
        public bool? StkItemCategoryWithAreaSale { get; set; }
        public Guid StkVocationId { get; set; }
        [StringLength(255)]
        public string StkVocationCode { get; set; }
        [StringLength(255)]
        public string StkVocationDescription { get; set; }
        public Guid StkKindId { get; set; }
        [StringLength(255)]
        public string StkKindCode { get; set; }
        [StringLength(255)]
        public string StkKindDescription { get; set; }
        public Guid? StkPresentationTypeId { get; set; }
        [StringLength(255)]
        public string StkPresentationTypeCode { get; set; }
        [StringLength(255)]
        public string StkPresentationTypeDescription { get; set; }
        public Guid? StkFloorId { get; set; }
        public int? StkFloorSorting { get; set; }
        [StringLength(255)]
        public string StkFloorCode { get; set; }
        [StringLength(255)]
        public string StkFloorDescription { get; set; }
        public Guid? StkCostCategoryId { get; set; }
        [StringLength(255)]
        public string StkCostCategoryCode { get; set; }
        [StringLength(255)]
        public string StkCostCategoryDescription { get; set; }
        public Guid? StkBuildingId { get; set; }
        public int? StkBuildingSorting { get; set; }
        [StringLength(255)]
        public string StkBuildingCode { get; set; }
        [StringLength(255)]
        public string StkBuildingDescription { get; set; }
        public Guid? StkOrientationId { get; set; }
        [StringLength(255)]
        public string StkOrientationCode { get; set; }
        [StringLength(255)]
        public string StkOrientationDescription { get; set; }
        public Guid? CfgCompanyId { get; set; }
        [StringLength(255)]
        public string CfgCompanyCode { get; set; }
        [StringLength(255)]
        public string CfgCompanyDescription { get; set; }
        public Guid? CfgProjectId { get; set; }
        [StringLength(255)]
        public string CfgProjectCode { get; set; }
        [StringLength(255)]
        public string CfgProjectDescription { get; set; }
        public Guid? StkHierarchyId { get; set; }
        public Guid? CfgTrancheId { get; set; }
        [StringLength(255)]
        public string CfgTrancheCode { get; set; }
        [StringLength(255)]
        public string CfgTrancheDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OccupancyPermitsDate { get; set; }
        public bool? CfgTrancheIsForSale { get; set; }
        public Guid? ComFolderId { get; set; }
        [Column("IsASale")]
        public int? IsAsale { get; set; }
        public Guid? RntFolderId { get; set; }
        public Guid? SynFolderId { get; set; }
        [Column("IsARent")]
        public int? IsArent { get; set; }
        [StringLength(255)]
        public string ComFolderCode { get; set; }
        [StringLength(255)]
        public string Status { get; set; }
        [Column(TypeName = "image")]
        public byte[] StatusImg { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgTierDescription { get; set; }
        public Guid? ParentId { get; set; }
        [StringLength(255)]
        public string ParentCode { get; set; }
        [Required]
        [StringLength(255)]
        public string ParentDescription { get; set; }
        public bool? AlwaysAffected { get; set; }
        public bool? IsUnderItem { get; set; }
        public bool? IsUnderItemOrigin { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal AreaUnder { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal AreaUnderFloor { get; set; }
        public string UnderItemsCode { get; set; }
        public string UnderItemsDescription { get; set; }
        public Guid? CfgSupplierId { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal TotalCost { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? UnitCost { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PurchaseDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BuildingPermissionDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PurchaseUnitCost { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PurchaseCost { get; set; }
        public Guid? CfgLawyerId { get; set; }
        [StringLength(255)]
        public string CfgLawyerDescription { get; set; }
        public Guid? AdmCityId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCityCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCityDescription { get; set; }
        public Guid? AdmCountryId { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCountryCode { get; set; }
        [Required]
        [StringLength(255)]
        public string AdmCountryDescription { get; set; }
        public Guid? CfgOwnerId { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgOwnerCode { get; set; }
        [Required]
        [StringLength(255)]
        public string CfgOwnerDescription { get; set; }
        [Column(TypeName = "decimal(20, 16)")]
        public decimal? CommissionRate { get; set; }
        public Guid? RntPeriodicityId { get; set; }
        [Required]
        [StringLength(255)]
        public string RntPeriodicityCode { get; set; }
        [Required]
        [StringLength(255)]
        public string RntPeriodicityDescription { get; set; }
        public bool? IsReversmentBasedOnPayment { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column(TypeName = "decimal(38, 6)")]
        public decimal? TitledArea { get; set; }
        public Guid? StrEntityId { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityCode { get; set; }
        [Required]
        [StringLength(255)]
        public string StrEntityDescription { get; set; }
    }
}

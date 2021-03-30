using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("LndLand")]
    public partial class LndLand
    {
        public LndLand()
        {
            StkFeasibilityStudies = new HashSet<StkFeasibilityStudy>();
            StkItems = new HashSet<StkItem>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DocDate { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        [StringLength(1000)]
        public string Anomalies { get; set; }
        [StringLength(255)]
        public string Adress { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Area { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Cos { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Cuf { get; set; }
        public int? AlinmentStop { get; set; }
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
        public Guid? LndCategoryId { get; set; }
        public Guid? LndTypeId { get; set; }
        public Guid? LndVocationId { get; set; }
        public Guid? LndLevelId { get; set; }
        public Guid? CfgSupplierId { get; set; }
        public Guid? CfgDelegationId { get; set; }
        public bool? IsInArchive { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProspectionUnitCost { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProspectionPrice { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ProspectionPriceProposed { get; set; }
        [StringLength(255)]
        public string Owner { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? UnitCostNonBuiltPrice { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StatusValidityDate { get; set; }
        public Guid? CfgMiddlemanId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AreaCos { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AreaCuf { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EquipementsCoef { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? EquipementsArea { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? AreaNet { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? SalableArea { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? CoefSaleableArea { get; set; }
        public Guid? AdmCountryId { get; set; }
        public Guid? AdmCityId { get; set; }
        [StringLength(1000)]
        public string GmapLink { get; set; }
        public Guid? CfgLawyerId { get; set; }
        public Guid? StkOrientationId { get; set; }
        public bool? IsTransformedToLand { get; set; }
        public Guid? StrStatusId { get; set; }
        public Guid? StrEntityId { get; set; }

        [ForeignKey(nameof(AdmCityId))]
        [InverseProperty("LndLands")]
        public virtual AdmCity AdmCity { get; set; }
        [ForeignKey(nameof(AdmCountryId))]
        [InverseProperty("LndLands")]
        public virtual AdmCountry AdmCountry { get; set; }
        [ForeignKey(nameof(CfgDelegationId))]
        [InverseProperty("LndLands")]
        public virtual CfgDelegation CfgDelegation { get; set; }
        [ForeignKey(nameof(CfgLawyerId))]
        [InverseProperty(nameof(CfgTier.LndLandCfgLawyers))]
        public virtual CfgTier CfgLawyer { get; set; }
        [ForeignKey(nameof(CfgMiddlemanId))]
        [InverseProperty(nameof(CfgTier.LndLandCfgMiddlemen))]
        public virtual CfgTier CfgMiddleman { get; set; }
        [ForeignKey(nameof(CfgSupplierId))]
        [InverseProperty(nameof(CfgTier.LndLandCfgSuppliers))]
        public virtual CfgTier CfgSupplier { get; set; }
        [ForeignKey(nameof(LndCategoryId))]
        [InverseProperty(nameof(StkItemCategory.LndLands))]
        public virtual StkItemCategory LndCategory { get; set; }
        [ForeignKey(nameof(LndLevelId))]
        [InverseProperty("LndLands")]
        public virtual LndLevel LndLevel { get; set; }
        [ForeignKey(nameof(LndTypeId))]
        [InverseProperty(nameof(StkItemType.LndLands))]
        public virtual StkItemType LndType { get; set; }
        [ForeignKey(nameof(LndVocationId))]
        [InverseProperty("LndLands")]
        public virtual LndVocation LndVocation { get; set; }
        [ForeignKey(nameof(StkOrientationId))]
        [InverseProperty("LndLands")]
        public virtual StkOrientation StkOrientation { get; set; }
        [ForeignKey(nameof(StrEntityId))]
        [InverseProperty("LndLands")]
        public virtual StrEntity StrEntity { get; set; }
        [ForeignKey(nameof(StrStatusId))]
        [InverseProperty("LndLands")]
        public virtual StrStatus StrStatus { get; set; }
        [InverseProperty(nameof(StkFeasibilityStudy.LndLand))]
        public virtual ICollection<StkFeasibilityStudy> StkFeasibilityStudies { get; set; }
        [InverseProperty(nameof(StkItem.LndLand))]
        public virtual ICollection<StkItem> StkItems { get; set; }
    }
}

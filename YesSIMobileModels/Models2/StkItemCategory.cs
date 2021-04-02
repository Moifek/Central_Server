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
    [Table("StkItemCategory")]
    public partial class StkItemCategory
    {
        public StkItemCategory()
        {
            ActStockVariationCoefs = new HashSet<ActStockVariationCoef>();
            CfgTrancheCoveredFloors = new HashSet<CfgTrancheCoveredFloor>();
            ComCommissionLines = new HashSet<ComCommissionLine>();
            ComFolderItems = new HashSet<ComFolderItem>();
            ComOfferItems = new HashSet<ComOfferItem>();
            ComProspectionCategories = new HashSet<ComProspectionCategory>();
            ComSaleWithdrawalProductNewUnderItems = new HashSet<ComSaleWithdrawalProductNewUnderItem>();
            ComSaleWithdrawalProductUnderItems = new HashSet<ComSaleWithdrawalProductUnderItem>();
            ComSalesCommissions = new HashSet<ComSalesCommission>();
            LndLands = new HashSet<LndLand>();
            PrmRequestOffers = new HashSet<PrmRequestOffer>();
            RntFolderItems = new HashSet<RntFolderItem>();
            SavServiceExpenses = new HashSet<SavServiceExpense>();
            StkFsbaseUnits = new HashSet<StkFsbaseUnit>();
            StkItems = new HashSet<StkItem>();
            StlItemPricings = new HashSet<StlItemPricing>();
        }

        [Key]
        [JsonProperty]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        [JsonProperty]
        public string Code { get; set; }
        [StringLength(255)]
        [JsonProperty]
        public string Description { get; set; }
        public bool? ForUnderItem { get; set; }
        public Guid StkKindId { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        public bool? WithAreaSale { get; set; }
        [StringLength(500)]
        public string ReportDescription { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StockVariationCoef { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }
        public Guid? StlCategoryId { get; set; }

        [ForeignKey(nameof(StkKindId))]
        [InverseProperty("StkItemCategories")]
        public virtual StkKind StkKind { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("StkItemCategories")]
        public virtual StlCategory StlCategory { get; set; }
        [InverseProperty(nameof(ActStockVariationCoef.StkItemCategory))]
        public virtual ICollection<ActStockVariationCoef> ActStockVariationCoefs { get; set; }
        [InverseProperty(nameof(CfgTrancheCoveredFloor.StkItemCategory))]
        public virtual ICollection<CfgTrancheCoveredFloor> CfgTrancheCoveredFloors { get; set; }
        [InverseProperty(nameof(ComCommissionLine.StkItemCategory))]
        public virtual ICollection<ComCommissionLine> ComCommissionLines { get; set; }
        [InverseProperty(nameof(ComFolderItem.StkItemCategory))]
        public virtual ICollection<ComFolderItem> ComFolderItems { get; set; }
        [InverseProperty(nameof(ComOfferItem.StkItemCategory))]
        public virtual ICollection<ComOfferItem> ComOfferItems { get; set; }
        [InverseProperty(nameof(ComProspectionCategory.StkItemCategory))]
        public virtual ICollection<ComProspectionCategory> ComProspectionCategories { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalProductNewUnderItem.StkItemCategory))]
        public virtual ICollection<ComSaleWithdrawalProductNewUnderItem> ComSaleWithdrawalProductNewUnderItems { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalProductUnderItem.StkItemCategory))]
        public virtual ICollection<ComSaleWithdrawalProductUnderItem> ComSaleWithdrawalProductUnderItems { get; set; }
        [InverseProperty(nameof(ComSalesCommission.StkItemCategory))]
        public virtual ICollection<ComSalesCommission> ComSalesCommissions { get; set; }
        [InverseProperty(nameof(LndLand.LndCategory))]
        public virtual ICollection<LndLand> LndLands { get; set; }
        [InverseProperty(nameof(PrmRequestOffer.PrmPropertyCategory))]
        public virtual ICollection<PrmRequestOffer> PrmRequestOffers { get; set; }
        [InverseProperty(nameof(RntFolderItem.StkItemCategory))]
        public virtual ICollection<RntFolderItem> RntFolderItems { get; set; }
        [InverseProperty(nameof(SavServiceExpense.StkItemCategory))]
        public virtual ICollection<SavServiceExpense> SavServiceExpenses { get; set; }
        [InverseProperty(nameof(StkFsbaseUnit.StkItemCategory))]
        public virtual ICollection<StkFsbaseUnit> StkFsbaseUnits { get; set; }
        [InverseProperty(nameof(StkItem.StkItemCategory))]
        public virtual ICollection<StkItem> StkItems { get; set; }
        [InverseProperty(nameof(StlItemPricing.StkItemCategory))]
        public virtual ICollection<StlItemPricing> StlItemPricings { get; set; }
    }
}

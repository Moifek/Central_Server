using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("StkItemType")]
    public partial class StkItemType
    {
        public StkItemType()
        {
            ComFolderItems = new HashSet<ComFolderItem>();
            ComOfferItems = new HashSet<ComOfferItem>();
            ComProspectionTypes = new HashSet<ComProspectionType>();
            ComSaleWithdrawalProductNewUnderItems = new HashSet<ComSaleWithdrawalProductNewUnderItem>();
            ComSaleWithdrawalProductUnderItems = new HashSet<ComSaleWithdrawalProductUnderItem>();
            LndLands = new HashSet<LndLand>();
            PrmRequestOffers = new HashSet<PrmRequestOffer>();
            RntFolderItems = new HashSet<RntFolderItem>();
            SavServiceExpenses = new HashSet<SavServiceExpense>();
            StkItems = new HashSet<StkItem>();
            StlItemPricings = new HashSet<StlItemPricing>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        [StringLength(255)]
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
        public Guid? StlCategoryId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? StockVariationCoef { get; set; }
        [StringLength(500)]
        public string Notes { get; set; }

        [ForeignKey(nameof(StkKindId))]
        [InverseProperty("StkItemTypes")]
        public virtual StkKind StkKind { get; set; }
        [ForeignKey(nameof(StlCategoryId))]
        [InverseProperty("StkItemTypes")]
        public virtual StlCategory StlCategory { get; set; }
        [InverseProperty(nameof(ComFolderItem.StkItemType))]
        public virtual ICollection<ComFolderItem> ComFolderItems { get; set; }
        [InverseProperty(nameof(ComOfferItem.StkItemType))]
        public virtual ICollection<ComOfferItem> ComOfferItems { get; set; }
        [InverseProperty(nameof(ComProspectionType.StkItemType))]
        public virtual ICollection<ComProspectionType> ComProspectionTypes { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalProductNewUnderItem.StkItemType))]
        public virtual ICollection<ComSaleWithdrawalProductNewUnderItem> ComSaleWithdrawalProductNewUnderItems { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalProductUnderItem.StkItemType))]
        public virtual ICollection<ComSaleWithdrawalProductUnderItem> ComSaleWithdrawalProductUnderItems { get; set; }
        [InverseProperty(nameof(LndLand.LndType))]
        public virtual ICollection<LndLand> LndLands { get; set; }
        [InverseProperty(nameof(PrmRequestOffer.PrmPropertyType))]
        public virtual ICollection<PrmRequestOffer> PrmRequestOffers { get; set; }
        [InverseProperty(nameof(RntFolderItem.StkItemType))]
        public virtual ICollection<RntFolderItem> RntFolderItems { get; set; }
        [InverseProperty(nameof(SavServiceExpense.StkItemType))]
        public virtual ICollection<SavServiceExpense> SavServiceExpenses { get; set; }
        [InverseProperty(nameof(StkItem.StkItemType))]
        public virtual ICollection<StkItem> StkItems { get; set; }
        [InverseProperty(nameof(StlItemPricing.StkItemType))]
        public virtual ICollection<StlItemPricing> StlItemPricings { get; set; }
    }
}

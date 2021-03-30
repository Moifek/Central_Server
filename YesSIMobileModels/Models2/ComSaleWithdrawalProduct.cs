using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComSaleWithdrawalProduct")]
    public partial class ComSaleWithdrawalProduct
    {
        public ComSaleWithdrawalProduct()
        {
            ActEntries = new HashSet<ActEntry>();
            ComActionMessages = new HashSet<ComActionMessage>();
            ComDocuments = new HashSet<ComDocument>();
            ComFolderStatusHistories = new HashSet<ComFolderStatusHistory>();
            ComSaleWithdrawalProductNewUnderItems = new HashSet<ComSaleWithdrawalProductNewUnderItem>();
            ComSaleWithdrawalProductUnderItems = new HashSet<ComSaleWithdrawalProductUnderItem>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        public Guid? ComSaleId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TotalToPay { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TotalRest { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TotalSettled { get; set; }
        public Guid? StkItemId { get; set; }
        public Guid? CfgCustomerId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? NewStkItemTotalToPay { get; set; }
        public Guid? StkOldItemId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ClaimDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DecisionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ValidityDate { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TransfertExpenseAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ReimburseAmount { get; set; }
        public bool? IsLegalized { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LegalizationDate { get; set; }
        public Guid? ComSaleWithdrawalReasonId { get; set; }
        public Guid? ComProspectionOriginId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Discount { get; set; }
        [StringLength(255)]
        public string UserCreate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserCreateDateTime { get; set; }
        [StringLength(255)]
        public string UserUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UserUpdateDateTime { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TransfertExpenseAmountAfterDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ItemPrice { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? UnderItemsPrice { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PriceBeforeDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PriceAfterDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DiscountAmount { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public bool? IsAccounted { get; set; }

        [ForeignKey(nameof(CfgCustomerId))]
        [InverseProperty(nameof(CfgTier.ComSaleWithdrawalProducts))]
        public virtual CfgTier CfgCustomer { get; set; }
        [ForeignKey(nameof(ComProspectionOriginId))]
        [InverseProperty("ComSaleWithdrawalProducts")]
        public virtual ComProspectionOrigin ComProspectionOrigin { get; set; }
        [ForeignKey(nameof(ComSaleId))]
        [InverseProperty(nameof(ComFolder.ComSaleWithdrawalProducts))]
        public virtual ComFolder ComSale { get; set; }
        [ForeignKey(nameof(ComSaleWithdrawalReasonId))]
        [InverseProperty("ComSaleWithdrawalProducts")]
        public virtual ComSaleWithdrawalReason ComSaleWithdrawalReason { get; set; }
        [ForeignKey(nameof(StkItemId))]
        [InverseProperty("ComSaleWithdrawalProductStkItems")]
        public virtual StkItem StkItem { get; set; }
        [ForeignKey(nameof(StkOldItemId))]
        [InverseProperty("ComSaleWithdrawalProductStkOldItems")]
        public virtual StkItem StkOldItem { get; set; }
        [InverseProperty(nameof(ActEntry.ComSaleWithdrawalProduct))]
        public virtual ICollection<ActEntry> ActEntries { get; set; }
        [InverseProperty(nameof(ComActionMessage.ComSaleWithdrawalProduct))]
        public virtual ICollection<ComActionMessage> ComActionMessages { get; set; }
        [InverseProperty(nameof(ComDocument.ComSaleWithdrawalProduct))]
        public virtual ICollection<ComDocument> ComDocuments { get; set; }
        [InverseProperty(nameof(ComFolderStatusHistory.ComSaleWithdrawalProduct))]
        public virtual ICollection<ComFolderStatusHistory> ComFolderStatusHistories { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalProductNewUnderItem.ComSaleWithdrawalProduct))]
        public virtual ICollection<ComSaleWithdrawalProductNewUnderItem> ComSaleWithdrawalProductNewUnderItems { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalProductUnderItem.ComSaleWithdrawalProduct))]
        public virtual ICollection<ComSaleWithdrawalProductUnderItem> ComSaleWithdrawalProductUnderItems { get; set; }
    }
}

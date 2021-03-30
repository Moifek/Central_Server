using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComSaleWithdrawalCancellation")]
    public partial class ComSaleWithdrawalCancellation
    {
        public ComSaleWithdrawalCancellation()
        {
            ActEntries = new HashSet<ActEntry>();
            ComActionMessages = new HashSet<ComActionMessage>();
            ComDocuments = new HashSet<ComDocument>();
            ComFolderStatusHistories = new HashSet<ComFolderStatusHistory>();
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
        public Guid? CfgOldCustomerId { get; set; }
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
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? StlSettlementTypeId { get; set; }
        [StringLength(255)]
        public string Reference { get; set; }
        public Guid? CfgBankId { get; set; }
        public bool? IsAccounted { get; set; }
        public Guid? CfgContactId { get; set; }

        [ForeignKey(nameof(CfgBankId))]
        [InverseProperty(nameof(CfgTier.ComSaleWithdrawalCancellationCfgBanks))]
        public virtual CfgTier CfgBank { get; set; }
        [ForeignKey(nameof(CfgContactId))]
        [InverseProperty(nameof(CfgTier.ComSaleWithdrawalCancellationCfgContacts))]
        public virtual CfgTier CfgContact { get; set; }
        [ForeignKey(nameof(CfgOldCustomerId))]
        [InverseProperty(nameof(CfgTier.ComSaleWithdrawalCancellationCfgOldCustomers))]
        public virtual CfgTier CfgOldCustomer { get; set; }
        [ForeignKey(nameof(ComProspectionOriginId))]
        [InverseProperty("ComSaleWithdrawalCancellations")]
        public virtual ComProspectionOrigin ComProspectionOrigin { get; set; }
        [ForeignKey(nameof(ComSaleId))]
        [InverseProperty(nameof(ComFolder.ComSaleWithdrawalCancellations))]
        public virtual ComFolder ComSale { get; set; }
        [ForeignKey(nameof(ComSaleWithdrawalReasonId))]
        [InverseProperty("ComSaleWithdrawalCancellations")]
        public virtual ComSaleWithdrawalReason ComSaleWithdrawalReason { get; set; }
        [ForeignKey(nameof(StkItemId))]
        [InverseProperty("ComSaleWithdrawalCancellationStkItems")]
        public virtual StkItem StkItem { get; set; }
        [ForeignKey(nameof(StkOldItemId))]
        [InverseProperty("ComSaleWithdrawalCancellationStkOldItems")]
        public virtual StkItem StkOldItem { get; set; }
        [ForeignKey(nameof(StlSettlementTypeId))]
        [InverseProperty("ComSaleWithdrawalCancellations")]
        public virtual StlSettlementType StlSettlementType { get; set; }
        [InverseProperty(nameof(ActEntry.ComSaleWithdrawalCancellation))]
        public virtual ICollection<ActEntry> ActEntries { get; set; }
        [InverseProperty(nameof(ComActionMessage.ComSaleWithdrawalCancellation))]
        public virtual ICollection<ComActionMessage> ComActionMessages { get; set; }
        [InverseProperty(nameof(ComDocument.ComSaleWithdrawalCancellation))]
        public virtual ICollection<ComDocument> ComDocuments { get; set; }
        [InverseProperty(nameof(ComFolderStatusHistory.ComSaleWithdrawalCancellation))]
        public virtual ICollection<ComFolderStatusHistory> ComFolderStatusHistories { get; set; }
    }
}

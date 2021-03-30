using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Table("ComSaleWithdrawalClient")]
    public partial class ComSaleWithdrawalClient
    {
        public ComSaleWithdrawalClient()
        {
            ActEntries = new HashSet<ActEntry>();
            ComActionMessages = new HashSet<ComActionMessage>();
            ComDocuments = new HashSet<ComDocument>();
            ComFolderStatusHistories = new HashSet<ComFolderStatusHistory>();
            ComSaleWithdrawalClientNewCustomers = new HashSet<ComSaleWithdrawalClientNewCustomer>();
            ComSaleWithdrawalClientOldCustomers = new HashSet<ComSaleWithdrawalClientOldCustomer>();
        }

        [Key]
        [Column("PKey")]
        public Guid Pkey { get; set; }
        [StringLength(255)]
        public string Code { get; set; }
        public Guid? ComSaleId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? NewStkItemTotalToPay { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TotalToPay { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TotalRest { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? TotalSettled { get; set; }
        public Guid? StkOldItemId { get; set; }
        public Guid? CfgCustomerId { get; set; }
        public Guid? CfgOldCustomerId { get; set; }
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
        public decimal? PartPercent { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? NewPartPercent { get; set; }
        [StringLength(1000)]
        public string Notes { get; set; }
        public bool? IsAccounted { get; set; }

        [ForeignKey(nameof(CfgCustomerId))]
        [InverseProperty(nameof(CfgTier.ComSaleWithdrawalClientCfgCustomers))]
        public virtual CfgTier CfgCustomer { get; set; }
        [ForeignKey(nameof(CfgOldCustomerId))]
        [InverseProperty(nameof(CfgTier.ComSaleWithdrawalClientCfgOldCustomers))]
        public virtual CfgTier CfgOldCustomer { get; set; }
        [ForeignKey(nameof(ComProspectionOriginId))]
        [InverseProperty("ComSaleWithdrawalClients")]
        public virtual ComProspectionOrigin ComProspectionOrigin { get; set; }
        [ForeignKey(nameof(ComSaleId))]
        [InverseProperty(nameof(ComFolder.ComSaleWithdrawalClients))]
        public virtual ComFolder ComSale { get; set; }
        [ForeignKey(nameof(ComSaleWithdrawalReasonId))]
        [InverseProperty("ComSaleWithdrawalClients")]
        public virtual ComSaleWithdrawalReason ComSaleWithdrawalReason { get; set; }
        [ForeignKey(nameof(StkOldItemId))]
        [InverseProperty(nameof(StkItem.ComSaleWithdrawalClients))]
        public virtual StkItem StkOldItem { get; set; }
        [InverseProperty(nameof(ActEntry.ComSaleWithdrawalClient))]
        public virtual ICollection<ActEntry> ActEntries { get; set; }
        [InverseProperty(nameof(ComActionMessage.ComSaleWithdrawalClient))]
        public virtual ICollection<ComActionMessage> ComActionMessages { get; set; }
        [InverseProperty(nameof(ComDocument.ComSaleWithdrawalClient))]
        public virtual ICollection<ComDocument> ComDocuments { get; set; }
        [InverseProperty(nameof(ComFolderStatusHistory.ComSaleWithdrawalClient))]
        public virtual ICollection<ComFolderStatusHistory> ComFolderStatusHistories { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalClientNewCustomer.ComSaleWithdrawalClient))]
        public virtual ICollection<ComSaleWithdrawalClientNewCustomer> ComSaleWithdrawalClientNewCustomers { get; set; }
        [InverseProperty(nameof(ComSaleWithdrawalClientOldCustomer.ComSaleWithdrawalClient))]
        public virtual ICollection<ComSaleWithdrawalClientOldCustomer> ComSaleWithdrawalClientOldCustomers { get; set; }
    }
}

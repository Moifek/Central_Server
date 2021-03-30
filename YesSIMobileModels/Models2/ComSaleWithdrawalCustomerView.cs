using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class ComSaleWithdrawalCustomerView
    {
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
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? ComProspectionOriginId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Discount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PartPercent { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? NewPartPercent { get; set; }
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
        [StringLength(255)]
        public string ComFolderCode { get; set; }
        public Guid? StkHierarchyId { get; set; }
        [StringLength(255)]
        public string FromCfgCompanyDescription { get; set; }
        [StringLength(255)]
        public string FromCfgProjectDescription { get; set; }
        [StringLength(255)]
        public string FromCfgTrancheDescription { get; set; }
        [StringLength(255)]
        public string FromStkItemCode { get; set; }
        [StringLength(255)]
        public string FromStkItemCategoryDescription { get; set; }
        [StringLength(255)]
        public string FromStkItemTypeDescription { get; set; }
        [StringLength(255)]
        public string OldCfgTierViewDescription { get; set; }
        [StringLength(255)]
        public string NewCfgTierViewDescription { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FromTotalTopay { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FromTotalTopaySettled { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FromTotalTopayRest { get; set; }
        [StringLength(255)]
        public string ComSaleWithdrawalReasonCode { get; set; }
        [StringLength(255)]
        public string ComSaleWithdrawalReasonDescription { get; set; }
        public bool? IsOldCustomer { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastCommunicationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastActiveAlertDate { get; set; }
    }
}

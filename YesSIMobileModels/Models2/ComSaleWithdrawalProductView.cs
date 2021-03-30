using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace YesSIMobileModels.Models2
{
    [Keyless]
    public partial class ComSaleWithdrawalProductView
    {
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
        [StringLength(1000)]
        public string Notes { get; set; }
        public Guid? ComProspectionOriginId { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? Discount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? DiscountAmount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PriceAfterDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? PriceBeforeDiscount { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ItemPrice { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? UnderItemsPrice { get; set; }
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
        public string CfgTierViewDescription { get; set; }
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
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? FromTotalTopay { get; set; }
        [StringLength(255)]
        public string ToCfgCompanyDescription { get; set; }
        [StringLength(255)]
        public string ToCfgProjectDescription { get; set; }
        [StringLength(255)]
        public string ToCfgTrancheDescription { get; set; }
        [StringLength(255)]
        public string ToStkItemCode { get; set; }
        [StringLength(255)]
        public string ToStkItemCategoryDescription { get; set; }
        [StringLength(255)]
        public string ToStkItemTypeDescription { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ToItemPrice { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ToItemPriceSettled { get; set; }
        [Column(TypeName = "decimal(26, 6)")]
        public decimal? ToItemPriceRest { get; set; }
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
